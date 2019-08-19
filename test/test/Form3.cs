using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Pic2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addPicture();
            KhoiTao();
            lbXWin.Text =s1.ToString();
            lbOWin.Text =s2.ToString();
            lbDraws.Text = "Draws: " + sd;
        }
        Point pointPic = new Point();
        List<PictureBox> a, b;
        PictureBox pic;
        PictureBox[] listPics;

        public string s;
        public int player;
        public int turns;
        public int s1 = 0, s2 = 0, sd = 0;

        
        List<PictureBox> listPics2 = new List<PictureBox>();
        PictureBox p1, p2, p3;
        void KhoiTao()
        {
            DisablePlayer(true, true);
            DisablePlayer(true, false);
            player = -1;
            turns = 0;
            lbXWin.Text =s1.ToString();
            lbOWin.Text =s2.ToString();
            
            lbDraws.Text = "Draws: " + sd;
            pic00.Tag = pic00.Tag = pic01.Tag = pic02.Tag = pic10.Tag = 
                pic11.Tag = pic12.Tag = pic20.Tag = pic21.Tag = pic22.Tag = "";

            //Khoi tao vi tri ban dau cua cac PicturexBox

            picX0.Visible = picX1.Visible = picX2.Visible = picX3.Visible = picX4.Visible
                = picO0.Visible = picO1.Visible = picO2.Visible = picO3.Visible = picO4.Visible = true;

            picX0.Location = new Point(90, 240);
            picX1.Location = new Point(picX0.Left + picX0.Width*3, 240);
            picX2.Location = new Point(60, 280);
            picX3.Location = new Point(picX2.Left + picX0.Width * 3, 280);
            picX4.Location = new Point(picX3.Left + picX0.Width * 3, 280);
            picO0.Location = new Point(465, 240);
            picO1.Location = new Point(picO0.Left + picX0.Width * 3, 240);
            picO2.Location = new Point(435, 280);
            picO3.Location = new Point(picO2.Left + picX0.Width * 3, 280);
            picO4.Location = new Point(picO3.Left + picX0.Width * 3, 280);

            Image img = Image.FromFile(Application.StartupPath + @"\image\" + "pinkBG.png");
            pic00.Image = pic01.Image = pic02.Image
            = pic10.Image = pic11.Image = pic12.Image
            = pic20.Image = pic21.Image = pic22.Image = img;
           
        }

        void addPicture()
        {
            List<PictureBox> arrPic = new List<PictureBox>();

            listPics = new PictureBox[10]{picX0, picX1, picX2, picX3, picX4,
                picO0, picO1, picO2, picO3, picO4};

            foreach (var i in listPics)
            {
                i.MouseDown += Pic_MouseDown;
                i.MouseUp += Pic_MouseUp;
                i.MouseMove += Pic_MouseMove;
            }
        }

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            pointPic = e.Location;
        }
        bool isX =true;

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            //Them vao PicturexBox
            if (p.Top >= pic00.Top && p.Left >= pic00.Left &&
                p.Left + p.Width <= pic00.Right && p.Top + p.Height <= pic00.Bottom)
            {
                pic00.Image = p.Image;
                p.Visible = false;
                if (p.Tag == "X")
                    pic00.Tag = "X";
                else
                    pic00.Tag = "Y";
                turns++;
                player++;
               SetPopPlayer(p);
            }
            else if (p.Top >= pic01.Top && p.Left >= pic01.Left &&
                p.Left + p.Width <= pic01.Right && p.Top + p.Height <= pic01.Bottom)
            {
                pic01.Image = p.Image;
                p.Visible = false;
                if (p.Tag == "X")
                    pic01.Tag = "X";
                else
                    pic01.Tag = "Y";
                turns++;
                player++;
                SetPopPlayer(p);
            }
            else if (p.Top >= pic02.Top && p.Left >= pic02.Left &&
                p.Left + p.Width <= pic02.Right && p.Top + p.Height <= pic02.Bottom)
            {
                pic02.Image = p.Image;
                p.Visible = false;
                if (p.Tag == "X")
                    pic02.Tag = "X";
                else
                    pic02.Tag = "Y";
                turns++;
                player++;
                SetPopPlayer(p);
            }
            else if (p.Top >= pic10.Top && p.Left >= pic10.Left &&
                p.Left + p.Width <= pic10.Right && p.Top + p.Height <= pic10.Bottom)
            {
                pic10.Image = p.Image;
                p.Visible = false;
                if (p.Tag == "X")
                    pic10.Tag = "X";
                else
                    pic10.Tag = "Y";
                turns++;
                player++;
                SetPopPlayer(p);
            }
            else if (p.Top >= pic11.Top && p.Left >= pic11.Left &&
                p.Left + p.Width <= pic11.Right && p.Top + p.Height <= pic11.Bottom)
            {
                pic11.Image = p.Image;
                p.Visible = false;
                if (p.Tag == "X")
                    pic11.Tag = "X";
                else
                    pic11.Tag = "Y";
                turns++;
                player++;
                SetPopPlayer(p);
            }
            else if (p.Top >= pic12.Top && p.Left >= pic12.Left &&
                p.Left + p.Width <= pic12.Right && p.Top + p.Height <= pic12.Bottom)
            {
                pic12.Image = p.Image;
                p.Visible = false;
                if (p.Tag == "X")
                    pic12.Tag = "X";
                else
                    pic12.Tag = "Y";
                turns++;
                player++;
                SetPopPlayer(p);
            }
            else if (p.Top >= pic20.Top && p.Left >= pic20.Left &&
                p.Left + p.Width <= pic20.Right && p.Top + p.Height <= pic20.Bottom)
            {
                pic20.Image = p.Image;
                p.Visible = false;
                if (p.Tag == "X")
                    pic20.Tag = "X";
                else
                    pic20.Tag = "Y";
                turns++;
                player++;
                SetPopPlayer(p);
            }
            else if (p.Top >= pic21.Top && p.Left >= pic21.Left &&
                p.Left + p.Width <= pic21.Right && p.Top + p.Height <= pic21.Bottom)
            {
                pic21.Image = p.Image;
                p.Visible = false;
                if (p.Tag == "X")
                    pic21.Tag = "X";
                else
                    pic21.Tag = "Y";
                turns++;
                player++;
               SetPopPlayer(p);
            }
            else if (p.Top >= pic22.Top && p.Left >= pic22.Left &&
                p.Left + p.Width <= pic22.Right && p.Top + p.Height <= pic22.Bottom)
            {
                pic22.Image = p.Image;
                p.Visible = false;
                if (p.Tag == "X")
                    pic22.Tag = "X";
                else
                    pic22.Tag = "Y";
                turns++;
                player++;
                SetPopPlayer(p);
            }
  

            if (p.Tag != "") //Chi xet cac phan tu khac rong
                {
                //turns++;
                if ((CheckDraw() == true) && (CheckWinner() == false))
                {
                    MessageBox.Show("Tie game!");
                    sd++;
                    KhoiTao();
                }

                if (CheckWinner() == true)
                {
                    if (p.Tag == "X")
                    {
                        MessageBox.Show("X won!");
                        s1++;
                        KhoiTao();
                    }
                    else
                    {
                        MessageBox.Show("O won!");
                        s2++;
                        KhoiTao();
                    }

                }
            }
        }

        private void SetPopPlayer(PictureBox p)
        {
            DisablePlayer(false, true);
            DisablePlayer(false, false);
            if (p.Tag.Equals((isX) ? "X" : "Y"))
            {
                DisablePlayer(true, false);
                DisablePlayer(false, true);
            }
            else
            {
                DisablePlayer(true, true);
                DisablePlayer(false, false);
            }
        }

        private void DisablePlayer(bool pop,bool isX)
        {
            if (isX)
            {
                picX0.Enabled = pop;
                picX1.Enabled = pop;
                picX2.Enabled = pop;
                picX3.Enabled = pop;
                picX4.Enabled = pop;
            } else
            {
                picO0.Enabled = pop;
                picO1.Enabled = pop;
                picO2.Enabled = pop;
                picO3.Enabled = pop;
                picO4.Enabled = pop;
            }
            
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form2 frm2 = new test.Form2();
            frm2.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (var i in listPics2)
            {
                i.Visible = false;
            }
        }

        //Timer chạy chữ
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbTip.Text = lbTip.Text.Substring(1) + lbTip.Text.Substring(0, 1);
        }

        //3 buttons New game, Reset, Exit
        private void pbNG_Click(object sender, EventArgs e)
        {
            KhoiTao();
        }
        private void pbRS_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            KhoiTao();
        }

        private void pbEX_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new test.Form2();
            frm2.Show();
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            int dx, dy;
            PictureBox i = (PictureBox)sender;

            if (e.Button == MouseButtons.Left)
            {
                dx = e.X - pointPic.X;
                dy = e.Y - pointPic.Y;
                i.Left += dx;
                i.Top += dy;
            }
        }

        //Check Winner
        bool CheckWinner()
        {
            // check dong
            if ((pic00.Tag == pic01.Tag) && (pic01.Tag == pic02.Tag)
                && pic00.Tag != "")
                return true;
            else if ((pic10.Tag == pic11.Tag) && (pic11.Tag == pic12.Tag)
                && pic10.Tag != "")
                return true;
            else if ((pic20.Tag == pic21.Tag) && (pic21.Tag == pic22.Tag)
                && pic20.Tag != "")
                return true;
            
            // check cot

            if ((pic00.Tag == pic10.Tag) && (pic10.Tag == pic20.Tag)
                && pic00.Tag != "")
                return true;
            else if ((pic01.Tag == pic11.Tag) && (pic11.Tag == pic21.Tag)
                && pic01.Tag != "")
                return true;
            else if ((pic02.Tag == pic12.Tag) && (pic12.Tag == pic22.Tag)
                && pic02.Tag != "")
                return true;
            
            // check cheo

            if ((pic00.Tag == pic11.Tag) && (pic11.Tag == pic22.Tag)
                && pic00.Tag != "")
                return true;
            else if ((pic02.Tag == pic11.Tag) && (pic11.Tag == pic20.Tag)
                && pic02.Tag != "")
                return true;
            else
                return false;
        }

        //Check Draw
        bool CheckDraw()
        {
            if (turns == 9)
                return true;
            else
                return false;
        }
    }
}
