namespace TREX
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Scoretext = new System.Windows.Forms.Label();
            this.trex = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.GameEvent = new System.Windows.Forms.Timer(this.components);
            this.heading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 425);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(747, 55);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Scoretext
            // 
            this.Scoretext.AutoSize = true;
            this.Scoretext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoretext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Scoretext.Location = new System.Drawing.Point(323, 62);
            this.Scoretext.Name = "Scoretext";
            this.Scoretext.Size = new System.Drawing.Size(76, 20);
            this.Scoretext.TabIndex = 1;
            this.Scoretext.Text = "Score: 0";
            // 
            // trex
            // 
            this.trex.Image = global::TREX.Properties.Resources.runnerdino;
            this.trex.Location = new System.Drawing.Point(23, 235);
            this.trex.Name = "trex";
            this.trex.Size = new System.Drawing.Size(129, 190);
            this.trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.trex.TabIndex = 2;
            this.trex.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(367, 309);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 116);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(572, 309);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 116);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // GameEvent
            // 
            this.GameEvent.Interval = 20;
            this.GameEvent.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.heading.Location = new System.Drawing.Point(309, 9);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(114, 33);
            this.heading.TabIndex = 5;
            this.heading.Text = "T REX ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 475);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.trex);
            this.Controls.Add(this.Scoretext);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Form1";
            this.Text = "TREX";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Scoretext;
        private System.Windows.Forms.PictureBox trex;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer GameEvent;
        private System.Windows.Forms.Label heading;
    }
}

