namespace TREX
{
    partial class TRexForm1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Scoretext = new System.Windows.Forms.Label();
            this.GameEvent = new System.Windows.Forms.Timer(this.components);
            this.Hiscoretext = new System.Windows.Forms.Label();
            this.Headerpanel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.cloud1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.trex = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cloud2 = new System.Windows.Forms.PictureBox();
            this.cloud3 = new System.Windows.Forms.PictureBox();
            this.Headerpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(342, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "T REX";
            // 
            // Scoretext
            // 
            this.Scoretext.AutoSize = true;
            this.Scoretext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoretext.Location = new System.Drawing.Point(134, 81);
            this.Scoretext.Name = "Scoretext";
            this.Scoretext.Size = new System.Drawing.Size(123, 31);
            this.Scoretext.TabIndex = 1;
            this.Scoretext.Text = "Score: 0";
            // 
            // GameEvent
            // 
            this.GameEvent.Interval = 20;
            this.GameEvent.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Hiscoretext
            // 
            this.Hiscoretext.AutoSize = true;
            this.Hiscoretext.BackColor = System.Drawing.Color.LightGreen;
            this.Hiscoretext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hiscoretext.Location = new System.Drawing.Point(466, 87);
            this.Hiscoretext.Name = "Hiscoretext";
            this.Hiscoretext.Size = new System.Drawing.Size(109, 25);
            this.Hiscoretext.TabIndex = 9;
            this.Hiscoretext.Text = "Hi Score:";
            // 
            // Headerpanel1
            // 
            this.Headerpanel1.BackColor = System.Drawing.Color.LightBlue;
            this.Headerpanel1.Controls.Add(this.Exit);
            this.Headerpanel1.Controls.Add(this.label1);
            this.Headerpanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headerpanel1.Location = new System.Drawing.Point(0, 0);
            this.Headerpanel1.Name = "Headerpanel1";
            this.Headerpanel1.Size = new System.Drawing.Size(788, 36);
            this.Headerpanel1.TabIndex = 10;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Exit.Location = new System.Drawing.Point(761, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(27, 25);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // cloud1
            // 
            this.cloud1.Image = global::TREX.Properties.Resources.cloudss;
            this.cloud1.Location = new System.Drawing.Point(43, 283);
            this.cloud1.Name = "cloud1";
            this.cloud1.Size = new System.Drawing.Size(179, 80);
            this.cloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cloud1.TabIndex = 11;
            this.cloud1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImage = global::TREX.Properties.Resources.images__1_1;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 460);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TREX.Properties.Resources.obstacle_2;
            this.pictureBox4.Location = new System.Drawing.Point(465, 428);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Barriers";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::TREX.Properties.Resources.Hardle;
            this.pictureBox5.Location = new System.Drawing.Point(328, 397);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 67);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "Barriers";
            // 
            // trex
            // 
            this.trex.Image = global::TREX.Properties.Resources.running;
            this.trex.Location = new System.Drawing.Point(78, 415);
            this.trex.Name = "trex";
            this.trex.Size = new System.Drawing.Size(40, 43);
            this.trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trex.TabIndex = 3;
            this.trex.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TREX.Properties.Resources.obstacle3;
            this.pictureBox2.Location = new System.Drawing.Point(678, 403);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Barriers";
            // 
            // cloud2
            // 
            this.cloud2.Image = global::TREX.Properties.Resources.Clouds;
            this.cloud2.Location = new System.Drawing.Point(318, 283);
            this.cloud2.Name = "cloud2";
            this.cloud2.Size = new System.Drawing.Size(179, 80);
            this.cloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cloud2.TabIndex = 12;
            this.cloud2.TabStop = false;
            // 
            // cloud3
            // 
            this.cloud3.Image = global::TREX.Properties.Resources.Cloud;
            this.cloud3.Location = new System.Drawing.Point(542, 283);
            this.cloud3.Name = "cloud3";
            this.cloud3.Size = new System.Drawing.Size(179, 114);
            this.cloud3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cloud3.TabIndex = 13;
            this.cloud3.TabStop = false;
            // 
            // TRexForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(788, 510);
            this.Controls.Add(this.trex);
            this.Controls.Add(this.cloud3);
            this.Controls.Add(this.cloud2);
            this.Controls.Add(this.cloud1);
            this.Controls.Add(this.Headerpanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Hiscoretext);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Scoretext);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TRexForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TREX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyup);
            this.Headerpanel1.ResumeLayout(false);
            this.Headerpanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Scoretext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox trex;
        private System.Windows.Forms.Timer GameEvent;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Hiscoretext;
        private System.Windows.Forms.Panel Headerpanel1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.PictureBox cloud1;
        private System.Windows.Forms.PictureBox cloud2;
        private System.Windows.Forms.PictureBox cloud3;
    }
}

