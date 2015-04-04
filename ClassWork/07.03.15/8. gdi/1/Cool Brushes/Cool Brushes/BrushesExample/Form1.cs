using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BrushesExample
{
    public partial class Form1 : Form
    {
        static HatchStyle hs = HatchStyle.Divot;
        static HatchBrush htchBrush = new HatchBrush(hs, Color.Blue);
        static Rectangle rect = new Rectangle(20, 20, 200, 200);
        static Rectangle rect2 = new Rectangle(240, 20, 200, 200);
        static float angle = 45f;
        static float speed = 4.345f;
        static LinearGradientBrush lgBrush;
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            lgBrush = new LinearGradientBrush(rect, Color.Red, Color.Blue, angle);
            g.FillRectangle(lgBrush, rect);

            g.FillRectangle(htchBrush, rect2);

            // g.Dispose(); // убираем! включена двойная буферизация!
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                hs++;
                if (hs > HatchStyle.SolidDiamond) hs = HatchStyle.Min;
                htchBrush = new HatchBrush(hs, Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)), Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
                this.Refresh();
            }

            else if (e.KeyData == Keys.Down)
            {
                hs--;
                if (hs < HatchStyle.Min) hs = HatchStyle.SolidDiamond;
                htchBrush = new HatchBrush(hs, Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)), Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
                this.Refresh();
            }

            else if (e.KeyData == Keys.Right)
            {
                angle += speed;
                this.Refresh();
            }

            else if (e.KeyData == Keys.Left)
            {
                angle -= speed * 2;
                this.Refresh();
            }
        }
    }
}
