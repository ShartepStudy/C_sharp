using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PointInRegion
{
    public partial class Form1 : Form
    {
        Point point = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            Region region1 = new Region(new Rectangle(50, 0, 50, 150));
            Region region2 = new Region(new Rectangle(0, 50, 150, 50));

            region1.Union(region2);

            if (region1.IsVisible(point, e.Graphics))
            {
                solidBrush.Color = Color.FromArgb(255, 255, 0, 0);
            }
            else
            {
                solidBrush.Color = Color.FromArgb(64, 255, 0, 0);
            }

            e.Graphics.FillRegion(solidBrush, region1);

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
            Invalidate();
        }
    }
}
