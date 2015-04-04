using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            string familyName = "";
            FontFamily[] fontFamilies;
            // Класс PrivateFontCollection предоставляет коллекцию семейств шрифтов, созданных из файлов пользовательских шрифтов
            using (PrivateFontCollection privateFontCollection = new PrivateFontCollection())
            {
                // Добавим свой шрифт в класс PrivateFontCollection
                privateFontCollection.AddFontFile(Application.StartupPath + "\\" + "pussyfoo.ttf"); // pussyfoot - красться по-кошачьи
                // Получим массив объектов FontFamily
                fontFamilies = privateFontCollection.Families;
                // Получим имя первого элемента из коллекции
                familyName = fontFamilies[0].Name;

                FontFamily ff = new FontFamily(familyName, privateFontCollection);
                //FontFamily ff = new FontFamily("Calibri");

                Font f = new Font(ff, 72, FontStyle.Regular);
                Graphics g = CreateGraphics();
                // Выводим строку на экран
                g.DrawString("ABCDEFGHIJKLM", f, solidBrush, new PointF(10, 30));
                g.DrawString("NOPQRSTUVWXYZ", f, solidBrush, new PointF(10, 150));
                g.Dispose();
            }
        }
    }
}