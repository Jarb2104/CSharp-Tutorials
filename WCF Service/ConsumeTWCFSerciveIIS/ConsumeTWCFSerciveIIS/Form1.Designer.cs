namespace ConsumeTWCFSerciveIIS
{
    partial class frmWCFServiceTest
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
            this.tbTest = new System.Windows.Forms.TextBox();
            this.btTest = new System.Windows.Forms.Button();
            this.lbTestResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTest
            // 
            this.tbTest.Location = new System.Drawing.Point(12, 12);
            this.tbTest.Name = "tbTest";
            this.tbTest.Size = new System.Drawing.Size(100, 20);
            this.tbTest.TabIndex = 0;
            // 
            // btTest
            // 
            this.btTest.Location = new System.Drawing.Point(118, 10);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(75, 23);
            this.btTest.TabIndex = 1;
            this.btTest.Text = "Test";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // lbTestResult
            // 
            this.lbTestResult.AutoSize = true;
            this.lbTestResult.Location = new System.Drawing.Point(13, 39);
            this.lbTestResult.Name = "lbTestResult";
            this.lbTestResult.Size = new System.Drawing.Size(0, 13);
            this.lbTestResult.TabIndex = 2;
            // 
            // frmWCFServiceTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 58);
            this.Controls.Add(this.lbTestResult);
            this.Controls.Add(this.btTest);
            this.Controls.Add(this.tbTest);
            this.Name = "frmWCFServiceTest";
            this.Text = "WCF Service Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTest;
        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.Label lbTestResult;
    }
}

