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
    public partial class Shear : Form
    {
        float koefX = 0, koefY = 0;
        bool x = true, y = true;
        Image im1, im2;
        Matrix myMatrix3;
        public Shear()
        {
            InitializeComponent();
            im1 = new Bitmap(this.GetType(), "tiger.bmp");
            this.WindowState = FormWindowState.Maximized;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            im2 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            if (x)
                koefX += 0.3f;
            else
                koefX -= 0.3f;
            if (y)
                koefY += 0.3f;
            else
                koefY -= 0.3f;
            Graphics gr = Graphics.FromImage(im2);
            gr.Clear(Color.White);
            pictureBox1.Image = im2;
            myMatrix3 = new Matrix();
            // Shear применяет указанный вектор сдвига к объекту Matrix
            myMatrix3.Shear(koefX, koefY, MatrixOrder.Append);
            gr.Transform = myMatrix3;// применяем аффинное преобразование к объекту Graphics
            // TranslateTransform изменяет начало координат координатной системы путем добавления заданного сдвига к матрице преобразования данного объекта Graphics.
            gr.TranslateTransform(700.0f, 500.0f, MatrixOrder.Append);
            gr.DrawImage(im1, new Rectangle(-40, -40, 80, 80), new Rectangle(0, 0, 80, 80), GraphicsUnit.Pixel);
            gr.Dispose();
            if (koefX <= 0)
                x = true;
            else if(koefX >= 12f)
                x = false;
            if (koefY <= 0)
                y = true;
            else if (koefY >= 12f)
                y = false;
        }
    }
}