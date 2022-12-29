namespace TREX
{
    partial class History
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
            this.headpanel1 = new System.Windows.Forms.Panel();
            this.headinglabel1 = new System.Windows.Forms.Label();
            this.headpanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headpanel1
            // 
            this.headpanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.headpanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.headpanel1.Controls.Add(this.headinglabel1);
            this.headpanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.headpanel1.Location = new System.Drawing.Point(0, 0);
            this.headpanel1.Name = "headpanel1";
            this.headpanel1.Size = new System.Drawing.Size(778, 50);
            this.headpanel1.TabIndex = 0;
            // 
            // headinglabel1
            // 
            this.headinglabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headinglabel1.AutoSize = true;
            this.headinglabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headinglabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.headinglabel1.Location = new System.Drawing.Point(301, 7);
            this.headinglabel1.Name = "headinglabel1";
            this.headinglabel1.Size = new System.Drawing.Size(135, 24);
            this.headinglabel1.TabIndex = 0;
            this.headinglabel1.Text = "Score History";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 429);
            this.Controls.Add(this.headpanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.headpanel1.ResumeLayout(false);
            this.headpanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headpanel1;
        private System.Windows.Forms.Label headinglabel1;
    }
}