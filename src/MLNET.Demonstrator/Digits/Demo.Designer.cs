namespace Knowledge.MLNET.Demonstrator.Digits
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
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.PnlLoadData = new System.Windows.Forms.Panel();
            this.LblRandomDigit = new System.Windows.Forms.Label();
            this.BtnDisplayRandomDigit = new System.Windows.Forms.Button();
            this.BtnLoadLargeDatasets = new System.Windows.Forms.Button();
            this.BtnLoadSmallDatasets = new System.Windows.Forms.Button();
            this.TxtboxTestingDataPath = new System.Windows.Forms.TextBox();
            this.TxtboxTrainingDataPath = new System.Windows.Forms.TextBox();
            this.BtnResetRestart = new System.Windows.Forms.Button();
            this.PnlBuildPipelineAndModel = new System.Windows.Forms.Panel();
            this.TxtboxModelSaveDataPath = new System.Windows.Forms.TextBox();
            this.BtnSaveModel = new System.Windows.Forms.Button();
            this.BtnBuildAndTrainModel = new System.Windows.Forms.Button();
            this.PnlLoadTestingDataAndEvaluate = new System.Windows.Forms.Panel();
            this.TxtboxAssessmentResults = new System.Windows.Forms.TextBox();
            this.BtnEvaluateModelUsingTestData = new System.Windows.Forms.Button();
            this.PnlLoadData.SuspendLayout();
            this.PnlBuildPipelineAndModel.SuspendLayout();
            this.PnlLoadTestingDataAndEvaluate.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zedGraphControl1.Location = new System.Drawing.Point(429, 2);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(300, 300);
            this.zedGraphControl1.TabIndex = 17;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            this.zedGraphControl1.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // PnlLoadData
            // 
            this.PnlLoadData.BackColor = System.Drawing.Color.LightBlue;
            this.PnlLoadData.Controls.Add(this.LblRandomDigit);
            this.PnlLoadData.Controls.Add(this.BtnDisplayRandomDigit);
            this.PnlLoadData.Controls.Add(this.BtnLoadLargeDatasets);
            this.PnlLoadData.Controls.Add(this.BtnLoadSmallDatasets);
            this.PnlLoadData.Controls.Add(this.TxtboxTestingDataPath);
            this.PnlLoadData.Controls.Add(this.TxtboxTrainingDataPath);
            this.PnlLoadData.Location = new System.Drawing.Point(3, 3);
            this.PnlLoadData.Name = "PnlLoadData";
            this.PnlLoadData.Size = new System.Drawing.Size(420, 120);
            this.PnlLoadData.TabIndex = 19;
            // 
            // LblRandomDigit
            // 
            this.LblRandomDigit.AutoSize = true;
            this.LblRandomDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRandomDigit.Location = new System.Drawing.Point(367, 10);
            this.LblRandomDigit.Name = "LblRandomDigit";
            this.LblRandomDigit.Size = new System.Drawing.Size(39, 42);
            this.LblRandomDigit.TabIndex = 7;
            this.LblRandomDigit.Text = "?";
            // 
            // BtnDisplayRandomDigit
            // 
            this.BtnDisplayRandomDigit.Location = new System.Drawing.Point(271, 9);
            this.BtnDisplayRandomDigit.Name = "BtnDisplayRandomDigit";
            this.BtnDisplayRandomDigit.Size = new System.Drawing.Size(90, 50);
            this.BtnDisplayRandomDigit.TabIndex = 5;
            this.BtnDisplayRandomDigit.Text = "Display Random Digit";
            this.BtnDisplayRandomDigit.UseVisualStyleBackColor = true;
            this.BtnDisplayRandomDigit.Click += new System.EventHandler(this.BtnDisplayRandomDigit_Click);
            // 
            // BtnLoadLargeDatasets
            // 
            this.BtnLoadLargeDatasets.Location = new System.Drawing.Point(140, 9);
            this.BtnLoadLargeDatasets.Name = "BtnLoadLargeDatasets";
            this.BtnLoadLargeDatasets.Size = new System.Drawing.Size(125, 50);
            this.BtnLoadLargeDatasets.TabIndex = 4;
            this.BtnLoadLargeDatasets.Text = "Load Large Training and Testing Data";
            this.BtnLoadLargeDatasets.UseVisualStyleBackColor = true;
            this.BtnLoadLargeDatasets.Click += new System.EventHandler(this.BtnLoadLargeDatasets_Click);
            // 
            // BtnLoadSmallDatasets
            // 
            this.BtnLoadSmallDatasets.Location = new System.Drawing.Point(9, 9);
            this.BtnLoadSmallDatasets.Name = "BtnLoadSmallDatasets";
            this.BtnLoadSmallDatasets.Size = new System.Drawing.Size(125, 50);
            this.BtnLoadSmallDatasets.TabIndex = 4;
            this.BtnLoadSmallDatasets.Text = "Load Small Training and Testing Data";
            this.BtnLoadSmallDatasets.UseVisualStyleBackColor = true;
            this.BtnLoadSmallDatasets.Click += new System.EventHandler(this.BtnLoadSmallDatasets_Click);
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
            // BtnResetRestart
            // 
            this.BtnResetRestart.Location = new System.Drawing.Point(271, 335);
            this.BtnResetRestart.Name = "BtnResetRestart";
            this.BtnResetRestart.Size = new System.Drawing.Size(152, 33);
            this.BtnResetRestart.TabIndex = 20;
            this.BtnResetRestart.Text = "Reset / Restart";
            this.BtnResetRestart.UseVisualStyleBackColor = true;
            this.BtnResetRestart.Click += new System.EventHandler(this.BtnResetRestart_Click);
            // 
            // PnlBuildPipelineAndModel
            // 
            this.PnlBuildPipelineAndModel.BackColor = System.Drawing.Color.LightBlue;
            this.PnlBuildPipelineAndModel.Controls.Add(this.TxtboxModelSaveDataPath);
            this.PnlBuildPipelineAndModel.Controls.Add(this.BtnSaveModel);
            this.PnlBuildPipelineAndModel.Controls.Add(this.BtnBuildAndTrainModel);
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
            this.TxtboxModelSaveDataPath.TabIndex = 4;
            // 
            // BtnSaveModel
            // 
            this.BtnSaveModel.Location = new System.Drawing.Point(359, 9);
            this.BtnSaveModel.Name = "BtnSaveModel";
            this.BtnSaveModel.Size = new System.Drawing.Size(50, 50);
            this.BtnSaveModel.TabIndex = 3;
            this.BtnSaveModel.Text = "Save Model";
            this.BtnSaveModel.UseVisualStyleBackColor = true;
            this.BtnSaveModel.Click += new System.EventHandler(this.BtnSaveModel_Click);
            // 
            // BtnBuildAndTrainModel
            // 
            this.BtnBuildAndTrainModel.Location = new System.Drawing.Point(9, 9);
            this.BtnBuildAndTrainModel.Name = "BtnBuildAndTrainModel";
            this.BtnBuildAndTrainModel.Size = new System.Drawing.Size(175, 50);
            this.BtnBuildAndTrainModel.TabIndex = 2;
            this.BtnBuildAndTrainModel.Text = "Build Training Pipeline, Evaluate and Train Model";
            this.BtnBuildAndTrainModel.UseVisualStyleBackColor = true;
            this.BtnBuildAndTrainModel.Click += new System.EventHandler(this.BtnBuildAndTrainModel_Click);
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
            this.TxtboxAssessmentResults.TabIndex = 10;
            this.TxtboxAssessmentResults.Text = "Assessment Results";
            this.TxtboxAssessmentResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnEvaluateModelUsingTestData
            // 
            this.BtnEvaluateModelUsingTestData.Location = new System.Drawing.Point(9, 9);
            this.BtnEvaluateModelUsingTestData.Name = "BtnEvaluateModelUsingTestData";
            this.BtnEvaluateModelUsingTestData.Size = new System.Drawing.Size(102, 50);
            this.BtnEvaluateModelUsingTestData.TabIndex = 9;
            this.BtnEvaluateModelUsingTestData.Text = "Evaluate Model Using Test Data";
            this.BtnEvaluateModelUsingTestData.UseVisualStyleBackColor = true;
            this.BtnEvaluateModelUsingTestData.Click += new System.EventHandler(this.BtnEvaluateModelUsingTestData_Click);
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 417);
            this.Controls.Add(this.PnlLoadTestingDataAndEvaluate);
            this.Controls.Add(this.PnlBuildPipelineAndModel);
            this.Controls.Add(this.BtnResetRestart);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.PnlLoadData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Demo";
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

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Panel PnlLoadData;
        private System.Windows.Forms.TextBox TxtboxTrainingDataPath;
        private System.Windows.Forms.TextBox TxtboxTestingDataPath;
        private System.Windows.Forms.Button BtnDisplayRandomDigit;
        private System.Windows.Forms.Button BtnLoadSmallDatasets;
        private System.Windows.Forms.Button BtnLoadLargeDatasets;
        private System.Windows.Forms.Button BtnResetRestart;
        private System.Windows.Forms.Panel PnlBuildPipelineAndModel;
        private System.Windows.Forms.Panel PnlLoadTestingDataAndEvaluate;
        private System.Windows.Forms.Label LblRandomDigit;
        private System.Windows.Forms.Button BtnBuildAndTrainModel;
        private System.Windows.Forms.Button BtnSaveModel;
        private System.Windows.Forms.Button BtnEvaluateModelUsingTestData;
        private System.Windows.Forms.TextBox TxtboxAssessmentResults;
        private System.Windows.Forms.TextBox TxtboxModelSaveDataPath;
    }
}