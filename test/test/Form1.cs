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
    public partial class Form1 : Form
    {
        Obstacles obs;
        Human human;
        Image imgStone = Image.FromFile(Application.StartupPath + @"\image\stoneFinal.png");
        Image imgWooden= Image.FromFile(Application.StartupPath + @"\image\woodenFinal.png");
        Image imgHuman = Image.FromFile(Application.StartupPath + @"\image\boyFinal.png");
        Image imgBird = Image.FromFile(Application.StartupPath + @"\image\bird.gif");
        bool isBird = false;
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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            obs.Run();
            if (obs.isCollision(this.human.getHuman))
            {
                timer1.Stop();
            }
            if (obs.isOutofForm())
            {
                
                Random random = new Random();
                isBird = (random.Next(0, 2) == 0) ? false : true;
                if (isBird)
                {
                    obs.SetProperty(100, 200,100, imgBird,"bird");
                    obs.SetDefaultProperty();
                }else
                {
                    Image img = (random.Next(0, 2) == 0) ? imgStone : imgWooden;
                    obs.setImg(img);
                    obs.SetDefaultProperty();
                }
                
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            human.jump(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            Image img = (random.Next(0, 2) == 0) ? imgStone : imgWooden;
            obs = new Obstacles(this.Controls, img, this.ClientRectangle);
            picBoxPlayer.SendToBack();

            this.picBoxPlayer.Visible = false;
            //human
            
            human = new Human(imgHuman, this.Controls, this.ClientRectangle);
        }
    }
}
