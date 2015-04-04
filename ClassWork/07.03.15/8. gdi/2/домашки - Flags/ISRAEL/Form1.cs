using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISRAEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush br = new SolidBrush(Color.Blue);
            g.FillRectangle(br, 0, 10, 500, 25);
            g.FillRectangle(br, 0, 230, 500, 25);
            
            Point[] points = {new Point(250, 50), new Point(175, 175), new Point(325, 175)};
            Point[] points1 = { new Point(250, 215), new Point(175, 85), new Point(325, 85) };
            e.Graphics.DrawPolygon(new Pen(Color.Blue,10f),points);
            e.Graphics.DrawPolygon(new Pen(Color.Blue, 10f), points1);
            g.Dispose();
        }

    }
}
