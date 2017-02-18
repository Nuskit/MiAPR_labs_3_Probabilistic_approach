using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probabilistic_approach
{
  struct Shedule
  {
    public double x;
    public double[] y;
  }

  struct SheduleErrors
  {
    public double falseAlarm;
    public double crossDetection;
    public double totalError;
  }

  class ProbabilityShedule
  {
    private double eps = 1e-6;
    private const int countClassifier = 2;
    private static Random normalDistribution = new Random();
    private int countPoint;
    private double[] pc;

    public Shedule[] ResultPoint { get; private set; }

    public double Separate { get; private set; }

    public ProbabilityShedule(int countPoint, double[] pc)
    {
      if (pc.Length != countClassifier)
        new ArgumentOutOfRangeException("pc", String.Format("Length != {0}", countClassifier));
      this.countPoint = countPoint;
      this.pc = pc;
      GenerateBaseShedule(countPoint);
    }

    private void GenerateBaseShedule(int countPoint)
    {
      ResultPoint = new Shedule[countPoint];
      for (int i = 0; i < countPoint; i++)
        ResultPoint[i].y = new double[countClassifier];
    }

    public void CalculateShedule()
    {
      CalculateAllClassifier();
      CalculateSeparate();
    }

    public SheduleErrors CalculateErrors(int classifierNumber, int compareNumber)
    {
      SheduleErrors errors = new SheduleErrors();
      double falseAlarm = 0.0;
      int i = 1;
      while ((i < countPoint) && (ResultPoint[i].x < Separate))
      {
        falseAlarm += ((ResultPoint[i].x- ResultPoint[i-1].x) * ResultPoint[i].y[classifierNumber]);
        i++;
      }

      errors.falseAlarm = falseAlarm;
      double crossDetection = 0.0;
      while (i<countPoint)
      {
        crossDetection += ((ResultPoint[i].x - ResultPoint[i - 1].x) * ResultPoint[i].y[compareNumber]);
        ++i;
      }
      errors.crossDetection = crossDetection;

      errors.totalError = errors.falseAlarm + errors.crossDetection;
      return errors;
    }

    private void CalculateSeparate()
    {
      double averageValue = 0;
      double countAverage = 0;
      for (int i = 0; i < countClassifier; i++)
      {
        for (int j = i + 1; j < countClassifier; j++)
        {
          //MAX_VALUE
          double minDistance = Math.Abs(ResultPoint[0].y[i] - ResultPoint[0].y[j]);
          int minPointNumber = 0;
          for (int k = 1; k < countPoint; k++)
          {
            var currentDistance = Math.Abs(ResultPoint[k].y[i] - ResultPoint[k].y[j]);
            if (minDistance > currentDistance)
            {
              minDistance = currentDistance;
              minPointNumber = k;
            }
          }
          averageValue += ResultPoint[minPointNumber].x;
          ++countAverage;
        }
      }
      Separate = (averageValue /= (countAverage ==0 ? 1 : countAverage));
    }

    private void CalculateAllClassifier()
    {
      GenerateRandomPoints();

      for (int i = 0; i < countClassifier; i++)
      {
        CalculateSingleClassifier(i);
        for (int j = 0; j < countPoint; j++)
          ResultPoint[j].y[i] *= pc[i];
      }
    }

    private void GenerateRandomPoints()
    {
      for (int i = 0; i < countPoint; i++)
        ResultPoint[i].x = normalDistribution.NextDouble();
      ResultPoint = ResultPoint.OrderBy(x => x.x).ToArray();
    }

    private void CalculateSingleClassifier(int numberClassifier)
    {
      double[] classifierPoints = new double[countPoint];
      classifierPoints = GenerateNormalDistibution();
      double expectedValue = CalculateExpectedValue(classifierPoints);
      double standardDeviation = CalculateStandartDeviation(classifierPoints, expectedValue);

      for (int i = 0; i < countPoint; i++)
      {
        ResultPoint[i].y[numberClassifier] = CalculatePosteriorDensity(ResultPoint[i].x, expectedValue, standardDeviation);
      }
    }

    private double CalculatePosteriorDensity(double point, double expectedValue, double standardDeviation)
    {
      return (Math.Exp(-0.5 * Math.Pow((point- expectedValue) / standardDeviation, 2))) /
              (standardDeviation * Math.Sqrt(2 * Math.PI));
    }

    private double CalculateStandartDeviation(double[] points, double expectedValue)
    {
      double standardDeviation = 0;
      for (int i = 0; i < countPoint; i++)
        standardDeviation += Math.Pow(points[i] - expectedValue, 2);
      standardDeviation = Math.Sqrt(standardDeviation / countPoint);
      return standardDeviation == 0 ? eps : standardDeviation;
    }

    private double CalculateExpectedValue(double[] points)
    {
      double expectedValue = 0;
      for (int i = 0; i < countPoint; i++)
        expectedValue += points[i];
      expectedValue /= countPoint;
      return expectedValue;
    }

    private double[] GenerateNormalDistibution()
    {
      var points = new double[countPoint];
      
      for (int i = 0; i < countPoint; i++)
        points[i] = normalDistribution.NextDouble();
      return points;
    }
  }
}
