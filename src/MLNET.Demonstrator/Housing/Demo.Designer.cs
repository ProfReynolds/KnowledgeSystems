namespace Knowledge.MLNET.Demonstrator.Housing
{
    partial class Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Demo));
            this.PnlLoadTestingDataAndEvaluate = new System.Windows.Forms.Panel();
            this.TxtboxAssessmentResults = new System.Windows.Forms.TextBox();
            this.BtnEvaluateModelUsingTestData = new System.Windows.Forms.Button();
            this.PnlBuildPipelineAndModel = new System.Windows.Forms.Panel();
            this.BtnBuildAndTrainModel = new System.Windows.Forms.Button();
            this.BtnSaveModel = new System.Windows.Forms.Button();
            this.TxtboxModelSaveDataPath = new System.Windows.Forms.TextBox();
            this.BtnResetRestart = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.PnlLoadData = new System.Windows.Forms.Panel();
            this.BtnLoadDatasets = new System.Windows.Forms.Button();
            this.TxtboxTestingDataPath = new System.Windows.Forms.TextBox();
            this.TxtboxTrainingDataPath = new System.Windows.Forms.TextBox();
            this.BtnEvaluateModelUsingTrainingData = new System.Windows.Forms.Button();
            this.PnlLoadTestingDataAndEvaluate.SuspendLayout();
            this.PnlBuildPipelineAndModel.SuspendLayout();
            this.PnlLoadData.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlLoadTestingDataAndEvaluate
            // 
            this.PnlLoadTestingDataAndEvaluate.BackColor = System.Drawing.Color.LightBlue;
            this.PnlLoadTestingDataAndEvaluate.Controls.Add(this.BtnEvaluateModelUsingTrainingData);
            this.PnlLoadTestingDataAndEvaluate.Controls.Add(this.TxtboxAssessmentResults);
            this.PnlLoadTestingDataAndEvaluate.Controls.Add(this.BtnEvaluateModelUsingTestData);
            this.PnlLoadTestingDataAndEvaluate.Location = new System.Drawing.Point(3, 232);
            this.PnlLoadTestingDataAndEvaluate.Name = "PnlLoadTestingDataAndEvaluate";
            this.PnlLoadTestingDataAndEvaluate.Size = new System.Drawing.Size(420, 97);
            this.PnlLoadTestingDataAndEvaluate.TabIndex = 27;
            // 
            // TxtboxAssessmentResults
            // 
            this.TxtboxAssessmentResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtboxAssessmentResults.Location = new System.Drawing.Point(9, 65);
            this.TxtboxAssessmentResults.Name = "TxtboxAssessmentResults";
            this.TxtboxAssessmentResults.ReadOnly = true;
            this.TxtboxAssessmentResults.Size = new System.Drawing.Size(400, 20);
            this.TxtboxAssessmentResults.TabIndex = 10;
            this.TxtboxAssessmentResults.Text = "Assessment Results";
            this.TxtboxAssessmentResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnEvaluateModelUsingTestData
            // 
            this.BtnEvaluateModelUsingTestData.Location = new System.Drawing.Point(9, 9);
            this.BtnEvaluateModelUsingTestData.Name = "BtnEvaluateModelUsingTestData";
            this.BtnEvaluateModelUsingTestData.Size = new System.Drawing.Size(112, 50);
            this.BtnEvaluateModelUsingTestData.TabIndex = 9;
            this.BtnEvaluateModelUsingTestData.Text = "Evaluate Model Using Test Data";
            this.BtnEvaluateModelUsingTestData.UseVisualStyleBackColor = true;
            this.BtnEvaluateModelUsingTestData.Click += new System.EventHandler(this.BtnEvaluateModelUsingTestData_Click);
            // 
            // PnlBuildPipelineAndModel
            // 
            this.PnlBuildPipelineAndModel.BackColor = System.Drawing.Color.LightBlue;
            this.PnlBuildPipelineAndModel.Controls.Add(this.BtnBuildAndTrainModel);
            this.PnlBuildPipelineAndModel.Controls.Add(this.BtnSaveModel);
            this.PnlBuildPipelineAndModel.Controls.Add(this.TxtboxModelSaveDataPath);
            this.PnlBuildPipelineAndModel.Location = new System.Drawing.Point(3, 129);
            this.PnlBuildPipelineAndModel.Name = "PnlBuildPipelineAndModel";
            this.PnlBuildPipelineAndModel.Size = new System.Drawing.Size(420, 97);
            this.PnlBuildPipelineAndModel.TabIndex = 26;
            // 
            // BtnBuildAndTrainModel
            // 
            this.BtnBuildAndTrainModel.Location = new System.Drawing.Point(9, 9);
            this.BtnBuildAndTrainModel.Name = "BtnBuildAndTrainModel";
            this.BtnBuildAndTrainModel.Size = new System.Drawing.Size(175, 50);
            this.BtnBuildAndTrainModel.TabIndex = 5;
            this.BtnBuildAndTrainModel.Text = "Build Training Pipeline, Evaluate and Train Model";
            this.BtnBuildAndTrainModel.UseVisualStyleBackColor = true;
            this.BtnBuildAndTrainModel.Click += new System.EventHandler(this.BtnBuildAndTrainModel_Click);
            // 
            // BtnSaveModel
            // 
            this.BtnSaveModel.Location = new System.Drawing.Point(359, 9);
            this.BtnSaveModel.Name = "BtnSaveModel";
            this.BtnSaveModel.Size = new System.Drawing.Size(50, 50);
            this.BtnSaveModel.TabIndex = 6;
            this.BtnSaveModel.Text = "Save Model";
            this.BtnSaveModel.UseVisualStyleBackColor = true;
            this.BtnSaveModel.Click += new System.EventHandler(this.BtnSaveModel_Click);
            // 
            // TxtboxModelSaveDataPath
            // 
            this.TxtboxModelSaveDataPath.Location = new System.Drawing.Point(9, 65);
            this.TxtboxModelSaveDataPath.Name = "TxtboxModelSaveDataPath";
            this.TxtboxModelSaveDataPath.Size = new System.Drawing.Size(400, 20);
            this.TxtboxModelSaveDataPath.TabIndex = 4;
            // 
            // BtnResetRestart
            // 
            this.BtnResetRestart.Location = new System.Drawing.Point(271, 335);
            this.BtnResetRestart.Name = "BtnResetRestart";
            this.BtnResetRestart.Size = new System.Drawing.Size(152, 33);
            this.BtnResetRestart.TabIndex = 25;
            this.BtnResetRestart.Text = "Reset / Restart";
            this.BtnResetRestart.UseVisualStyleBackColor = true;
            this.BtnResetRestart.Click += new System.EventHandler(this.BtnResetRestart_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zedGraphControl1.Location = new System.Drawing.Point(427, 2);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(300, 300);
            this.zedGraphControl1.TabIndex = 23;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            this.zedGraphControl1.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // PnlLoadData
            // 
            this.PnlLoadData.BackColor = System.Drawing.Color.LightBlue;
            this.PnlLoadData.Controls.Add(this.BtnLoadDatasets);
            this.PnlLoadData.Controls.Add(this.TxtboxTestingDataPath);
            this.PnlLoadData.Controls.Add(this.TxtboxTrainingDataPath);
            this.PnlLoadData.Location = new System.Drawing.Point(3, 3);
            this.PnlLoadData.Name = "PnlLoadData";
            this.PnlLoadData.Size = new System.Drawing.Size(420, 120);
            this.PnlLoadData.TabIndex = 24;
            // 
            // BtnLoadDatasets
            // 
            this.BtnLoadDatasets.Location = new System.Drawing.Point(9, 9);
            this.BtnLoadDatasets.Name = "BtnLoadDatasets";
            this.BtnLoadDatasets.Size = new System.Drawing.Size(175, 50);
            this.BtnLoadDatasets.TabIndex = 5;
            this.BtnLoadDatasets.Text = "Load Data from File(s) to Training and Testing Datasets";
            this.BtnLoadDatasets.UseVisualStyleBackColor = true;
            this.BtnLoadDatasets.Click += new System.EventHandler(this.BtnLoadDatasets_Click);
            // 
            // TxtboxTestingDataPath
            // 
            this.TxtboxTestingDataPath.Location = new System.Drawing.Point(9, 91);
            this.TxtboxTestingDataPath.Name = "TxtboxTestingDataPath";
            this.TxtboxTestingDataPath.Size = new System.Drawing.Size(400, 20);
            this.TxtboxTestingDataPath.TabIndex = 3;
            // 
            // TxtboxTrainingDataPath
            // 
            this.TxtboxTrainingDataPath.Location = new System.Drawing.Point(9, 65);
            this.TxtboxTrainingDataPath.Name = "TxtboxTrainingDataPath";
            this.TxtboxTrainingDataPath.Size = new System.Drawing.Size(400, 20);
            this.TxtboxTrainingDataPath.TabIndex = 2;
            // 
            // BtnEvaluateModelUsingTrainingData
            // 
            this.BtnEvaluateModelUsingTrainingData.Location = new System.Drawing.Point(127, 9);
            this.BtnEvaluateModelUsingTrainingData.Name = "BtnEvaluateModelUsingTrainingData";
            this.BtnEvaluateModelUsingTrainingData.Size = new System.Drawing.Size(112, 50);
            this.BtnEvaluateModelUsingTrainingData.TabIndex = 11;
            this.BtnEvaluateModelUsingTrainingData.Text = "Evaluate Model Using Training Data";
            this.BtnEvaluateModelUsingTrainingData.UseVisualStyleBackColor = true;
            this.BtnEvaluateModelUsingTrainingData.Click += new System.EventHandler(this.BtnEvaluateModelUsingTrainingData_Click);
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.PnlLoadTestingDataAndEvaluate);
            this.Controls.Add(this.PnlBuildPipelineAndModel);
            this.Controls.Add(this.BtnResetRestart);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.PnlLoadData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Demo";
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.Demo_Load);
            this.PnlLoadTestingDataAndEvaluate.ResumeLayout(false);
            this.PnlLoadTestingDataAndEvaluate.PerformLayout();
            this.PnlBuildPipelineAndModel.ResumeLayout(false);
            this.PnlBuildPipelineAndModel.PerformLayout();
            this.PnlLoadData.ResumeLayout(false);
            this.PnlLoadData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlLoadTestingDataAndEvaluate;
        private System.Windows.Forms.TextBox TxtboxAssessmentResults;
        private System.Windows.Forms.Button BtnEvaluateModelUsingTestData;
        private System.Windows.Forms.Panel PnlBuildPipelineAndModel;
        private System.Windows.Forms.TextBox TxtboxModelSaveDataPath;
        private System.Windows.Forms.Button BtnResetRestart;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Panel PnlLoadData;
        private System.Windows.Forms.TextBox TxtboxTestingDataPath;
        private System.Windows.Forms.TextBox TxtboxTrainingDataPath;
        private System.Windows.Forms.Button BtnLoadDatasets;
        private System.Windows.Forms.Button BtnBuildAndTrainModel;
        private System.Windows.Forms.Button BtnSaveModel;
        private System.Windows.Forms.Button BtnEvaluateModelUsingTrainingData;
    }
}