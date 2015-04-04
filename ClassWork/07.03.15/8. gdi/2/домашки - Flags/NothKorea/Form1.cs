using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NothKorea
{
    public partial class Form1 : Form
    {
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush br = new SolidBrush(Color.Blue);
            g.FillRectangle(br, 0, 0, 500, 30);
            br = new SolidBrush(Color.Red);
            g.FillRectangle(br, 0, 37, 500, 190);
            br = new SolidBrush(Color.Blue);
            g.FillRectangle(br, 0, 233, 500, 30);
            br = new SolidBrush(Color.White);
            Rectangle rec = new Rectangle(50,45,170,170);
            g.FillEllipse(br,rec);

            DrawStar(g,84,135,130,Color.Red);
           
            
            g.Dispose();
        }
    }
}
