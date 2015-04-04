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
    public partial class Rotate : Form
    {
        public Rotate()
        {
            InitializeComponent();
            Image im1 = new Bitmap(this.GetType(), "tiger.bmp");
            this.Width = 200;
            this.Height = 300;
            Image im2 = new Bitmap(500, 500);
            Graphics gr = Graphics.FromImage(im2);
            gr.Clear(Color.White);
            pictureBox1.Image = im2;
            gr.DrawImage(im1, new Rectangle(0, 0, 80, 80), new Rectangle(0, 0, 80, 80), GraphicsUnit.Pixel);
            Matrix myMatrix1 = new Matrix();
            // Rotate применяет поворот по часовой стрелке на указанный угол вокруг начала координат к этому объекту Matrix.
            myMatrix1.Rotate(30);
            gr.Transform = myMatrix1; // применяем аффинное преобразование к объекту Graphics
            gr.DrawImage(im1, new Rectangle(100, 100, 80, 80), new Rectangle(0, 0, 80, 80), GraphicsUnit.Pixel);
            Matrix myMatrix2 = new Matrix();
            myMatrix2.Rotate(-30);
            gr.Transform = myMatrix2;
            gr.DrawImage(im1, new Rectangle(50, 100, 80, 80), new Rectangle(0, 0, 80, 80), GraphicsUnit.Pixel);
            gr.Dispose();
        }
    }
}