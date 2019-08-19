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
    public partial class Form1 : Form
    {
        Obstacles obs;
        Human human;
        Image imgStone = Image.FromFile(Application.StartupPath + @"\image\stoneFinal.png");
        Image imgWooden= Image.FromFile(Application.StartupPath + @"\image\woodenFinal.png");
        Image imgHuman = Image.FromFile(Application.StartupPath + @"\image\boyFinal.png");
        Image imgDuck = Image.FromFile(Application.StartupPath + @"\image\boyDucking.png");
        Image imgBird = Image.FromFile(Application.StartupPath + @"\image\bird.gif");
        String fileScore_path = Application.StartupPath + @"\Score.txt";
        List<int> Score;
        bool isBird = false;
        bool isPauseGame_keyDown = false;
        bool isPauseGame_keyUp = false;
        bool isDead = false;
        public Form1()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }
        private void Restart()
        {
            isDead = false;
            GbMenu.Enabled = false;
            GbMenu.Visible = false;
            isPauseGame_keyDown = false;
            isPauseGame_keyUp = false;
            timer1.Start();
            timer1.Interval = 50;
            timerScore.Start();
            lbScore.Text = "0";
            Random random = new Random();
            isBird = (random.Next(0, 2) == 0) ? false : true;
            if (isBird)
            {
                obs.SetProperty(80, 65, 175, imgBird, "bird");
                obs.SetDefaultProperty();
            }
            else
            {
                Image img = (random.Next(0, 2) == 0) ? imgStone : imgWooden;
                obs.setImg(img);
                obs.SetDefaultProperty();
            }
            menuDead.Visible = false;
            menuDead.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (isPauseGame_keyDown) return;

            obs.Run();
            if (obs.isCollision(this.human.getHuman))
            {
                timer1.Stop();
                timerScore.Stop();
                isDead = true;
                menuDead.Visible = true;
                menuDead.Enabled = true;
                lbScoreDead.Text = lbScore.Text;

                Score.Add(int.Parse(lbScore.Text));
                lbBestScore.Text = Score.Max().ToString();
                Score.Sort();
                Score.Reverse();
                
                using (StreamWriter fr = new StreamWriter(fileScore_path))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        try
                        {
                            fr.WriteLine(Score[i]);
                        }
                        catch
                        {
                            fr.WriteLine("0");
                        }
                    }
                }
            }
            if (obs.isOutofForm())
            {
                
                Random random = new Random();
                isBird = (random.Next(0, 2) == 0) ? false : true;
                if (isBird)
                {
                    obs.SetProperty(80, 65,175, imgBird,"bird");
                    obs.SetDefaultProperty();
                }else
                {
                    Image img = (random.Next(0, 2) == 0) ? imgStone : imgWooden;
                    obs.setImg(img);
                    obs.SetDefaultProperty();
                }
                if (timer1.Interval > 5)
                    timer1.Interval -= 5;
                else
                    timer1.Interval = 1;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode==Keys.Space)
            {
                human.jump();
            }
            if (e.KeyCode==Keys.Down)
            {
                human.duck_keyDown();
            }
            if (!isDead)
            {
                if (isPauseGame_keyUp )
                {
                    if (e.KeyCode == Keys.Escape)
                    {
                        isPauseGame_keyDown = !isPauseGame_keyDown;
                        isPauseGame_keyUp = false;
                        GbMenu.Enabled = !GbMenu.Enabled;
                        GbMenu.Visible = !GbMenu.Visible;

                    }
                }
                else
                {
                    if (e.KeyCode == Keys.Escape)
                    {
                        isPauseGame_keyDown = true;
                        GbMenu.Enabled = true;
                        GbMenu.Visible = true;
                        
                    }
                }
            }
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Random random = new Random();
            Image img = (random.Next(0, 2) == 0) ? imgStone : imgWooden;
            obs = new Obstacles(this.Controls, img, this.ClientRectangle);
          
            //human
            
            human = new Human(imgHuman, this.Controls, this.ClientRectangle);
            human.SetImgDuck(imgDuck);
            GbMenu.Enabled = false;
            GbMenu.Visible = false;
            
            //read file score
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

            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                human.duck_keyUp();
            }
            if (e.KeyCode==Keys.Escape)
            {
                isPauseGame_keyUp = true;
            }
        }

        private void TimerScore_Tick(object sender, EventArgs e)
        {
            if (isPauseGame_keyDown) return;
            lbScore.Text = (int.Parse(lbScore.Text) + 1).ToString();
        }

        private void BtnResume_Click(object sender, EventArgs e)
        {

        }

        private void GbMenu_Enter(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            isPauseGame_keyDown = false;
            isPauseGame_keyUp = false;
            GbMenu.Enabled = false;
            GbMenu.Visible = false;
        }

        private void pbRestart_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void LbScore_Click(object sender, EventArgs e)
        {

        }

        private void pbPrevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new test.Form2();
            frm2.Show();
        }

        private void LbBestScore_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form2 frm2 = new test.Form2();
            frm2.Show();
        }
    }
}
