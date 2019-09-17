namespace Knowledge.MLNET.Housing
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
            this.BtnResetRestart = new System.Windows.Forms.Button();
            this.PnlLoadTestingDataAndEvaluate = new System.Windows.Forms.Panel();
            this.TxtboxAssessmentResults = new System.Windows.Forms.TextBox();
            this.BtnEvaluateModelUsingTestData = new System.Windows.Forms.Button();
            this.BtnLoadTestingData2TestingData = new System.Windows.Forms.Button();
            this.TxtboxTestingDataPath = new System.Windows.Forms.TextBox();
            this.PnlBuildPipelineAndModel = new System.Windows.Forms.Panel();
            this.TxtboxModelInformation = new System.Windows.Forms.TextBox();
            this.BtnBuildTrainingPipelineEvaluateAndTrainModel = new System.Windows.Forms.Button();
            this.BtnSaveModel = new System.Windows.Forms.Button();
            this.PnlLoadTrainingData = new System.Windows.Forms.Panel();
            this.BtnLoadDataFromFile2TrainingData = new System.Windows.Forms.Button();
            this.TxtboxLoadInformation = new System.Windows.Forms.TextBox();
            this.TxtboxTrainingDataPath = new System.Windows.Forms.TextBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.PnlLoadTestingDataAndEvaluate.SuspendLayout();
            this.PnlBuildPipelineAndModel.SuspendLayout();
            this.PnlLoadTrainingData.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnResetRestart
            // 
            this.BtnResetRestart.Location = new System.Drawing.Point(576, 399);
            this.BtnResetRestart.Name = "BtnResetRestart";
            this.BtnResetRestart.Size = new System.Drawing.Size(152, 33);
            this.BtnResetRestart.TabIndex = 15;
            this.BtnResetRestart.Text = "Reset / Restart";
            this.BtnResetRestart.UseVisualStyleBackColor = true;
            this.BtnResetRestart.Click += new System.EventHandler(this.BtnResetRestart_Click);
            // 
            // PnlLoadTestingDataAndEvaluate
            // 
            this.PnlLoadTestingDataAndEvaluate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PnlLoadTestingDataAndEvaluate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlLoadTestingDataAndEvaluate.Controls.Add(this.TxtboxAssessmentResults);
            this.PnlLoadTestingDataAndEvaluate.Controls.Add(this.BtnEvaluateModelUsingTestData);
            this.PnlLoadTestingDataAndEvaluate.Controls.Add(this.BtnLoadTestingData2TestingData);
            this.PnlLoadTestingDataAndEvaluate.Controls.Add(this.TxtboxTestingDataPath);
            this.PnlLoadTestingDataAndEvaluate.Enabled = false;
            this.PnlLoadTestingDataAndEvaluate.Location = new System.Drawing.Point(12, 331);
            this.PnlLoadTestingDataAndEvaluate.Name = "PnlLoadTestingDataAndEvaluate";
            this.PnlLoadTestingDataAndEvaluate.Size = new System.Drawing.Size(410, 105);
            this.PnlLoadTestingDataAndEvaluate.TabIndex = 11;
            // 
            // TxtboxAssessmentResults
            // 
            this.TxtboxAssessmentResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtboxAssessmentResults.Location = new System.Drawing.Point(12, 80);
            this.TxtboxAssessmentResults.Name = "TxtboxAssessmentResults";
            this.TxtboxAssessmentResults.ReadOnly = true;
            this.TxtboxAssessmentResults.Size = new System.Drawing.Size(391, 20);
            this.TxtboxAssessmentResults.TabIndex = 6;
            this.TxtboxAssessmentResults.Text = "Assessment Results";
            this.TxtboxAssessmentResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnEvaluateModelUsingTestData
            // 
            this.BtnEvaluateModelUsingTestData.Location = new System.Drawing.Point(149, 3);
            this.BtnEvaluateModelUsingTestData.Name = "BtnEvaluateModelUsingTestData";
            this.BtnEvaluateModelUsingTestData.Size = new System.Drawing.Size(102, 50);
            this.BtnEvaluateModelUsingTestData.TabIndex = 8;
            this.BtnEvaluateModelUsingTestData.Text = "Evaluate Model Using Test Data";
            this.BtnEvaluateModelUsingTestData.UseVisualStyleBackColor = true;
            this.BtnEvaluateModelUsingTestData.Click += new System.EventHandler(this.BtnEvaluateModelUsingTestData_Click);
            // 
            // BtnLoadTestingData2TestingData
            // 
            this.BtnLoadTestingData2TestingData.Location = new System.Drawing.Point(4, 3);
            this.BtnLoadTestingData2TestingData.Name = "BtnLoadTestingData2TestingData";
            this.BtnLoadTestingData2TestingData.Size = new System.Drawing.Size(139, 50);
            this.BtnLoadTestingData2TestingData.TabIndex = 5;
            this.BtnLoadTestingData2TestingData.Text = "Load Data from File to Testing Data";
            this.BtnLoadTestingData2TestingData.UseVisualStyleBackColor = true;
            this.BtnLoadTestingData2TestingData.Click += new System.EventHandler(this.BtnLoadTestingData2TestingData_Click);
            // 
            // TxtboxTestingDataPath
            // 
            this.TxtboxTestingDataPath.Location = new System.Drawing.Point(3, 59);
            this.TxtboxTestingDataPath.Name = "TxtboxTestingDataPath";
            this.TxtboxTestingDataPath.Size = new System.Drawing.Size(400, 20);
            this.TxtboxTestingDataPath.TabIndex = 0;
            // 
            // PnlBuildPipelineAndModel
            // 
            this.PnlBuildPipelineAndModel.BackColor = System.Drawing.Color.LightBlue;
            this.PnlBuildPipelineAndModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBuildPipelineAndModel.Controls.Add(this.TxtboxModelInformation);
            this.PnlBuildPipelineAndModel.Controls.Add(this.BtnBuildTrainingPipelineEvaluateAndTrainModel);
            this.PnlBuildPipelineAndModel.Controls.Add(this.BtnSaveModel);
            this.PnlBuildPipelineAndModel.Enabled = false;
            this.PnlBuildPipelineAndModel.Location = new System.Drawing.Point(12, 190);
            this.PnlBuildPipelineAndModel.Name = "PnlBuildPipelineAndModel";
            this.PnlBuildPipelineAndModel.Size = new System.Drawing.Size(410, 135);
            this.PnlBuildPipelineAndModel.TabIndex = 13;
            // 
            // TxtboxModelInformation
            // 
            this.TxtboxModelInformation.Location = new System.Drawing.Point(3, 56);
            this.TxtboxModelInformation.Multiline = true;
            this.TxtboxModelInformation.Name = "TxtboxModelInformation";
            this.TxtboxModelInformation.ReadOnly = true;
            this.TxtboxModelInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtboxModelInformation.Size = new System.Drawing.Size(400, 76);
            this.TxtboxModelInformation.TabIndex = 4;
            // 
            // BtnBuildTrainingPipelineEvaluateAndTrainModel
            // 
            this.BtnBuildTrainingPipelineEvaluateAndTrainModel.Location = new System.Drawing.Point(3, 3);
            this.BtnBuildTrainingPipelineEvaluateAndTrainModel.Name = "BtnBuildTrainingPipelineEvaluateAndTrainModel";
            this.BtnBuildTrainingPipelineEvaluateAndTrainModel.Size = new System.Drawing.Size(175, 50);
            this.BtnBuildTrainingPipelineEvaluateAndTrainModel.TabIndex = 1;
            this.BtnBuildTrainingPipelineEvaluateAndTrainModel.Text = "Build Training Pipeline, Evaluate and Train Model";
            this.BtnBuildTrainingPipelineEvaluateAndTrainModel.UseVisualStyleBackColor = true;
            this.BtnBuildTrainingPipelineEvaluateAndTrainModel.Click += new System.EventHandler(this.BtnBuildTrainingPipelineEvaluateAndTrainModel_Click);
            // 
            // BtnSaveModel
            // 
            this.BtnSaveModel.Location = new System.Drawing.Point(353, 3);
            this.BtnSaveModel.Name = "BtnSaveModel";
            this.BtnSaveModel.Size = new System.Drawing.Size(50, 50);
            this.BtnSaveModel.TabIndex = 2;
            this.BtnSaveModel.Text = "Save Model";
            this.BtnSaveModel.UseVisualStyleBackColor = true;
            this.BtnSaveModel.Click += new System.EventHandler(this.BtnSaveModel_Click);
            // 
            // PnlLoadTrainingData
            // 
            this.PnlLoadTrainingData.BackColor = System.Drawing.Color.LightBlue;
            this.PnlLoadTrainingData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlLoadTrainingData.Controls.Add(this.BtnLoadDataFromFile2TrainingData);
            this.PnlLoadTrainingData.Controls.Add(this.TxtboxLoadInformation);
            this.PnlLoadTrainingData.Controls.Add(this.TxtboxTrainingDataPath);
            this.PnlLoadTrainingData.Location = new System.Drawing.Point(12, 12);
            this.PnlLoadTrainingData.Name = "PnlLoadTrainingData";
            this.PnlLoadTrainingData.Size = new System.Drawing.Size(410, 172);
            this.PnlLoadTrainingData.TabIndex = 12;
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
            this.TxtboxLoadInformation.Location = new System.Drawing.Point(3, 85);
            this.TxtboxLoadInformation.Multiline = true;
            this.TxtboxLoadInformation.Name = "TxtboxLoadInformation";
            this.TxtboxLoadInformation.ReadOnly = true;
            this.TxtboxLoadInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtboxLoadInformation.Size = new System.Drawing.Size(400, 76);
            this.TxtboxLoadInformation.TabIndex = 3;
            // 
            // TxtboxTrainingDataPath
            // 
            this.TxtboxTrainingDataPath.Location = new System.Drawing.Point(3, 59);
            this.TxtboxTrainingDataPath.Name = "TxtboxTrainingDataPath";
            this.TxtboxTrainingDataPath.Size = new System.Drawing.Size(400, 20);
            this.TxtboxTrainingDataPath.TabIndex = 1;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zedGraphControl1.Location = new System.Drawing.Point(428, 12);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(300, 300);
            this.zedGraphControl1.TabIndex = 16;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            this.zedGraphControl1.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 443);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.BtnResetRestart);
            this.Controls.Add(this.PnlLoadTestingDataAndEvaluate);
            this.Controls.Add(this.PnlBuildPipelineAndModel);
            this.Controls.Add(this.PnlLoadTrainingData);
            this.Name = "MainForm";
            this.Text = "ML.NET Demonstrator by Mark Reynolds - Housing";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.PnlLoadTestingDataAndEvaluate.ResumeLayout(false);
            this.PnlLoadTestingDataAndEvaluate.PerformLayout();
            this.PnlBuildPipelineAndModel.ResumeLayout(false);
            this.PnlBuildPipelineAndModel.PerformLayout();
            this.PnlLoadTrainingData.ResumeLayout(false);
            this.PnlLoadTrainingData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnResetRestart;
        private System.Windows.Forms.Panel PnlLoadTestingDataAndEvaluate;
        private System.Windows.Forms.TextBox TxtboxAssessmentResults;
        private System.Windows.Forms.Button BtnEvaluateModelUsingTestData;
        private System.Windows.Forms.Button BtnLoadTestingData2TestingData;
        private System.Windows.Forms.TextBox TxtboxTestingDataPath;
        private System.Windows.Forms.Panel PnlBuildPipelineAndModel;
        private System.Windows.Forms.TextBox TxtboxModelInformation;
        private System.Windows.Forms.Button BtnBuildTrainingPipelineEvaluateAndTrainModel;
        private System.Windows.Forms.Button BtnSaveModel;
        private System.Windows.Forms.Panel PnlLoadTrainingData;
        private System.Windows.Forms.Button BtnLoadDataFromFile2TrainingData;
        private System.Windows.Forms.TextBox TxtboxLoadInformation;
        private System.Windows.Forms.TextBox TxtboxTrainingDataPath;
        private ZedGraph.ZedGraphControl zedGraphControl1;
    }
}

