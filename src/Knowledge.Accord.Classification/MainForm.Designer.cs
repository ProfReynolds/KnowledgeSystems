namespace Knowledge.Accord.Classification
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
            this.PanelLoadTrainingData = new System.Windows.Forms.Panel();
            this.TxtboxTrainingDataWorksheet = new System.Windows.Forms.TextBox();
            this.BtnLoadDataFromExcelSpreadsheet = new System.Windows.Forms.Button();
            this.TxtboxTrainingDataPath = new System.Windows.Forms.TextBox();
            this.PanelClassifiers = new System.Windows.Forms.Panel();
            this.BtnLogisticRegression = new System.Windows.Forms.Button();
            this.BtnSvmKernal = new System.Windows.Forms.Button();
            this.BtnSvmLinear = new System.Windows.Forms.Button();
            this.BtnResetRestart = new System.Windows.Forms.Button();
            this.PanelLoadTrainingData.SuspendLayout();
            this.PanelClassifiers.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLoadTrainingData
            // 
            this.PanelLoadTrainingData.BackColor = System.Drawing.Color.LightBlue;
            this.PanelLoadTrainingData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelLoadTrainingData.Controls.Add(this.TxtboxTrainingDataWorksheet);
            this.PanelLoadTrainingData.Controls.Add(this.BtnLoadDataFromExcelSpreadsheet);
            this.PanelLoadTrainingData.Controls.Add(this.TxtboxTrainingDataPath);
            this.PanelLoadTrainingData.Location = new System.Drawing.Point(12, 12);
            this.PanelLoadTrainingData.Name = "PanelLoadTrainingData";
            this.PanelLoadTrainingData.Size = new System.Drawing.Size(414, 114);
            this.PanelLoadTrainingData.TabIndex = 0;
            // 
            // TxtboxTrainingDataWorksheet
            // 
            this.TxtboxTrainingDataWorksheet.Location = new System.Drawing.Point(3, 85);
            this.TxtboxTrainingDataWorksheet.Name = "TxtboxTrainingDataWorksheet";
            this.TxtboxTrainingDataWorksheet.Size = new System.Drawing.Size(400, 20);
            this.TxtboxTrainingDataWorksheet.TabIndex = 7;
            // 
            // BtnLoadDataFromExcelSpreadsheet
            // 
            this.BtnLoadDataFromExcelSpreadsheet.Location = new System.Drawing.Point(3, 3);
            this.BtnLoadDataFromExcelSpreadsheet.Name = "BtnLoadDataFromExcelSpreadsheet";
            this.BtnLoadDataFromExcelSpreadsheet.Size = new System.Drawing.Size(115, 50);
            this.BtnLoadDataFromExcelSpreadsheet.TabIndex = 6;
            this.BtnLoadDataFromExcelSpreadsheet.Text = "Load Data from Excel Spreadsheet";
            this.BtnLoadDataFromExcelSpreadsheet.UseVisualStyleBackColor = true;
            this.BtnLoadDataFromExcelSpreadsheet.Click += new System.EventHandler(this.BtnLoadDataFromExcelSpreadsheet_Click);
            // 
            // TxtboxTrainingDataPath
            // 
            this.TxtboxTrainingDataPath.Location = new System.Drawing.Point(3, 59);
            this.TxtboxTrainingDataPath.Name = "TxtboxTrainingDataPath";
            this.TxtboxTrainingDataPath.Size = new System.Drawing.Size(400, 20);
            this.TxtboxTrainingDataPath.TabIndex = 5;
            // 
            // PanelClassifiers
            // 
            this.PanelClassifiers.BackColor = System.Drawing.Color.LightBlue;
            this.PanelClassifiers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelClassifiers.Controls.Add(this.BtnLogisticRegression);
            this.PanelClassifiers.Controls.Add(this.BtnSvmKernal);
            this.PanelClassifiers.Controls.Add(this.BtnSvmLinear);
            this.PanelClassifiers.Location = new System.Drawing.Point(12, 132);
            this.PanelClassifiers.Name = "PanelClassifiers";
            this.PanelClassifiers.Size = new System.Drawing.Size(414, 44);
            this.PanelClassifiers.TabIndex = 1;
            // 
            // BtnLogisticRegression
            // 
            this.BtnLogisticRegression.Location = new System.Drawing.Point(215, 3);
            this.BtnLogisticRegression.Name = "BtnLogisticRegression";
            this.BtnLogisticRegression.Size = new System.Drawing.Size(100, 35);
            this.BtnLogisticRegression.TabIndex = 8;
            this.BtnLogisticRegression.Text = "Logistic Regression";
            this.BtnLogisticRegression.UseVisualStyleBackColor = true;
            this.BtnLogisticRegression.Click += new System.EventHandler(this.BtnLogisticRegression_Click);
            // 
            // BtnSvmKernal
            // 
            this.BtnSvmKernal.Location = new System.Drawing.Point(109, 3);
            this.BtnSvmKernal.Name = "BtnSvmKernal";
            this.BtnSvmKernal.Size = new System.Drawing.Size(100, 35);
            this.BtnSvmKernal.TabIndex = 7;
            this.BtnSvmKernal.Text = "SVM: Kernal";
            this.BtnSvmKernal.UseVisualStyleBackColor = true;
            this.BtnSvmKernal.Click += new System.EventHandler(this.BtnSvmKernal_Click);
            // 
            // BtnSvmLinear
            // 
            this.BtnSvmLinear.Location = new System.Drawing.Point(3, 3);
            this.BtnSvmLinear.Name = "BtnSvmLinear";
            this.BtnSvmLinear.Size = new System.Drawing.Size(100, 35);
            this.BtnSvmLinear.TabIndex = 7;
            this.BtnSvmLinear.Text = "SVM: Linear";
            this.BtnSvmLinear.UseVisualStyleBackColor = true;
            this.BtnSvmLinear.Click += new System.EventHandler(this.BtnSvmLinear_Click);
            // 
            // BtnResetRestart
            // 
            this.BtnResetRestart.Location = new System.Drawing.Point(472, 168);
            this.BtnResetRestart.Name = "BtnResetRestart";
            this.BtnResetRestart.Size = new System.Drawing.Size(152, 33);
            this.BtnResetRestart.TabIndex = 16;
            this.BtnResetRestart.Text = "Reset / Restart";
            this.BtnResetRestart.UseVisualStyleBackColor = true;
            this.BtnResetRestart.Click += new System.EventHandler(this.BtnResetRestart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 213);
            this.Controls.Add(this.BtnResetRestart);
            this.Controls.Add(this.PanelClassifiers);
            this.Controls.Add(this.PanelLoadTrainingData);
            this.Name = "MainForm";
            this.Text = "Accord Demonstrator by Mark Reynolds - Classification";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PanelLoadTrainingData.ResumeLayout(false);
            this.PanelLoadTrainingData.PerformLayout();
            this.PanelClassifiers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLoadTrainingData;
        private System.Windows.Forms.Button BtnLoadDataFromExcelSpreadsheet;
        private System.Windows.Forms.TextBox TxtboxTrainingDataPath;
        private System.Windows.Forms.Panel PanelClassifiers;
        private System.Windows.Forms.Button BtnResetRestart;
        private System.Windows.Forms.TextBox TxtboxTrainingDataWorksheet;
        private System.Windows.Forms.Button BtnLogisticRegression;
        private System.Windows.Forms.Button BtnSvmKernal;
        private System.Windows.Forms.Button BtnSvmLinear;
    }
}

