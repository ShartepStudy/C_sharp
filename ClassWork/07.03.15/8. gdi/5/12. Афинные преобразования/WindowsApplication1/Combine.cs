using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Combine : Form
    {
        Image im1, im2;
        float alpha = 0;
        public Combine()
        {
            InitializeComponent();
            this.Width = 640;
            this.Height = 480;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            im1 = new Bitmap(this.GetType(), "s023.jpg");
            im2 = new Bitmap(this.GetType(), "s004.jpg");
            pictureBox1.Image = im2;
            
            Graphics g = Graphics.FromImage(im2);
            Matrix mtr = new Matrix(1.0f, 0, (float)Math.Sin(alpha), (float)Math.Cos(alpha), 0, 0); // поворот
            alpha += 0.02f;
            g.Transform = mtr;
            // TranslateTransform изменяет начало координат координатной системы путем добавления заданного сдвига к матрице преобразования данного объекта Graphics.
            g.TranslateTransform(320.0f, 240.0f, MatrixOrder.Append);
            g.DrawImage(im1, new Rectangle(-320, -240, 640, 480), new Rectangle(0, 0, 640, 480), GraphicsUnit.Pixel);
            g.Dispose();
        }
    }
}