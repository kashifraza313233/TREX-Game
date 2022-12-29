namespace TREX
{
    partial class Form2
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
            this.MainHeading = new System.Windows.Forms.Label();
            this.Headerpanel = new System.Windows.Forms.Panel();
            this.Play = new System.Windows.Forms.Button();
            this.Insidepanel = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.About = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.History = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Headerpanel.SuspendLayout();
            this.Insidepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainHeading
            // 
            this.MainHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainHeading.AutoSize = true;
            this.MainHeading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainHeading.Location = new System.Drawing.Point(332, 5);
            this.MainHeading.Name = "MainHeading";
            this.MainHeading.Size = new System.Drawing.Size(172, 57);
            this.MainHeading.TabIndex = 2;
            this.MainHeading.Text = "T REX";
            // 
            // Headerpanel
            // 
            this.Headerpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Headerpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Headerpanel.Controls.Add(this.pictureBox1);
            this.Headerpanel.Controls.Add(this.MainHeading);
            this.Headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headerpanel.Location = new System.Drawing.Point(0, 0);
            this.Headerpanel.Name = "Headerpanel";
            this.Headerpanel.Size = new System.Drawing.Size(886, 67);
            this.Headerpanel.TabIndex = 0;
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Play.Location = new System.Drawing.Point(1, 57);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(123, 41);
            this.Play.TabIndex = 0;
            this.Play.Text = "PlayGame";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Insidepanel
            // 
            this.Insidepanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Insidepanel.Controls.Add(this.Exit);
            this.Insidepanel.Controls.Add(this.History);
            this.Insidepanel.Controls.Add(this.About);
            this.Insidepanel.Controls.Add(this.Play);
            this.Insidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Insidepanel.Location = new System.Drawing.Point(0, 67);
            this.Insidepanel.Name = "Insidepanel";
            this.Insidepanel.Size = new System.Drawing.Size(129, 484);
            this.Insidepanel.TabIndex = 1;
            // 
            // mainpanel
            // 
            this.mainpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 67);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(886, 484);
            this.mainpanel.TabIndex = 2;
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.About.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.About.Location = new System.Drawing.Point(1, 126);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(123, 41);
            this.About.TabIndex = 1;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::TREX.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.History.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.History.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.History.Location = new System.Drawing.Point(1, 195);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(123, 41);
            this.History.TabIndex = 2;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.Location = new System.Drawing.Point(1, 257);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(123, 41);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 551);
            this.Controls.Add(this.Insidepanel);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.Headerpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TREX";
            this.Headerpanel.ResumeLayout(false);
            this.Headerpanel.PerformLayout();
            this.Insidepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MainHeading;
        private System.Windows.Forms.Panel Headerpanel;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Panel Insidepanel;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button History;
    }
}