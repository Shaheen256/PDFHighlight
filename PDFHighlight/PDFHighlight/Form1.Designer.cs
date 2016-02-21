namespace PDFHighlight
{
    partial class Form1
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
            this.PB = new System.Windows.Forms.ProgressBar();
            this.Start = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtSourcePDF = new System.Windows.Forms.TextBox();
            this.txtOutputPDF = new System.Windows.Forms.TextBox();
            this.lblSourcePDF = new System.Windows.Forms.Label();
            this.lblOutputPDF = new System.Windows.Forms.Label();
            this.lblHightlight = new System.Windows.Forms.Label();
            this.txtHighLightText = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkIgnoreCase = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // PB
            // 
            this.PB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PB.Location = new System.Drawing.Point(54, 126);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(491, 59);
            this.PB.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(604, 126);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(89, 58);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start!";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtSourcePDF
            // 
            this.txtSourcePDF.Location = new System.Drawing.Point(131, 22);
            this.txtSourcePDF.Name = "txtSourcePDF";
            this.txtSourcePDF.Size = new System.Drawing.Size(571, 20);
            this.txtSourcePDF.TabIndex = 3;
            this.txtSourcePDF.Click += new System.EventHandler(this.txtSourcePDF_Click);
            // 
            // txtOutputPDF
            // 
            this.txtOutputPDF.Location = new System.Drawing.Point(131, 50);
            this.txtOutputPDF.Name = "txtOutputPDF";
            this.txtOutputPDF.Size = new System.Drawing.Size(571, 20);
            this.txtOutputPDF.TabIndex = 4;
            this.txtOutputPDF.Click += new System.EventHandler(this.txtOutputPDF_Click);
            // 
            // lblSourcePDF
            // 
            this.lblSourcePDF.AutoSize = true;
            this.lblSourcePDF.Location = new System.Drawing.Point(51, 25);
            this.lblSourcePDF.Name = "lblSourcePDF";
            this.lblSourcePDF.Size = new System.Drawing.Size(65, 13);
            this.lblSourcePDF.TabIndex = 5;
            this.lblSourcePDF.Text = "Source PDF";
            // 
            // lblOutputPDF
            // 
            this.lblOutputPDF.AutoSize = true;
            this.lblOutputPDF.Location = new System.Drawing.Point(51, 53);
            this.lblOutputPDF.Name = "lblOutputPDF";
            this.lblOutputPDF.Size = new System.Drawing.Size(63, 13);
            this.lblOutputPDF.TabIndex = 6;
            this.lblOutputPDF.Text = "Output PDF";
            // 
            // lblHightlight
            // 
            this.lblHightlight.AutoSize = true;
            this.lblHightlight.Location = new System.Drawing.Point(51, 81);
            this.lblHightlight.Name = "lblHightlight";
            this.lblHightlight.Size = new System.Drawing.Size(72, 13);
            this.lblHightlight.TabIndex = 8;
            this.lblHightlight.Text = "HightlightText";
            // 
            // txtHighLightText
            // 
            this.txtHighLightText.Location = new System.Drawing.Point(131, 78);
            this.txtHighLightText.Name = "txtHighLightText";
            this.txtHighLightText.Size = new System.Drawing.Size(571, 20);
            this.txtHighLightText.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(311, 107);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 9;
            // 
            // chkIgnoreCase
            // 
            this.chkIgnoreCase.AutoSize = true;
            this.chkIgnoreCase.Checked = true;
            this.chkIgnoreCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIgnoreCase.Location = new System.Drawing.Point(708, 81);
            this.chkIgnoreCase.Name = "chkIgnoreCase";
            this.chkIgnoreCase.Size = new System.Drawing.Size(83, 17);
            this.chkIgnoreCase.TabIndex = 10;
            this.chkIgnoreCase.Text = "Ignore Case";
            this.chkIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 256);
            this.Controls.Add(this.chkIgnoreCase);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblHightlight);
            this.Controls.Add(this.txtHighLightText);
            this.Controls.Add(this.lblOutputPDF);
            this.Controls.Add(this.lblSourcePDF);
            this.Controls.Add(this.txtOutputPDF);
            this.Controls.Add(this.txtSourcePDF);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ProgressBar PB;
        internal System.Windows.Forms.Button Start;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtSourcePDF;
        private System.Windows.Forms.TextBox txtOutputPDF;
        private System.Windows.Forms.Label lblSourcePDF;
        private System.Windows.Forms.Label lblOutputPDF;
        private System.Windows.Forms.Label lblHightlight;
        private System.Windows.Forms.TextBox txtHighLightText;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkIgnoreCase;
    }
}

