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
    class Human
    {
        private const int IMG_WIDTH = 84;
        private const int IMG_HEIGHT = 140;
        private static readonly Point IMG_LOCATION = new Point(95, 220);
        private PictureBox picBoxMainHuman;
        private Control.ControlCollection formControl;
        private Rectangle ClientRect;

        //make timer jumping
        Timer timeJump = new Timer();
        int maxDistance = IMG_LOCATION.Y - 150;
        Point tmplocationOfHumanWhenJump = IMG_LOCATION;
        bool isEndOfJumpDown = false;
        bool isFinishJump = true;
        //

        public PictureBox getHuman
        {
            get
            {
                return picBoxMainHuman;
            }
        }

        private PictureBox SetHumanProperty(PictureBox human, Image img)
        {
            human.Height = IMG_HEIGHT;
            human.Width = IMG_WIDTH;
            human.BackgroundImage = img;
            human.BackgroundImageLayout = ImageLayout.Stretch;
            human.Location = IMG_LOCATION;

            human.BackColor = Color.Transparent;
            human.Visible = true;
            return human;
        }

        private void setTimeJumpDefault()
        {
            timeJump.Tick += new EventHandler(timeJump_Ticker);
            timeJump.Interval = 1;
            timeJump.Enabled = true;
            timeJump.Stop();
        }

        public Human(Image img, Control.ControlCollection control, Rectangle rect)
        {
            this.formControl = control;
            this.ClientRect = rect;
            this.picBoxMainHuman = new PictureBox();
            this.picBoxMainHuman = SetHumanProperty(this.picBoxMainHuman, img);

            this.formControl.Add(this.picBoxMainHuman);

            setTimeJumpDefault();
        }

        public void jump()
        {
            if (isFinishJump)
            {
                timeJump.Start();
                isEndOfJumpDown = false;
                isFinishJump = false;
            }
        }

        private void timeJump_Ticker(object sender,EventArgs e)
        {
            if (isEndOfJumpDown == false)
            {
                if (tmplocationOfHumanWhenJump.Y > maxDistance)
                {
                    tmplocationOfHumanWhenJump.Y -= 5;
                    picBoxMainHuman.Location = tmplocationOfHumanWhenJump;
                }
                else
                {
                    isEndOfJumpDown = true;
                }
            }
            else
            {
                if (tmplocationOfHumanWhenJump.Y < IMG_LOCATION.Y)
                {
                    tmplocationOfHumanWhenJump.Y += 5;
                    picBoxMainHuman.Location = tmplocationOfHumanWhenJump;

                }
                else
                {
                    timeJump.Stop();
                    isFinishJump = true;
                }
            }
        }
    }
}
