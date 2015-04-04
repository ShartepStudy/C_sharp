using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace HypnoBall
{
    public partial class Form1 : Form
    {
        Timer tm = new Timer();

        Image img = null;
        public Form1()
        {
            InitializeComponent();
            tm.Interval = 50;
            tm.Tick += new EventHandler(tm_Tick);
            tm.Start();
            this.DoubleBuffered = true;

            img = Image.FromFile(@"Image\HypnoBall.bmp");

            this.BackColor = Color.White;
        }

        void tm_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
            angle += 0.1F;
        }

        float angle = 0;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int W = img.Width;
            int H = img.Height;

            int R = (int)Math.Sqrt(Math.Pow(W / 2, 2) + Math.Pow(H / 2, 2));

            Graphics gr = e.Graphics;

            System.Drawing.Drawing2D.Matrix mat = new System.Drawing.Drawing2D.Matrix();

            float degrees = (float)(180 * angle / Math.PI);

            Point PtLoc = new Point(0, 0);
            mat.RotateAt(degrees, new PointF(PtLoc.X + W / 2, PtLoc.Y + H / 2));


            e.Graphics.Transform = mat;

            e.Graphics.DrawImage(img, 0,0, W,H);
            
            
        }
    }
}
