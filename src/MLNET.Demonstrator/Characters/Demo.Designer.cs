namespace Knowledge.MLNET.Demonstrator.Characters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Demo));
            this.PnlLoadData = new System.Windows.Forms.Panel();
            this.BtnLoadDatasets = new System.Windows.Forms.Button();
            this.TxtboxTestingDataPath = new System.Windows.Forms.TextBox();
            this.TxtboxTrainingDataPath = new System.Windows.Forms.TextBox();
            this.PnlBuildPipelineAndModel = new System.Windows.Forms.Panel();
            this.TxtboxModelSaveDataPath = new System.Windows.Forms.TextBox();
            this.RadioBtnLightGbm = new System.Windows.Forms.RadioButton();
            this.RadioBtnOneVsAll = new System.Windows.Forms.RadioButton();
            this.BtnBuildAndTrainModel = new System.Windows.Forms.Button();
            this.BtnSaveModel = new System.Windows.Forms.Button();
            this.PnlLoadTestingDataAndEvaluate = new System.Windows.Forms.Panel();
            this.TxtboxAssessmentResults = new System.Windows.Forms.TextBox();
            this.BtnEvaluateModelUsingTestData = new System.Windows.Forms.Button();
            this.BtnResetRestart = new System.Windows.Forms.Button();
            this.PnlLoadData.SuspendLayout();
            this.PnlBuildPipelineAndModel.SuspendLayout();
            this.PnlLoadTestingDataAndEvaluate.SuspendLayout();
            this.SuspendLayout();
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
            this.PnlLoadData.TabIndex = 20;
            // 
            // BtnLoadDatasets
            // 
            this.BtnLoadDatasets.Location = new System.Drawing.Point(9, 9);
            this.BtnLoadDatasets.Name = "BtnLoadDatasets";
            this.BtnLoadDatasets.Size = new System.Drawing.Size(175, 50);
            this.BtnLoadDatasets.TabIndex = 4;
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
            // PnlBuildPipelineAndModel
            // 
            this.PnlBuildPipelineAndModel.BackColor = System.Drawing.Color.LightBlue;
            this.PnlBuildPipelineAndModel.Controls.Add(this.TxtboxModelSaveDataPath);
            this.PnlBuildPipelineAndModel.Controls.Add(this.RadioBtnLightGbm);
            this.PnlBuildPipelineAndModel.Controls.Add(this.RadioBtnOneVsAll);
            this.PnlBuildPipelineAndModel.Controls.Add(this.BtnBuildAndTrainModel);
            this.PnlBuildPipelineAndModel.Controls.Add(this.BtnSaveModel);
            this.PnlBuildPipelineAndModel.Location = new System.Drawing.Point(3, 129);
            this.PnlBuildPipelineAndModel.Name = "PnlBuildPipelineAndModel";
            this.PnlBuildPipelineAndModel.Size = new System.Drawing.Size(420, 97);
            this.PnlBuildPipelineAndModel.TabIndex = 21;
            // 
            // TxtboxModelSaveDataPath
            // 
            this.TxtboxModelSaveDataPath.Location = new System.Drawing.Point(9, 65);
            this.TxtboxModelSaveDataPath.Name = "TxtboxModelSaveDataPath";
            this.TxtboxModelSaveDataPath.Size = new System.Drawing.Size(400, 20);
            this.TxtboxModelSaveDataPath.TabIndex = 11;
            // 
            // RadioBtnLightGbm
            // 
            this.RadioBtnLightGbm.AutoSize = true;
            this.RadioBtnLightGbm.Location = new System.Drawing.Point(190, 36);
            this.RadioBtnLightGbm.Name = "RadioBtnLightGbm";
            this.RadioBtnLightGbm.Size = new System.Drawing.Size(70, 17);
            this.RadioBtnLightGbm.TabIndex = 10;
            this.RadioBtnLightGbm.TabStop = true;
            this.RadioBtnLightGbm.Text = "LightGbm";
            this.RadioBtnLightGbm.UseVisualStyleBackColor = true;
            // 
            // RadioBtnOneVsAll
            // 
            this.RadioBtnOneVsAll.AutoSize = true;
            this.RadioBtnOneVsAll.Checked = true;
            this.RadioBtnOneVsAll.Location = new System.Drawing.Point(190, 19);
            this.RadioBtnOneVsAll.Name = "RadioBtnOneVsAll";
            this.RadioBtnOneVsAll.Size = new System.Drawing.Size(88, 17);
            this.RadioBtnOneVsAll.TabIndex = 9;
            this.RadioBtnOneVsAll.TabStop = true;
            this.RadioBtnOneVsAll.Text = "OneVersusAll";
            this.RadioBtnOneVsAll.UseVisualStyleBackColor = true;
            // 
            // BtnBuildAndTrainModel
            // 
            this.BtnBuildAndTrainModel.Location = new System.Drawing.Point(9, 9);
            this.BtnBuildAndTrainModel.Name = "BtnBuildAndTrainModel";
            this.BtnBuildAndTrainModel.Size = new System.Drawing.Size(175, 50);
            this.BtnBuildAndTrainModel.TabIndex = 7;
            this.BtnBuildAndTrainModel.Text = "Build Training Pipeline, Evaluate and Train Model";
            this.BtnBuildAndTrainModel.UseVisualStyleBackColor = true;
            this.BtnBuildAndTrainModel.Click += new System.EventHandler(this.BtnBuildAndTrainModel_Click);
            // 
            // BtnSaveModel
            // 
            this.BtnSaveModel.Location = new System.Drawing.Point(359, 9);
            this.BtnSaveModel.Name = "BtnSaveModel";
            this.BtnSaveModel.Size = new System.Drawing.Size(50, 50);
            this.BtnSaveModel.TabIndex = 8;
            this.BtnSaveModel.Text = "Save Model";
            this.BtnSaveModel.UseVisualStyleBackColor = true;
            this.BtnSaveModel.Click += new System.EventHandler(this.BtnSaveModel_Click);
            // 
            // PnlLoadTestingDataAndEvaluate
            // 
            this.PnlLoadTestingDataAndEvaluate.BackColor = System.Drawing.Color.LightBlue;
            this.PnlLoadTestingDataAndEvaluate.Controls.Add(this.TxtboxAssessmentResults);
            this.PnlLoadTestingDataAndEvaluate.Controls.Add(this.BtnEvaluateModelUsingTestData);
            this.PnlLoadTestingDataAndEvaluate.Location = new System.Drawing.Point(3, 232);
            this.PnlLoadTestingDataAndEvaluate.Name = "PnlLoadTestingDataAndEvaluate";
            this.PnlLoadTestingDataAndEvaluate.Size = new System.Drawing.Size(420, 97);
            this.PnlLoadTestingDataAndEvaluate.TabIndex = 22;
            // 
            // TxtboxAssessmentResults
            // 
            this.TxtboxAssessmentResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtboxAssessmentResults.Location = new System.Drawing.Point(9, 65);
            this.TxtboxAssessmentResults.Name = "TxtboxAssessmentResults";
            this.TxtboxAssessmentResults.ReadOnly = true;
            this.TxtboxAssessmentResults.Size = new System.Drawing.Size(400, 20);
            this.TxtboxAssessmentResults.TabIndex = 12;
            this.TxtboxAssessmentResults.Text = "Assessment Results";
            this.TxtboxAssessmentResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnEvaluateModelUsingTestData
            // 
            this.BtnEvaluateModelUsingTestData.Location = new System.Drawing.Point(9, 9);
            this.BtnEvaluateModelUsingTestData.Name = "BtnEvaluateModelUsingTestData";
            this.BtnEvaluateModelUsingTestData.Size = new System.Drawing.Size(102, 50);
            this.BtnEvaluateModelUsingTestData.TabIndex = 11;
            this.BtnEvaluateModelUsingTestData.Text = "Evaluate Model Using Test Data";
            this.BtnEvaluateModelUsingTestData.UseVisualStyleBackColor = true;
            this.BtnEvaluateModelUsingTestData.Click += new System.EventHandler(this.BtnEvaluateModelUsingTestData_Click);
            // 
            // BtnResetRestart
            // 
            this.BtnResetRestart.Location = new System.Drawing.Point(271, 335);
            this.BtnResetRestart.Name = "BtnResetRestart";
            this.BtnResetRestart.Size = new System.Drawing.Size(152, 33);
            this.BtnResetRestart.TabIndex = 23;
            this.BtnResetRestart.Text = "Reset / Restart";
            this.BtnResetRestart.UseVisualStyleBackColor = true;
            this.BtnResetRestart.Click += new System.EventHandler(this.BtnResetRestart_Click);
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 417);
            this.Controls.Add(this.BtnResetRestart);
            this.Controls.Add(this.PnlLoadTestingDataAndEvaluate);
            this.Controls.Add(this.PnlBuildPipelineAndModel);
            this.Controls.Add(this.PnlLoadData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Demo";
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.Demo_Load);
            this.PnlLoadData.ResumeLayout(false);
            this.PnlLoadData.PerformLayout();
            this.PnlBuildPipelineAndModel.ResumeLayout(false);
            this.PnlBuildPipelineAndModel.PerformLayout();
            this.PnlLoadTestingDataAndEvaluate.ResumeLayout(false);
            this.PnlLoadTestingDataAndEvaluate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlLoadData;
        private System.Windows.Forms.Button BtnLoadDatasets;
        private System.Windows.Forms.TextBox TxtboxTestingDataPath;
        private System.Windows.Forms.TextBox TxtboxTrainingDataPath;
        private System.Windows.Forms.Panel PnlBuildPipelineAndModel;
        private System.Windows.Forms.RadioButton RadioBtnLightGbm;
        private System.Windows.Forms.RadioButton RadioBtnOneVsAll;
        private System.Windows.Forms.Button BtnBuildAndTrainModel;
        private System.Windows.Forms.Button BtnSaveModel;
        private System.Windows.Forms.Panel PnlLoadTestingDataAndEvaluate;
        private System.Windows.Forms.TextBox TxtboxAssessmentResults;
        private System.Windows.Forms.Button BtnEvaluateModelUsingTestData;
        private System.Windows.Forms.Button BtnResetRestart;
        private System.Windows.Forms.TextBox TxtboxModelSaveDataPath;
    }
}