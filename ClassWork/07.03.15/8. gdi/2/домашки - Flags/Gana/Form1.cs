using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void DrawStar(Graphics g, float r, float xc, float yc, Color clr)
        {
            // r: determines the size of the star.
            // xc, yc: determine the location of the star.
            float sin36 = (float)Math.Sin(36.0 * Math.PI / 180.0);
            float sin72 = (float)Math.Sin(72.0 * Math.PI / 180.0);
            float cos36 = (float)Math.Cos(36.0 * Math.PI / 180.0);
            float cos72 = (float)Math.Cos(72.0 * Math.PI / 180.0);
            float r1 = r * cos72 / cos36;
            // Fill the star:
            PointF[] pts = new PointF[10];
            pts[0] = new PointF(xc, yc - r);
            pts[1] = new PointF(xc + r1 * sin36, yc - r1 * cos36);
            pts[2] = new PointF(xc + r * sin72, yc - r * cos72);
            pts[3] = new PointF(xc + r1 * sin72, yc + r1 * cos72);
            pts[4] = new PointF(xc + r * sin36, yc + r * cos36);
            pts[5] = new PointF(xc, yc + r1);
            pts[6] = new PointF(xc - r * sin36, yc + r * cos36);
            pts[7] = new PointF(xc - r1 * sin72, yc + r1 * cos72);
            pts[8] = new PointF(xc - r * sin72, yc - r * cos72);
            pts[9] = new PointF(xc - r1 * sin36, yc - r1 * cos36);
            g.FillPolygon(new SolidBrush(clr), pts);
        }  
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush br = new SolidBrush(Color.DarkRed);
            g.FillRectangle(br, 0, 0, 500, 90);
            br = new SolidBrush(Color.Yellow);
            g.FillRectangle(br, 0, 90, 500, 90);
            br = new SolidBrush(Color.Green);
            g.FillRectangle(br, 0, 180, 500, 90);

            //Point[] points = { new Point(250, 90),new Point(262,125),new Point(300,125),new Point(268,141),new Point(280,180),new Point(250,150),new Point(220,180),new Point(232,141), new Point(200,125), new Point(238,125),        };
            //e.Graphics.FillPolygon(new SolidBrush(Color.Black), points);
            DrawStar(g, 50, 255, 139, Color.Black);
            g.Dispose();
        }
    }
}
