using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Probabilistic_approach
{
  public partial class ProbabilisticApproach : Form
  {
    public ProbabilisticApproach()
    {
      InitializeComponent();
      initUpDowns();
    }

    private void initUpDowns()
    {
      pc2UpDown.Value = pc1UpDown.Value = ProbabilityMax / 2;
    }

    const decimal ProbabilityMax = 1;
    const int seePoint = 0;
    const int comparePoint = 1;
    const int countClassifier = 2;
    Pen[] pens = new Pen[countClassifier] { Pens.Blue, Pens.Red };

    private void pc1UpDown_ValueChanged(object sender, EventArgs e)
    {
      pc2UpDown.Value = 1 - pc1UpDown.Value;
    }

    private void pc2UpDown_ValueChanged(object sender, EventArgs e)
    {
      pc1UpDown.Value = 1 - pc2UpDown.Value;
    }

    private void ButtonBuildSchedule_Click(object sender, EventArgs e)
    {
      var bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
      using (Graphics graphics = Graphics.FromImage(bitmap))
      {
        CalculateShedule(graphics);
        pictureBox.Image = bitmap;
      }
    }

    private void CalculateShedule(Graphics graphics)
    {
      int countPoint = (int)countPointUpDown.Value;
      var shedule = new Probabilistic_approach.ProbabilityShedule(countPoint, new double[] { (double)pc1UpDown.Value, (double)pc2UpDown.Value });
      shedule.CalculateShedule();
      var errors = shedule.CalculateErrors(seePoint, comparePoint);
      tBFalseAlarm.Text = errors.falseAlarm.ToString();
      tBCrossDetection.Text = errors.crossDetection.ToString();
      tBTotalError.Text = errors.totalError.ToString();

      using (var textBrush = new SolidBrush(Color.Black))
      {
        for (int i = 1; i < countPoint; i++)
        {
          for (int j = 0; j < countClassifier; j++)
            graphics.DrawLine(pens[j],
              new PointF((float)(shedule.ResultPoint[i].x * pictureBox.Width), (float)(shedule.ResultPoint[i].y[j] * pictureBox.Height)),
              new PointF((float)(shedule.ResultPoint[i-1].x * pictureBox.Width), (float)(shedule.ResultPoint[i-1].y[j] * pictureBox.Height)));
        }

        graphics.DrawLine(Pens.Chartreuse, (float)(shedule.Separate * pictureBox.Width), 0, (float)(shedule.Separate * pictureBox.Width), pictureBox.Height);
        graphics.DrawLine(Pens.Black, 0, pictureBox.Height - 1,
            pictureBox.Width, pictureBox.Height - 1);
        graphics.DrawLine(Pens.Black, pictureBox.Width,
            pictureBox.Height - 1, pictureBox.Width - 15,
            pictureBox.Height - 5);
        graphics.DrawLine(Pens.Black, 100, pictureBox.Height - 1, 100, 0);
        graphics.DrawLine(Pens.Black, 100, 0, 95, 15);
        graphics.DrawLine(Pens.Black, 100, 0, 105, 15);
        graphics.DrawString("X", this.Font, Brushes.Black,
            pictureBox.Width - 10, pictureBox.Height - 20);
        graphics.DrawLine(pens[0], pictureBox.Width - 150, 15,
            pictureBox.Width - 100, 15);
        graphics.DrawString("p(X / C1) P(C1)", this.Font, textBrush,
            pictureBox.Width - 90, 5);

        graphics.DrawLine(pens[1], pictureBox.Width - 150, 30,
            pictureBox.Width - 100, 30);
        graphics.DrawString("p(X / C2) P(C2)", this.Font, textBrush,
            pictureBox.Width - 90, 25);
      }
    }
  }
}
