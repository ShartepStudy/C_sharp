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
    public partial class Scale : Form
    {
        public Scale()
        {
            InitializeComponent();
            Image im1 = new Bitmap(this.GetType(), "tiger.bmp");
            this.Width = 200;
            this.Height = 300;
            Image im2 = new Bitmap(500, 500);
            Graphics g2 = Graphics.FromImage(im2);
            g2.Clear(Color.White);
            pictureBox1.Image = im2;
            g2.DrawImage(im1, new Rectangle(0, 0, 80, 80), new Rectangle(0, 0, 80, 80), GraphicsUnit.Pixel); 
            Matrix myMatrix1 = new Matrix();
            // Scale применяет указанный вектор масштабирования к объекту Matrix
            myMatrix1.Scale(0.5f, 0.5f);
            g2.Transform = myMatrix1; // применяем аффинное преобразование к объекту Graphics
            g2.DrawImage(im1, new Rectangle(200, 0, 80, 80), new Rectangle(0, 0, 80, 80), GraphicsUnit.Pixel);
            Matrix myMatrix2 = new Matrix();
            myMatrix2.Scale(2, 2);
            g2.Transform = myMatrix2;
            g2.DrawImage(im1, new Rectangle(0, 50, 80, 80), new Rectangle(0, 0, 80, 80), GraphicsUnit.Pixel);
            g2.Dispose();
        }
    }
}