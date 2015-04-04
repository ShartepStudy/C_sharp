using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Iamge
{
    public partial class Form1 : Form
    {
        private Image img1, img2;
        int x, y, w, h;
        Region region;

        int dx, dy;

        private Timer timer;
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            img1 = Image.FromFile(@"C:\1\1.jpg");
            img2 = Image.FromFile(@"C:\1\2.jpg");

            x = 0;
            y = 0;
            w = 1;
            h = 1;

            dx = ClientSize.Width / 2;
            dy = ClientSize.Height / 2;

            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 15;
            timer.Start();

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            region = new Region(path);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            func1();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img1, 0, 0, this.ClientSize.Width, this.ClientSize.Height);
        }

        void func1()
        {
            // if (w >= ClientSize.Width || h >= ClientSize.Height) { timer.Stop(); return; }

            x -= 1;
            y -= 1;
            w += 2;
            h += 2;

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(x + dx, y + dy, w, h);
            Region reg = new Region(path);

            Graphics g = CreateGraphics();
            g.Clip = reg;
            g.DrawImage(img2, 0, 0, this.ClientSize.Width, this.ClientSize.Height);
            g.Dispose();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            dx = ClientSize.Width / 2;
            dx = ClientSize.Height / 2;
            Invalidate();
        }
    }
}
