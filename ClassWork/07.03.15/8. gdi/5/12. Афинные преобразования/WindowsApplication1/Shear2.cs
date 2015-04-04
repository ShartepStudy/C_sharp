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
    public partial class Shear2 : Form
    {
        public Shear2()
        {
            InitializeComponent();
            Image im1 = new Bitmap(this.GetType(), "tiger.bmp");
            this.Width = 500;
            this.Height = 500;
            Image im2 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g2 = Graphics.FromImage(im2);
            g2.Clear(Color.White);
            pictureBox1.Image = im2;
            g2.DrawImage(im1, new Rectangle(0, 0, 80, 80), new Rectangle(0, 0, 80, 80), GraphicsUnit.Pixel);
            Matrix myMatrix1 = new Matrix();
            // Shear применяет указанный вектор сдвига к объекту Matrix
            myMatrix1.Shear(2, 0, MatrixOrder.Append); // сдвиг по оси X
            g2.Transform = myMatrix1;// применяем аффинное преобразование к объекту Graphics
            g2.DrawImage(im1, new Rectangle(100, 0, 80, 80), new Rectangle(0, 0, 80, 80), GraphicsUnit.Pixel);
            Matrix myMatrix2 = new Matrix();
            myMatrix2.Shear(0, 2, MatrixOrder.Append); // сдвиг по оси Y
            g2.Transform = myMatrix2;
            g2.DrawImage(im1, new Rectangle(100, 0, 80, 80), new Rectangle(0, 0, 80, 80), GraphicsUnit.Pixel);
            Matrix myMatrix3 = new Matrix();
            myMatrix3.Shear(2, 2, MatrixOrder.Append); // сдвиг по обеим осям
            g2.Transform = myMatrix3;
            g2.DrawImage(im1, new Rectangle(100, 50, 80, 80), new Rectangle(0, 0, 80, 80), GraphicsUnit.Pixel);
            g2.Dispose();
        }
    }
}