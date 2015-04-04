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
    public partial class Rotate2 : Form
    {
        Image im1, im2;
        float alpha = 0;
        public Rotate2()
        {
            InitializeComponent();
            im1 = new Bitmap(this.GetType(), "tiger.bmp");
            this.Width = 300;
            this.Height = 300;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Image im2 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g2 = Graphics.FromImage(im2);
            g2.Clear(Color.White);
            pictureBox1.Image = im2;
            Matrix mtr = new Matrix();
            alpha += 3f;
            // Rotate применяет поворот по часовой стрелке на указанный угол вокруг начала координат к этому объекту Matrix.
            mtr.Rotate(alpha);
            g2.Transform = mtr; // применяем аффинное преобразование к объекту Graphics
            // TranslateTransform изменяет начало координат координатной системы путем добавления заданного сдвига к матрице преобразования данного объекта Graphics.
            g2.TranslateTransform(150.0f, 150.0f, MatrixOrder.Append);
            g2.DrawImage(im1, new Rectangle(-40, -40, 80, 80), new Rectangle(0, 0, 80, 80), GraphicsUnit.Pixel);
            g2.Dispose();
        }

       
    }
}