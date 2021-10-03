
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Pipeup = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.Pipedown = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.Mytimer = new System.Windows.Forms.Timer(this.components);
            this.Over = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pipeup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipedown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            this.SuspendLayout();
            // 
            // Pipeup
            // 
            this.Pipeup.Image = global::WinFormsApp1.Properties.Resources.pipedown;
            this.Pipeup.Location = new System.Drawing.Point(799, -2);
            this.Pipeup.Name = "Pipeup";
            this.Pipeup.Size = new System.Drawing.Size(86, 285);
            this.Pipeup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pipeup.TabIndex = 0;
            this.Pipeup.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.Image = global::WinFormsApp1.Properties.Resources.bird;
            this.Bird.Location = new System.Drawing.Point(90, 138);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(64, 49);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 1;
            this.Bird.TabStop = false;
            // 
            // Pipedown
            // 
            this.Pipedown.Image = global::WinFormsApp1.Properties.Resources.pipe;
            this.Pipedown.Location = new System.Drawing.Point(392, 226);
            this.Pipedown.Name = "Pipedown";
            this.Pipedown.Size = new System.Drawing.Size(90, 273);
            this.Pipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pipedown.TabIndex = 2;
            this.Pipedown.TabStop = false;
            this.Pipedown.Click += new System.EventHandler(this.Pipedown_Click);
            // 
            // Ground
            // 
            this.Ground.Image = global::WinFormsApp1.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(0, 496);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(953, 78);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 3;
            this.Ground.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Score.Location = new System.Drawing.Point(29, 26);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(100, 32);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score:";
            // 
            // Mytimer
            // 
            this.Mytimer.Enabled = true;
            this.Mytimer.Interval = 50;
            this.Mytimer.Tick += new System.EventHandler(this.Timerevent);
            // 
            // Over
            // 
            this.Over.AutoSize = true;
            this.Over.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Over.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Over.Location = new System.Drawing.Point(311, 72);
            this.Over.Name = "Over";
            this.Over.Size = new System.Drawing.Size(0, 56);
            this.Over.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(931, 565);
            this.Controls.Add(this.Over);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Pipedown);
            this.Controls.Add(this.Pipeup);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.Ground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.restart);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.birddown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.birdup);
            ((System.ComponentModel.ISupportInitialize)(this.Pipeup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipedown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pipeup;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.PictureBox Pipedown;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer Mytimer;
        private System.Windows.Forms.Label Over;
    }
}

