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
            this.GbMenu = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbRestart = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuDead = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.GbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuDead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.lbScore.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbScore.Image = global::test.Properties.Resources._68751574_1359923060849258_1563932063604670464_n1;
            this.lbScore.Location = new System.Drawing.Point(847, 9);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(123, 57);
            this.lbScore.TabIndex = 0;
            this.lbScore.Text = "0";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerScore
            // 
            this.timerScore.Enabled = true;
            this.timerScore.Tick += new System.EventHandler(this.TimerScore_Tick);
            // 
            // GbMenu
            // 
            this.GbMenu.BackColor = System.Drawing.Color.Transparent;
            this.GbMenu.BackgroundImage = global::test.Properties.Resources._68452099_535109210650034_728312125667147776_n;
            this.GbMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GbMenu.Controls.Add(this.pictureBox2);
            this.GbMenu.Controls.Add(this.pbRestart);
            this.GbMenu.Controls.Add(this.pictureBox1);
            this.GbMenu.Location = new System.Drawing.Point(324, 45);
            this.GbMenu.Name = "GbMenu";
            this.GbMenu.Size = new System.Drawing.Size(339, 472);
            this.GbMenu.TabIndex = 1;
            this.GbMenu.TabStop = false;
            this.GbMenu.Enter += new System.EventHandler(this.GbMenu_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::test.Properties.Resources._68439902_417049765664628_7636492005937250304_n;
            this.pictureBox2.Location = new System.Drawing.Point(118, 344);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pbRestart_Click);
            // 
            // pbRestart
            // 
            this.pbRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRestart.Image = global::test.Properties.Resources._68461705_2353676068002203_4348747575105421312_n;
            this.pbRestart.Location = new System.Drawing.Point(118, 211);
            this.pbRestart.Name = "pbRestart";
            this.pbRestart.Size = new System.Drawing.Size(110, 98);
            this.pbRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRestart.TabIndex = 0;
            this.pbRestart.TabStop = false;
            this.pbRestart.Click += new System.EventHandler(this.pbRestart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::test.Properties.Resources._67974059_725468641259549_3153716858213892096_n;
            this.pictureBox1.Location = new System.Drawing.Point(118, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // menuDead
            // 
            this.menuDead.BackColor = System.Drawing.Color.Transparent;
            this.menuDead.BackgroundImage = global::test.Properties.Resources._68452099_535109210650034_728312125667147776_n;
            this.menuDead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuDead.Controls.Add(this.pictureBox3);
            this.menuDead.Controls.Add(this.pictureBox4);
            this.menuDead.Enabled = false;
            this.menuDead.Location = new System.Drawing.Point(199, 142);
            this.menuDead.Name = "menuDead";
            this.menuDead.Size = new System.Drawing.Size(603, 267);
            this.menuDead.TabIndex = 1;
            this.menuDead.TabStop = false;
            this.menuDead.Visible = false;
            this.menuDead.Enter += new System.EventHandler(this.GbMenu_Enter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::test.Properties.Resources._68439902_417049765664628_7636492005937250304_n;
            this.pictureBox3.Location = new System.Drawing.Point(355, 84);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(110, 98);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pbRestart_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::test.Properties.Resources._68461705_2353676068002203_4348747575105421312_n;
            this.pictureBox4.Location = new System.Drawing.Point(127, 84);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(110, 98);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pbRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 550);
            this.Controls.Add(this.menuDead);
            this.Controls.Add(this.GbMenu);
            this.Controls.Add(this.lbScore);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.GbMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuDead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Timer timerScore;
        private System.Windows.Forms.GroupBox GbMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbRestart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox menuDead;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

