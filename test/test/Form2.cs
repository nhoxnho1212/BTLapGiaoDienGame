using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new test.Form1();
            frm1.Show();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowRanking()
        {
            gBRanking.Visible = true;
            gBRanking.Enabled = true;
            pictureBox10.Visible = true;
            pictureBox10.Enabled = true;
            backRanking.Enabled = true;
            backRanking.Visible = true;
            loadRanking();
        }
        private void HideRanking()
        {
            gBRanking.Visible = false;
            gBRanking.Enabled = false;
            pictureBox10.Visible = false;
            pictureBox10.Enabled = false;
            backRanking.Enabled = false;
            backRanking.Visible = false;
        }


        private void loadRanking()
        {
            //read file score
            List<int> Score;
            String fileScore_path = Application.StartupPath + @"\Score.txt";
            FileStream fs = new FileStream(fileScore_path, FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            string[] lines = rd.ReadToEnd().Split('\n');
            fs.Close();
            Score = new List<int>();
            foreach (String l in lines)
            {
                if (l != "")
                {
                    int sc = int.Parse(l.Split('\r')[0]);
                    Score.Add(sc);
                }
            }
            Score.Sort();
            Score.Reverse();
            rank1.Text = Score[0].ToString();
            rank2.Text = Score[1].ToString();
            rank3.Text = Score[2].ToString();
            rank4.Text = "4.  "+Score[3].ToString();
            rank5.Text = "5.  " + Score[4].ToString();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            ShowRanking();
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            HideRanking();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new test.Form3();
            frm3.Show();
        }
    }
}
