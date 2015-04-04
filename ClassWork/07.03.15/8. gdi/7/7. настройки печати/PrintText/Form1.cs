using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace PrintText
{
    public partial class Form1 : Form
    {
        private int pagesPrinted = 0;
        string[] lines;

        public Form1()
        {
            InitializeComponent();
        }

        private void menuFilePrint_Click(object sender, EventArgs e)
        {
            lines = richTextBox1.Text.Split(new char[] { '\n' });
            pagesPrinted = 0;
            PrintDocument pDoc = new PrintDocument();
            pDoc.PrintPage += new PrintPageEventHandler(pDoc_PrintPage);
            pDoc.Print();
        }

        private void menuFilePrintPrew_Click(object sender, EventArgs e)
        {
            lines = richTextBox1.Text.Split(new char[] { '\n' });
            pagesPrinted = 0;
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            PrintDocument pDoc = new PrintDocument();
            pDoc.PrintPage += new PrintPageEventHandler(pDoc_PrintPage);
            ppd.Document = pDoc;
            ppd.ShowDialog();
        }

        void pDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            float yPos = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            Font font = new Font("Arial", 12, FontStyle.Regular);

            // Определим, сколько строк помещается на странице
            // ev.MarginBounds.Height - высота страницы
            // GetHeight возвращает значение междустрочного интервала данного шрифта 
            // в текущей единице измерения указанного контекста Graphics.             
            int linesPerPage = (int)(e.MarginBounds.Height / font.GetHeight(e.Graphics));
            int lineNo = this.pagesPrinted * linesPerPage;

            // Печатаем заданное количество строк файла
            int count = 0;
            while (count < linesPerPage && lineNo < lines.Length)
            {
                line = lines[lineNo];
                //смещаем вниз координату Y
                yPos = topMargin + (count * font.GetHeight(e.Graphics));
                // выводим очередную строку
                e.Graphics.DrawString(line, font, Brushes.Black, leftMargin, yPos, new StringFormat());
                lineNo++;
                count++;
            }

            // Если есть еще строки в файле, то печатаем следующую страницу           
            // ev.HasMorePages определяет, нужно ли выводить на печать следующую страницу
            if (lines.Length > lineNo)
            {
                e.HasMorePages = true;
                pagesPrinted++;
            }
            else
            {
                e.HasMorePages = false;
                pagesPrinted = 0;
            }

        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lines = richTextBox1.Text.Split(new char[] { '\n' });
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += new PrintPageEventHandler(pDoc_PrintPage);
            pageSetupDialog1.Document = doc;

            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }


    }
}
