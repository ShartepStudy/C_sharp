using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JPEGVIEW
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // AllowMerge - true - для возможности объединения меню
        }

        private void open1_Click(object sender, EventArgs e)
        {
            // вызываем обработчик пункта меню "open" главной формы
            (MdiParent as Form1).open1_Click(this, null);
        }

        private void close1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exit1_Click(object sender, EventArgs e)
        {
            MdiParent.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f = MdiParent as Form1;
            if (f.MdiChildren.Length == 1)
                f.window1.Visible = f.close2.Enabled = f.resize2.Enabled =
                    f.stretch2.Enabled = f.stretch2.Checked = false;
        }

        private void closeAll1_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiParent.MdiChildren)
                f.Close();
        }

        private void stretch1_CheckedChanged(object sender, EventArgs e)
        {
            /*
             PictureBoxSizeMode
             Normal - Изображение размещается в верхнем левом углу объекта PictureBox. 
                    Если изображение больше объекта PictureBox, в котором оно содержится, рисунок обрезается. 
            StretchImage Изображение в окне PictureBox вытягивается или сужается, чтобы в точности соответствовать размеру PictureBox. 
            AutoSize Размеры объекта PictureBox изменяются таким образом, чтобы в точности соответствовать изображению, которое в нем содержится. 
            CenterImage Если объект PictureBox больше изображения, изображение отображается в центре. Если изображение больше объекта PictureBox, 
                        рисунок размещается в центре PictureBox, а его внешние края обрезаются. 
            Zoom Размер изображения увеличивается или уменьшается, сохраняя пропорции размеров. 
            */
            if (stretch1.Checked)
            {
                // растянем pictureBox1 по форме
                pictureBox1.Dock = DockStyle.Fill;
                // включим режим масштабирования изображения с сохранением пропорций
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pictureBox1.Dock = DockStyle.None;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            (MdiParent as Form1).stretch2.Checked = stretch1.Checked;
        }

        internal void resize1_Click(object sender, EventArgs e)
        {
            // корректировка размера дочерней формы под размер картинки
            Size sz = ClientSize;
            if (stretch1.Checked)
            {
                int iw = pictureBox1.Image.Width,
                    ih = pictureBox1.Image.Height,
                    cw = ClientSize.Width,
                    ch = ClientSize.Height;
                double x = cw / (double)iw,
                    y = ch / (double)ih;
                if (x < y)
                    sz.Height = (int)(x * ih);
                else
                    sz.Width = (int)(y * iw);
            }
            else
                sz = pictureBox1.Size;
            ClientSize = sz;
        }

        private void resizeAll1_Click(object sender, EventArgs e)
        {
            //LayoutMdi - располагает дочерние MDI-формы внутри родительской MDI-формы.
            MdiParent.LayoutMdi(MdiLayout.Cascade);
            foreach (Form2 f in MdiParent.MdiChildren)
                f.resize1_Click(f, null);
        }

        private void Form2_Enter(object sender, EventArgs e)
        {
            (MdiParent as Form1).stretch2.Checked = stretch1.Checked;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers != Keys.Control)
                return;
            Point p = AutoScrollPosition;
            Size s = pictureBox1.Size;
            p.X = -p.X;
            p.Y = -p.Y;
            switch (e.KeyCode)
            {
                case Keys.Up:
                    p -= new Size(0, 10); break;
                case Keys.Down:
                    p += new Size(0, 10); break;
                case Keys.Left:
                    p -= new Size(10, 0); break;
                case Keys.Right:
                    p += new Size(10, 0); break;
                case Keys.Home:
                    p = Point.Empty; break;
                case Keys.End:
                    p = new Point(s); break;
            }
            AutoScrollPosition = p;
        }
    }
}
