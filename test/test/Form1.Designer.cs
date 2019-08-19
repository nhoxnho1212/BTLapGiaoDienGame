namespace test
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbScore = new System.Windows.Forms.Label();
            this.timerScore = new System.Windows.Forms.Timer(this.components);
            this.menuDead = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbScoreDead = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPreviousDead = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.GbMenu = new System.Windows.Forms.GroupBox();
            this.pbPreviousPaused = new System.Windows.Forms.PictureBox();
            this.pbRestart = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuDead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviousDead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.GbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviousPaused)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lbScore
            // 
            this.lbScore.BackColor = System.Drawing.Color.Transparent;
            this.lbScore.Font = new System.Drawing.Font("Debussy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.Green;
            this.lbScore.Image = global::test.Properties.Resources._68452099_535109210650034_728312125667147776_n;
            this.lbScore.Location = new System.Drawing.Point(847, 22);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(123, 57);
            this.lbScore.TabIndex = 0;
            this.lbScore.Text = "0";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbScore.Click += new System.EventHandler(this.LbScore_Click);
            // 
            // timerScore
            // 
            this.timerScore.Enabled = true;
            this.timerScore.Tick += new System.EventHandler(this.TimerScore_Tick);
            // 
            // menuDead
            // 
            this.menuDead.BackColor = System.Drawing.Color.Transparent;
            this.menuDead.BackgroundImage = global::test.Properties.Resources.youLose;
            this.menuDead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuDead.Controls.Add(this.label3);
            this.menuDead.Controls.Add(this.lbScoreDead);
            this.menuDead.Controls.Add(this.label2);
            this.menuDead.Controls.Add(this.label1);
            this.menuDead.Controls.Add(this.pbPreviousDead);
            this.menuDead.Controls.Add(this.pictureBox4);
            this.menuDead.Enabled = false;
            this.menuDead.Location = new System.Drawing.Point(278, 47);
            this.menuDead.Name = "menuDead";
            this.menuDead.Size = new System.Drawing.Size(450, 444);
            this.menuDead.TabIndex = 1;
            this.menuDead.TabStop = false;
            this.menuDead.Visible = false;
            this.menuDead.Enter += new System.EventHandler(this.GbMenu_Enter);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Debussy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(290, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 53);
            this.label3.TabIndex = 2;
            this.label3.Text = "500";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbScoreDead
            // 
            this.lbScoreDead.Font = new System.Drawing.Font("Debussy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScoreDead.ForeColor = System.Drawing.Color.Green;
            this.lbScoreDead.Location = new System.Drawing.Point(290, 261);
            this.lbScoreDead.Name = "lbScoreDead";
            this.lbScoreDead.Size = new System.Drawing.Size(133, 53);
            this.lbScoreDead.TabIndex = 2;
            this.lbScoreDead.Text = "0";
            this.lbScoreDead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Debussy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(21, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Best Score:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Debussy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(104, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPreviousDead
            // 
            this.pbPreviousDead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPreviousDead.Image = global::test.Properties.Resources._68439902_417049765664628_7636492005937250304_n;
            this.pbPreviousDead.Location = new System.Drawing.Point(269, 121);
            this.pbPreviousDead.Name = "pbPreviousDead";
            this.pbPreviousDead.Size = new System.Drawing.Size(110, 97);
            this.pbPreviousDead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPreviousDead.TabIndex = 0;
            this.pbPreviousDead.TabStop = false;
            this.pbPreviousDead.Click += new System.EventHandler(this.pbPrevious_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::test.Properties.Resources._68461705_2353676068002203_4348747575105421312_n;
            this.pictureBox4.Location = new System.Drawing.Point(89, 121);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(110, 97);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pbRestart_Click);
            // 
            // GbMenu
            // 
            this.GbMenu.BackColor = System.Drawing.Color.Transparent;
            this.GbMenu.BackgroundImage = global::test.Properties.Resources.pauseMenu;
            this.GbMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GbMenu.Controls.Add(this.pbPreviousPaused);
            this.GbMenu.Controls.Add(this.pbRestart);
            this.GbMenu.Controls.Add(this.pictureBox1);
            this.GbMenu.Location = new System.Drawing.Point(221, 79);
            this.GbMenu.Name = "GbMenu";
            this.GbMenu.Size = new System.Drawing.Size(585, 312);
            this.GbMenu.TabIndex = 1;
            this.GbMenu.TabStop = false;
            this.GbMenu.Enter += new System.EventHandler(this.GbMenu_Enter);
            // 
            // pbPreviousPaused
            // 
            this.pbPreviousPaused.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPreviousPaused.Image = global::test.Properties.Resources._68439902_417049765664628_7636492005937250304_n;
            this.pbPreviousPaused.Location = new System.Drawing.Point(394, 131);
            this.pbPreviousPaused.Name = "pbPreviousPaused";
            this.pbPreviousPaused.Size = new System.Drawing.Size(110, 92);
            this.pbPreviousPaused.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPreviousPaused.TabIndex = 0;
            this.pbPreviousPaused.TabStop = false;
            this.pbPreviousPaused.Click += new System.EventHandler(this.pbPrevious_Click);
            // 
            // pbRestart
            // 
            this.pbRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRestart.Image = global::test.Properties.Resources._68461705_2353676068002203_4348747575105421312_n;
            this.pbRestart.Location = new System.Drawing.Point(236, 131);
            this.pbRestart.Name = "pbRestart";
            this.pbRestart.Size = new System.Drawing.Size(110, 92);
            this.pbRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRestart.TabIndex = 0;
            this.pbRestart.TabStop = false;
            this.pbRestart.Click += new System.EventHandler(this.pbRestart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::test.Properties.Resources._67974059_725468641259549_3153716858213892096_n;
            this.pictureBox1.Location = new System.Drawing.Point(84, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 550);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.GbMenu);
            this.Controls.Add(this.menuDead);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuDead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviousDead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.GbMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviousPaused)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Timer timerScore;
        private System.Windows.Forms.GroupBox GbMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbRestart;
        private System.Windows.Forms.PictureBox pbPreviousPaused;
        private System.Windows.Forms.GroupBox menuDead;
        private System.Windows.Forms.PictureBox pbPreviousDead;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbScoreDead;
        private System.Windows.Forms.Label label3;
    }
}

