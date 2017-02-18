namespace Probabilistic_approach
{
  partial class ProbabilisticApproach
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.lTotalError = new System.Windows.Forms.Label();
      this.tBTotalError = new System.Windows.Forms.TextBox();
      this.lCrossDetection = new System.Windows.Forms.Label();
      this.tBCrossDetection = new System.Windows.Forms.TextBox();
      this.lFalseAlarm = new System.Windows.Forms.Label();
      this.tBFalseAlarm = new System.Windows.Forms.TextBox();
      this.pictureBox = new System.Windows.Forms.PictureBox();
      this.pc2UpDown = new System.Windows.Forms.NumericUpDown();
      this.lPropabilityC2 = new System.Windows.Forms.Label();
      this.pc1UpDown = new System.Windows.Forms.NumericUpDown();
      this.lPropabilityC1 = new System.Windows.Forms.Label();
      this.ButtonBuildSchedule = new System.Windows.Forms.Button();
      this.countPointUpDown = new System.Windows.Forms.NumericUpDown();
      this.lCountPoints = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pc2UpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pc1UpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.countPointUpDown)).BeginInit();
      this.SuspendLayout();
      // 
      // lTotalError
      // 
      this.lTotalError.AutoSize = true;
      this.lTotalError.Location = new System.Drawing.Point(13, 432);
      this.lTotalError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lTotalError.Name = "lTotalError";
      this.lTotalError.Size = new System.Drawing.Size(183, 17);
      this.lTotalError.TabIndex = 14;
      this.lTotalError.Text = "The total classification error";
      // 
      // tBTotalError
      // 
      this.tBTotalError.BackColor = System.Drawing.SystemColors.Info;
      this.tBTotalError.Location = new System.Drawing.Point(16, 453);
      this.tBTotalError.Margin = new System.Windows.Forms.Padding(4);
      this.tBTotalError.Name = "tBTotalError";
      this.tBTotalError.ReadOnly = true;
      this.tBTotalError.Size = new System.Drawing.Size(240, 22);
      this.tBTotalError.TabIndex = 13;
      // 
      // lCrossDetection
      // 
      this.lCrossDetection.AutoSize = true;
      this.lCrossDetection.Location = new System.Drawing.Point(13, 373);
      this.lCrossDetection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lCrossDetection.Name = "lCrossDetection";
      this.lCrossDetection.Size = new System.Drawing.Size(237, 17);
      this.lCrossDetection.TabIndex = 12;
      this.lCrossDetection.Text = "The probability of crossing detection";
      // 
      // tBCrossDetection
      // 
      this.tBCrossDetection.BackColor = System.Drawing.SystemColors.Info;
      this.tBCrossDetection.Location = new System.Drawing.Point(16, 394);
      this.tBCrossDetection.Margin = new System.Windows.Forms.Padding(4);
      this.tBCrossDetection.Name = "tBCrossDetection";
      this.tBCrossDetection.ReadOnly = true;
      this.tBCrossDetection.Size = new System.Drawing.Size(240, 22);
      this.tBCrossDetection.TabIndex = 11;
      // 
      // lFalseAlarm
      // 
      this.lFalseAlarm.AutoSize = true;
      this.lFalseAlarm.Location = new System.Drawing.Point(13, 312);
      this.lFalseAlarm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lFalseAlarm.Name = "lFalseAlarm";
      this.lFalseAlarm.Size = new System.Drawing.Size(150, 17);
      this.lFalseAlarm.TabIndex = 10;
      this.lFalseAlarm.Text = "False alarm probability";
      // 
      // tBFalseAlarm
      // 
      this.tBFalseAlarm.BackColor = System.Drawing.SystemColors.Info;
      this.tBFalseAlarm.Location = new System.Drawing.Point(16, 333);
      this.tBFalseAlarm.Margin = new System.Windows.Forms.Padding(4);
      this.tBFalseAlarm.Name = "tBFalseAlarm";
      this.tBFalseAlarm.ReadOnly = true;
      this.tBFalseAlarm.Size = new System.Drawing.Size(240, 22);
      this.tBFalseAlarm.TabIndex = 9;
      // 
      // pictureBox
      // 
      this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
      this.pictureBox.Location = new System.Drawing.Point(273, 21);
      this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
      this.pictureBox.Name = "pictureBox";
      this.pictureBox.Size = new System.Drawing.Size(1107, 454);
      this.pictureBox.TabIndex = 8;
      this.pictureBox.TabStop = false;
      // 
      // pc2UpDown
      // 
      this.pc2UpDown.DecimalPlaces = 2;
      this.pc2UpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
      this.pc2UpDown.Location = new System.Drawing.Point(154, 59);
      this.pc2UpDown.Margin = new System.Windows.Forms.Padding(4);
      this.pc2UpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.pc2UpDown.Name = "pc2UpDown";
      this.pc2UpDown.Size = new System.Drawing.Size(111, 22);
      this.pc2UpDown.TabIndex = 19;
      this.pc2UpDown.ValueChanged += new System.EventHandler(this.pc2UpDown_ValueChanged);
      // 
      // lPropabilityC2
      // 
      this.lPropabilityC2.AutoSize = true;
      this.lPropabilityC2.Location = new System.Drawing.Point(13, 61);
      this.lPropabilityC2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lPropabilityC2.Name = "lPropabilityC2";
      this.lPropabilityC2.Size = new System.Drawing.Size(113, 17);
      this.lPropabilityC2.TabIndex = 18;
      this.lPropabilityC2.Text = "Propability p(C2)";
      // 
      // pc1UpDown
      // 
      this.pc1UpDown.DecimalPlaces = 2;
      this.pc1UpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
      this.pc1UpDown.Location = new System.Drawing.Point(154, 21);
      this.pc1UpDown.Margin = new System.Windows.Forms.Padding(4);
      this.pc1UpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.pc1UpDown.Name = "pc1UpDown";
      this.pc1UpDown.Size = new System.Drawing.Size(111, 22);
      this.pc1UpDown.TabIndex = 17;
      this.pc1UpDown.ValueChanged += new System.EventHandler(this.pc1UpDown_ValueChanged);
      // 
      // lPropabilityC1
      // 
      this.lPropabilityC1.AutoSize = true;
      this.lPropabilityC1.Location = new System.Drawing.Point(13, 23);
      this.lPropabilityC1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lPropabilityC1.Name = "lPropabilityC1";
      this.lPropabilityC1.Size = new System.Drawing.Size(113, 17);
      this.lPropabilityC1.TabIndex = 16;
      this.lPropabilityC1.Text = "Propability p(C1)";
      // 
      // ButtonBuildSchedule
      // 
      this.ButtonBuildSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.ButtonBuildSchedule.Location = new System.Drawing.Point(13, 133);
      this.ButtonBuildSchedule.Margin = new System.Windows.Forms.Padding(4);
      this.ButtonBuildSchedule.Name = "ButtonBuildSchedule";
      this.ButtonBuildSchedule.Size = new System.Drawing.Size(252, 28);
      this.ButtonBuildSchedule.TabIndex = 15;
      this.ButtonBuildSchedule.Text = "Build schedule";
      this.ButtonBuildSchedule.UseVisualStyleBackColor = true;
      this.ButtonBuildSchedule.Click += new System.EventHandler(this.ButtonBuildSchedule_Click);
      // 
      // countPointUpDown
      // 
      this.countPointUpDown.Location = new System.Drawing.Point(154, 93);
      this.countPointUpDown.Margin = new System.Windows.Forms.Padding(4);
      this.countPointUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.countPointUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.countPointUpDown.Name = "countPointUpDown";
      this.countPointUpDown.Size = new System.Drawing.Size(111, 22);
      this.countPointUpDown.TabIndex = 21;
      this.countPointUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // lCountPoints
      // 
      this.lCountPoints.AutoSize = true;
      this.lCountPoints.Location = new System.Drawing.Point(13, 95);
      this.lCountPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lCountPoints.Name = "lCountPoints";
      this.lCountPoints.Size = new System.Drawing.Size(127, 17);
      this.lCountPoints.TabIndex = 20;
      this.lCountPoints.Text = "Count of points (N)";
      // 
      // ProbabilisticApproach
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1393, 499);
      this.Controls.Add(this.countPointUpDown);
      this.Controls.Add(this.lCountPoints);
      this.Controls.Add(this.pc2UpDown);
      this.Controls.Add(this.lPropabilityC2);
      this.Controls.Add(this.pc1UpDown);
      this.Controls.Add(this.lPropabilityC1);
      this.Controls.Add(this.ButtonBuildSchedule);
      this.Controls.Add(this.lTotalError);
      this.Controls.Add(this.tBTotalError);
      this.Controls.Add(this.lCrossDetection);
      this.Controls.Add(this.tBCrossDetection);
      this.Controls.Add(this.lFalseAlarm);
      this.Controls.Add(this.tBFalseAlarm);
      this.Controls.Add(this.pictureBox);
      this.Name = "ProbabilisticApproach";
      this.Text = "Probabilistic Approach";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pc2UpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pc1UpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.countPointUpDown)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lTotalError;
    private System.Windows.Forms.TextBox tBTotalError;
    private System.Windows.Forms.Label lCrossDetection;
    private System.Windows.Forms.TextBox tBCrossDetection;
    private System.Windows.Forms.Label lFalseAlarm;
    private System.Windows.Forms.TextBox tBFalseAlarm;
    private System.Windows.Forms.PictureBox pictureBox;
    private System.Windows.Forms.NumericUpDown pc2UpDown;
    private System.Windows.Forms.Label lPropabilityC2;
    private System.Windows.Forms.NumericUpDown pc1UpDown;
    private System.Windows.Forms.Label lPropabilityC1;
    private System.Windows.Forms.Button ButtonBuildSchedule;
    private System.Windows.Forms.NumericUpDown countPointUpDown;
    private System.Windows.Forms.Label lCountPoints;
  }
}

