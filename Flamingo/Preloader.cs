using System;
using System.Drawing;
using System.Windows.Forms;

namespace Flamingo
{
    class Preloader : PictureBox
    {
        public Graphics graphics;
        public Bitmap bitmap;
        public Rectangle rectangle;

        private Pen pen;
        private int angleOne = 10;
        private int angleTwo = 30;
        private bool flag = true;
        private Timer timer1, timer2;
        private float step = 0;
        private Color currentColor = Color.DarkGreen;
        private Color targetColor = Color.LightBlue;
        private Random rnd = new Random();
        private Size size;

        public Preloader(Size clientSize, Control parent):base()
        {
            size = clientSize;
            this.Parent = parent;
            rectangle = new Rectangle(clientSize.Width / 2 - (int)Math.Round(clientSize.Height * 0.25 / 2), clientSize.Height / 2 - (int)Math.Round(clientSize.Height * 0.25 / 2), (int)(clientSize.Height * 0.25), (int)(clientSize.Height * 0.25));
            pen = new Pen(Color.Red, 7);
            Width = clientSize.Width;
            Height = clientSize.Height-16;
            bitmap = new Bitmap(clientSize.Width, clientSize.Height);
            Image = bitmap;
            graphics = Graphics.FromImage(bitmap);

            timer1 = new Timer();
            timer2 = new Timer();
            timer1.Interval = 20;
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick;
            timer2.Interval = 1;
            timer2.Enabled = true;
            timer2.Tick += Timer2_Tick;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (step >= 1f)
            {
                step = 0;

                int R = rnd.Next(0, 255);
                int G = rnd.Next(0, 255);
                int B = rnd.Next(0, 255);
                currentColor = targetColor;
                targetColor = Color.FromArgb(R, G, B);
            }
            int mixR = (int)(currentColor.R * (1f - step) + targetColor.R * step);
            int mixG = (int)(currentColor.G * (1f - step) + targetColor.G * step);
            int mixB = (int)(currentColor.B * (1f - step) + targetColor.B * step);
            pen = new Pen(Color.FromArgb(mixR, mixG, mixB), 12);

            step += 0.03f;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            graphics.DrawArc(pen, rectangle, angleOne, angleTwo);
            Invalidate();
            if (flag)
            {
                angleTwo = (angleTwo + 2) % 360;
                angleOne = (angleOne + 2) % 360;
                flag = (angleTwo % 360 == 0) ? false : true;
            }
            else
            {
                angleTwo = (angleTwo - 2) % 360;
                angleOne = (angleOne - 2) % 360;
                flag = (angleTwo % 360 == 0) ? true : false;
            }
        }
    }
}
