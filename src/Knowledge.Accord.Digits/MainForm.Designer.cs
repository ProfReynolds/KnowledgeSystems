namespace Knowledge.Accord.Digits
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.LblRandomDigit = new System.Windows.Forms.Label();
            this.BtnDisplayRandomDigit = new System.Windows.Forms.Button();
            this.BtnLoadDataFromFile2TrainingData = new System.Windows.Forms.Button();
            this.TxtboxLoadInformation = new System.Windows.Forms.TextBox();
            this.ChkboxUseLargeTrainingDataSet = new System.Windows.Forms.CheckBox();
            this.PnlLoadTrainingData = new System.Windows.Forms.Panel();
            this.TxtboxTrainingDataPath = new System.Windows.Forms.TextBox();
            this.TxtboxAssessmentResults = new System.Windows.Forms.TextBox();
            this.TxtboxTestingDataPath = new System.Windows.Forms.TextBox();
            this.PnlLoadTestingDataAndEvaluate = new System.Windows.Forms.Panel();
            this.ChkboxUseLargeTestingDataSet = new System.Windows.Forms.CheckBox();
            this.BtnSvmGaussian = new System.Windows.Forms.Button();
            this.BtnSvmLinear = new System.Windows.Forms.Button();
            this.BtnResetRestart = new System.Windows.Forms.Button();
            this.PnlLoadTrainingData.SuspendLayout();
            this.PnlLoadTestingDataAndEvaluate.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zedGraphControl1.Location = new System.Drawing.Point(428, 10);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(300, 300);
            this.zedGraphControl1.TabIndex = 21;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            this.zedGraphControl1.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // LblRandomDigit
            // 
            this.LblRandomDigit.AutoSize = true;
            this.LblRandomDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRandomDigit.Location = new System.Drawing.Point(225, 3);
            this.LblRandomDigit.Name = "LblRandomDigit";
            this.LblRandomDigit.Size = new System.Drawing.Size(46, 51);
            this.LblRandomDigit.TabIndex = 6;
            this.LblRandomDigit.Text = "?";
            // 
            // BtnDisplayRandomDigit
            // 
            this.BtnDisplayRandomDigit.Location = new System.Drawing.Point(125, 3);
            this.BtnDisplayRandomDigit.Name = "BtnDisplayRandomDigit";
            this.BtnDisplayRandomDigit.Size = new System.Drawing.Size(94, 50);
            this.BtnDisplayRandomDigit.TabIndex = 5;
            this.BtnDisplayRandomDigit.Text = "Display Random Digit";
            this.BtnDisplayRandomDigit.UseVisualStyleBackColor = true;
            this.BtnDisplayRandomDigit.Click += new System.EventHandler(this.BtnDisplayRandomDigit_Click);
            // 
            // BtnLoadDataFromFile2TrainingData
            // 
            this.BtnLoadDataFromFile2TrainingData.Location = new System.Drawing.Point(4, 3);
            this.BtnLoadDataFromFile2TrainingData.Name = "BtnLoadDataFromFile2TrainingData";
            this.BtnLoadDataFromFile2TrainingData.Size = new System.Drawing.Size(115, 50);
            this.BtnLoadDataFromFile2TrainingData.TabIndex = 4;
            this.BtnLoadDataFromFile2TrainingData.Text = "Load Data from File to Training Data";
            this.BtnLoadDataFromFile2TrainingData.UseVisualStyleBackColor = true;
            this.BtnLoadDataFromFile2TrainingData.Click += new System.EventHandler(this.BtnLoadDataFromFile2TrainingData_Click);
            // 
            // TxtboxLoadInformation
            // 
            this.TxtboxLoadInformation.Location = new System.Drawing.Point(3, 108);
            this.TxtboxLoadInformation.Multiline = true;
            this.TxtboxLoadInformation.Name = "TxtboxLoadInformation";
            this.TxtboxLoadInformation.ReadOnly = true;
            this.TxtboxLoadInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtboxLoadInformation.Size = new System.Drawing.Size(400, 76);
            this.TxtboxLoadInformation.TabIndex = 3;
            // 
            // ChkboxUseLargeTrainingDataSet
            // 
            this.ChkboxUseLargeTrainingDataSet.AutoSize = true;
            this.ChkboxUseLargeTrainingDataSet.Location = new System.Drawing.Point(3, 59);
            this.ChkboxUseLargeTrainingDataSet.Name = "ChkboxUseLargeTrainingDataSet";
            this.ChkboxUseLargeTrainingDataSet.Size = new System.Drawing.Size(161, 17);
            this.ChkboxUseLargeTrainingDataSet.TabIndex = 2;
            this.ChkboxUseLargeTrainingDataSet.Text = "Use Large Training Data Set";
            this.ChkboxUseLargeTrainingDataSet.UseVisualStyleBackColor = true;
            this.ChkboxUseLargeTrainingDataSet.CheckedChanged += new System.EventHandler(this.ChkboxUseLargeTrainingDataSet_CheckedChanged);
            // 
            // PnlLoadTrainingData
            // 
            this.PnlLoadTrainingData.BackColor = System.Drawing.Color.LightBlue;
            this.PnlLoadTrainingData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlLoadTrainingData.Controls.Add(this.LblRandomDigit);
            this.PnlLoadTrainingData.Controls.Add(this.BtnDisplayRandomDigit);
            this.PnlLoadTrainingData.Controls.Add(this.BtnLoadDataFromFile2TrainingData);
            this.PnlLoadTrainingData.Controls.Add(this.TxtboxLoadInformation);
            this.PnlLoadTrainingData.Controls.Add(this.ChkboxUseLargeTrainingDataSet);
            this.PnlLoadTrainingData.Controls.Add(this.TxtboxTrainingDataPath);
            this.PnlLoadTrainingData.Location = new System.Drawing.Point(12, 10);
            this.PnlLoadTrainingData.Name = "PnlLoadTrainingData";
            this.PnlLoadTrainingData.Size = new System.Drawing.Size(410, 194);
            this.PnlLoadTrainingData.TabIndex = 18;
            // 
            // TxtboxTrainingDataPath
            // 
            this.TxtboxTrainingDataPath.Location = new System.Drawing.Point(3, 82);
            this.TxtboxTrainingDataPath.Name = "TxtboxTrainingDataPath";
            this.TxtboxTrainingDataPath.Size = new System.Drawing.Size(400, 20);
            this.TxtboxTrainingDataPath.TabIndex = 1;
            // 
            // TxtboxAssessmentResults
            // 
            this.TxtboxAssessmentResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtboxAssessmentResults.Location = new System.Drawing.Point(12, 106);
            this.TxtboxAssessmentResults.Name = "TxtboxAssessmentResults";
            this.TxtboxAssessmentResults.ReadOnly = true;
            this.TxtboxAssessmentResults.Size = new System.Drawing.Size(391, 20);
            this.TxtboxAssessmentResults.TabIndex = 6;
            this.TxtboxAssessmentResults.Text = "Assessment Results";
            this.TxtboxAssessmentResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtboxTestingDataPath
            // 
            this.TxtboxTestingDataPath.Location = new System.Drawing.Point(3, 82);
            this.TxtboxTestingDataPath.Name = "TxtboxTestingDataPath";
            this.TxtboxTestingDataPath.Size = new System.Drawing.Size(400, 20);
            this.TxtboxTestingDataPath.TabIndex = 0;
            // 
            // PnlLoadTestingDataAndEvaluate
            // 
            this.PnlLoadTestingDataAndEvaluate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PnlLoadTestingDataAndEvaluate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlLoadTestingDataAndEvaluate.Controls.Add(this.ChkboxUseLargeTestingDataSet);
            this.PnlLoadTestingDataAndEvaluate.Controls.Add(this.BtnSvmGaussian);
            this.PnlLoadTestingDataAndEvaluate.Controls.Add(this.BtnSvmLinear);
            this.PnlLoadTestingDataAndEvaluate.Controls.Add(this.TxtboxAssessmentResults);
            this.PnlLoadTestingDataAndEvaluate.Controls.Add(this.TxtboxTestingDataPath);
            this.PnlLoadTestingDataAndEvaluate.Enabled = false;
            this.PnlLoadTestingDataAndEvaluate.Location = new System.Drawing.Point(12, 210);
            this.PnlLoadTestingDataAndEvaluate.Name = "PnlLoadTestingDataAndEvaluate";
            this.PnlLoadTestingDataAndEvaluate.Size = new System.Drawing.Size(410, 131);
            this.PnlLoadTestingDataAndEvaluate.TabIndex = 17;
            // 
            // ChkboxUseLargeTestingDataSet
            // 
            this.ChkboxUseLargeTestingDataSet.AutoSize = true;
            this.ChkboxUseLargeTestingDataSet.Location = new System.Drawing.Point(3, 59);
            this.ChkboxUseLargeTestingDataSet.Name = "ChkboxUseLargeTestingDataSet";
            this.ChkboxUseLargeTestingDataSet.Size = new System.Drawing.Size(158, 17);
            this.ChkboxUseLargeTestingDataSet.TabIndex = 11;
            this.ChkboxUseLargeTestingDataSet.Text = "Use Large Testing Data Set";
            this.ChkboxUseLargeTestingDataSet.UseVisualStyleBackColor = true;
            this.ChkboxUseLargeTestingDataSet.CheckedChanged += new System.EventHandler(this.ChkboxUseLargeTestingDataSet_CheckedChanged);
            // 
            // BtnSvmGaussian
            // 
            this.BtnSvmGaussian.Location = new System.Drawing.Point(109, 3);
            this.BtnSvmGaussian.Name = "BtnSvmGaussian";
            this.BtnSvmGaussian.Size = new System.Drawing.Size(100, 50);
            this.BtnSvmGaussian.TabIndex = 9;
            this.BtnSvmGaussian.Text = "SVM: Gaussian";
            this.BtnSvmGaussian.UseVisualStyleBackColor = true;
            this.BtnSvmGaussian.Click += new System.EventHandler(this.BtnSvmGaussian_Click);
            // 
            // BtnSvmLinear
            // 
            this.BtnSvmLinear.Location = new System.Drawing.Point(3, 3);
            this.BtnSvmLinear.Name = "BtnSvmLinear";
            this.BtnSvmLinear.Size = new System.Drawing.Size(100, 50);
            this.BtnSvmLinear.TabIndex = 8;
            this.BtnSvmLinear.Text = "SVM: Linear";
            this.BtnSvmLinear.UseVisualStyleBackColor = true;
            this.BtnSvmLinear.Click += new System.EventHandler(this.BtnSvmLinear_Click);
            // 
            // BtnResetRestart
            // 
            this.BtnResetRestart.Location = new System.Drawing.Point(576, 419);
            this.BtnResetRestart.Name = "BtnResetRestart";
            this.BtnResetRestart.Size = new System.Drawing.Size(152, 33);
            this.BtnResetRestart.TabIndex = 20;
            this.BtnResetRestart.Text = "Reset / Restart";
            this.BtnResetRestart.UseVisualStyleBackColor = true;
            this.BtnResetRestart.Click += new System.EventHandler(this.BtnResetRestart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 466);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.PnlLoadTrainingData);
            this.Controls.Add(this.PnlLoadTestingDataAndEvaluate);
            this.Controls.Add(this.BtnResetRestart);
            this.Name = "MainForm";
            this.Text = "Accord Demonstrator by Mark Reynolds - Digits";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PnlLoadTrainingData.ResumeLayout(false);
            this.PnlLoadTrainingData.PerformLayout();
            this.PnlLoadTestingDataAndEvaluate.ResumeLayout(false);
            this.PnlLoadTestingDataAndEvaluate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label LblRandomDigit;
        private System.Windows.Forms.Button BtnDisplayRandomDigit;
        private System.Windows.Forms.Button BtnLoadDataFromFile2TrainingData;
        private System.Windows.Forms.TextBox TxtboxLoadInformation;
        private System.Windows.Forms.CheckBox ChkboxUseLargeTrainingDataSet;
        private System.Windows.Forms.Panel PnlLoadTrainingData;
        private System.Windows.Forms.TextBox TxtboxTrainingDataPath;
        private System.Windows.Forms.TextBox TxtboxAssessmentResults;
        private System.Windows.Forms.TextBox TxtboxTestingDataPath;
        private System.Windows.Forms.Panel PnlLoadTestingDataAndEvaluate;
        private System.Windows.Forms.Button BtnResetRestart;
        private System.Windows.Forms.Button BtnSvmLinear;
        private System.Windows.Forms.Button BtnSvmGaussian;
        private System.Windows.Forms.CheckBox ChkboxUseLargeTestingDataSet;
    }
}

