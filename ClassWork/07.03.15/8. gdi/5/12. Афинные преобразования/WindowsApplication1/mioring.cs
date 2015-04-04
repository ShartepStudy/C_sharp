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
    public partial class mioring : Form
    {
        public mioring()
        {
            InitializeComponent();
            Image im1 = new Bitmap(this.GetType(), "tiger.bmp");
            this.Width = 200;
            this.Height = 300;
            Image im2 = new Bitmap(500, 500);
            Graphics gr = Graphics.FromImage(im2);
            gr.Clear(Color.White);
            pictureBox1.Image = im2;
            // TranslateTransform изменяет начало координат координатной системы путем добавления заданного сдвига к матрице преобразования данного объекта Graphics.
            gr.TranslateTransform(100.0f, 100.0f, MatrixOrder.Append);
            gr.DrawImage(im1, new Rectangle(0, 0, 80, 80), new Rectangle(0, 0, 80, 80), GraphicsUnit.Pixel);
            Matrix myMatrix1 = new Matrix(1, 0, 0, -1, 0, 0); // отражение относительно оси X
            gr.Transform = myMatrix1; // применяем аффинное преобразование к объекту Graphics
            gr.TranslateTransform(100.0f, 100.0f, MatrixOrder.Append);
            gr.DrawImage(im1, new Rectangle(0, 0, 80, 80), new Rectangle(0, 0, 80, 80), GraphicsUnit.Pixel);
            Matrix myMatrix2 = new Matrix(-1, 0, 0, 1, 0, 0); // отражение относительно оси Y
            gr.Transform = myMatrix2; // применяем аффинное преобразование к объекту Graphics
            gr.TranslateTransform(100.0f, 100.0f, MatrixOrder.Append);
            gr.DrawImage(im1, new Rectangle(0, 0, 80, 80), new Rectangle(0, 0, 80, 80), GraphicsUnit.Pixel);
            Matrix myMatrix3 = new Matrix(-1, 0, 0, -1, 0, 0); // отражение относительно оси Y
            gr.Transform = myMatrix3; // применяем аффинное преобразование к объекту Graphics
            gr.TranslateTransform(100.0f, 100.0f, MatrixOrder.Append); // зеркальное отражение
            gr.DrawImage(im1, new Rectangle(0, 0, 80, 80), new Rectangle(0, 0, 80, 80), GraphicsUnit.Pixel);
            gr.Dispose();
        }
    }
}