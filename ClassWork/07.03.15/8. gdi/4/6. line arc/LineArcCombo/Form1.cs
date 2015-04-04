using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LineArcCombo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grfx = e.Graphics;
            Pen pen = new Pen(Color.Black, 25);

            //grfx.DrawLine(pen, 25, 100, 125, 100);
            //grfx.DrawArc(pen, 125, 50, 100, 100, -180, 180);
            //grfx.DrawLine(pen, 225, 100, 325, 100);

            GraphicsPath path = new GraphicsPath();

            path.AddLine(25, 100, 125, 100);
            path.AddArc(125, 50, 100, 100, -180, 180);
            path.AddLine(225, 100, 325, 100);

            grfx.DrawPath(pen, path);
        }
    }
}
