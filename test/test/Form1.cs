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
        public Form1()
        {
            InitializeComponent();
            Image imgStone = Image.FromFile(Application.StartupPath + @"\image\stoneFinal.png");
            obs = new Obstacles(this.Controls, imgStone, this.ClientRectangle);
            picBoxPlayer.SendToBack();

            this.picBoxPlayer.Visible = false;
            //human
            Image imgHuman = Image.FromFile(Application.StartupPath + @"\image\boyFinal.png");
            human = new Human(imgHuman, this.Controls, this.ClientRectangle);

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            obs.Run();
            if (obs.isCollision(this.human.getHuman))
            {
                timer1.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            human.jump(); 
        }
    }
}
