using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butScreenCapture_Click(object sender, EventArgs e)
        {
            // ��������� ������� ������
            Bitmap screenPicture = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                 Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(screenPicture))
            {
                // �������� ����������� ����� ������
                g.CopyFromScreen(0, 0, 0, 0, screenPicture.Size);
            }
            pictureBox1.Image = screenPicture;
            screenPicture.Save("Screen.jpg", ImageFormat.Jpeg);

            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            /*
             public void DrawToBitmap(
	                Bitmap bitmap, // �������� �������, ������� ��������� ����������.
	                Rectangle targetBounds // �������, � ������� ����������� ������������ �������� ����������.
                )
             */
            // ������� ����������� �����
            this.DrawToBitmap(bitmap, new System.Drawing.Rectangle(new Point(0, 0), this.Size));
            bitmap.Save("Screen2.jpg", ImageFormat.Jpeg);// ��������� ������ Image � ��������� ���� � ��������� �������.
            bitmap.Dispose();
            // ������� ����������� ������
            Bitmap bitmap2 = new Bitmap(this.Width, this.Height);
            butScreenCapture.DrawToBitmap(bitmap2, new System.Drawing.Rectangle(new Point(0, 0), butScreenCapture.Size));
            bitmap2.Save("Screen3.jpg", ImageFormat.Jpeg);// ��������� ������ Image � ��������� ���� � ��������� �������.
            bitmap2.Dispose();

        }

    }
}