namespace Knowledge.MLNET.Demonstrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnHousing = new System.Windows.Forms.Button();
            this.BtnCharaters = new System.Windows.Forms.Button();
            this.BtnDigits = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnHousing);
            this.panel1.Controls.Add(this.BtnCharaters);
            this.panel1.Controls.Add(this.BtnDigits);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(78, 450);
            this.panel1.TabIndex = 1;
            // 
            // BtnHousing
            // 
            this.BtnHousing.Location = new System.Drawing.Point(0, 89);
            this.BtnHousing.Name = "BtnHousing";
            this.BtnHousing.Size = new System.Drawing.Size(78, 37);
            this.BtnHousing.TabIndex = 2;
            this.BtnHousing.Text = "Housing";
            this.BtnHousing.UseVisualStyleBackColor = true;
            this.BtnHousing.Click += new System.EventHandler(this.BtnHousing_Click);
            // 
            // BtnCharaters
            // 
            this.BtnCharaters.Location = new System.Drawing.Point(0, 46);
            this.BtnCharaters.Name = "BtnCharaters";
            this.BtnCharaters.Size = new System.Drawing.Size(78, 37);
            this.BtnCharaters.TabIndex = 1;
            this.BtnCharaters.Text = "Charaters";
            this.BtnCharaters.UseVisualStyleBackColor = true;
            this.BtnCharaters.Click += new System.EventHandler(this.BtnCharaters_Click);
            // 
            // BtnDigits
            // 
            this.BtnDigits.Location = new System.Drawing.Point(0, 3);
            this.BtnDigits.Name = "BtnDigits";
            this.BtnDigits.Size = new System.Drawing.Size(78, 37);
            this.BtnDigits.TabIndex = 0;
            this.BtnDigits.Text = "Digits";
            this.BtnDigits.UseVisualStyleBackColor = true;
            this.BtnDigits.Click += new System.EventHandler(this.BtnDigits_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "ML.NET Demonstrator by Mark Reynolds - Digits";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDigits;
        private System.Windows.Forms.Button BtnHousing;
        private System.Windows.Forms.Button BtnCharaters;
    }
}

