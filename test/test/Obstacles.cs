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
    class Obstacles 
    {
        private const int IMG_WIDTH=80;
        private const int IMG_HEIGHT = 40;
        private const int IMG_TOP = 320;
        private const int DISTANCE = 15;
        private Rectangle ClientRect;
        private PictureBox obs;
        private Control.ControlCollection formControl;

        private PictureBox SetObstaclesProperty(PictureBox ob,Image img)
        {
            ob.Width = IMG_WIDTH;
            ob.Height = IMG_HEIGHT;
            ob.Image=img;
            ob.Top = IMG_TOP;
            ob.Left =ClientRect.Width;
            ob.SizeMode=PictureBoxSizeMode.StretchImage;
            ob.BackColor = Color.Transparent;
            ob.Visible = true;
            ob.Name = "stone";
            return ob;
            
        }

        public void setImg(Image image)
        {
            SetObstaclesProperty(obs, image);
        }
        public void SetDefaultProperty()
        {
            obs.Left = ClientRect.Width;
        }
        public void SetProperty(int width,int height,int top,Image image,String name)
        {
            this.obs.Width = width;
            obs.Height = height;
            obs.Image = image;
            obs.Name = name;
            obs.Top = top;
        }
        public Obstacles(Control.ControlCollection formControl,Image img,Rectangle ClientRect)
        {
            this.ClientRect = ClientRect;
            this.obs = new PictureBox();
            obs = SetObstaclesProperty(obs, img);
            this.formControl = formControl;
            this.formControl.Add(obs);

        }

        public void Run()
        {
            bool isOutForm = obs.Left < -this.obs.Width;
            if (!isOutForm)
                obs.Left -= DISTANCE;
        }
        public bool isCollision(PictureBox picBoxObject)
        {
            int missWidthOjectLeft = 0;
            int missWidthOjectRight = 0;

            //int missWidthObstacleTop = 50;
            //int missWidthObstacleBottom = 40;

            bool isInObjectHorizon = ((picBoxObject.Left + picBoxObject.Width-missWidthOjectLeft) >= this.obs.Left) 
                                    && ((this.obs.Left+this.obs.Width) >= picBoxObject.Left +missWidthOjectRight);

            bool isInObjectVector = ((picBoxObject.Top + picBoxObject.Height) >= this.obs.Top)
                                    && ((this.obs.Top + this.obs.Height) >= picBoxObject.Top);

            return isInObjectVector && isInObjectHorizon;
        }
        public bool isOutofForm()
        {
            if (obs.Right < 0) return true;
            if (obs.Left > ClientRect.Width) return true;
            return false;
        }
    }
}
