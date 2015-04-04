using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;


namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        // загружаем изображение из файла
        Image im1 = new Bitmap(@"C:\1\1.jpg");
        Image im2 = new Bitmap(@"C:\1\2.jpg");

        public Form1()
        {
            InitializeComponent();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создаем документ и прикрепляем к нему обработчик события
            PrintDocument doc = new PrintDocument();

            // Происходит, когда необходимо вывести на печать текущую страницу.
            doc.PrintPage += this.Doc_PrintPage;

            // Пользователь может выбирать принтер и его свойства через стандартное диалоговое окно          

            printDialog1.Document = doc;

            // Если выбрана кнопка OK, то печатаем документ
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создаем документ и прикрепляем к нему обработчик события
            PrintDocument doc = new PrintDocument();

            // Происходит, когда необходимо вывести на печать текущую страницу.
            doc.PrintPage += this.Doc_PrintPage;

            // стандартное диалоговое окно предварительного просмотра
            PrintPreviewDialog dlgPreview = new PrintPreviewDialog();
            dlgPreview.Document = doc;
            dlgPreview.Show();
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics gr = e.Graphics;
            gr.DrawImage(im1, new Rectangle(0, 0, 640, 480), new Rectangle(0, 0, 640, 480), GraphicsUnit.Pixel);
            gr.DrawImage(im2, new Rectangle(0, 500, 640, 480), new Rectangle(0, 0, 640, 480), GraphicsUnit.Pixel);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            gr.DrawImage(im1, new Rectangle(0, 0, 640, 480), new Rectangle(0, 0, 640, 480), GraphicsUnit.Pixel);
            gr.DrawImage(im2, new Rectangle(0, 500, 640, 480), new Rectangle(0, 0, 640, 480), GraphicsUnit.Pixel);
        }
    }
}