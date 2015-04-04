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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // PrinterSettings.InstalledPrinters получает названия всех принтеров, установленных на компьютере.
            foreach (string printerName in PrinterSettings.InstalledPrinters)
            {
                // Выводим имя принтера
                textBox1.Text += "Принтер: " + printerName + "\r\n";
                // Получаем настройки принтера
                PrinterSettings printer = new PrinterSettings();
                printer.PrinterName = printerName;
                // Проверяем, действителен ли принтер
                if (printer.IsValid)
                {
                    // Выводим список поддерживаемых разрешений
                    textBox1.Text += "Поддерживаемые разрешения:" + "\r\n";
                    foreach (PrinterResolution resolution in printer.PrinterResolutions)
                    {
                        textBox1.Text += resolution + "\r\n";
                    }
                }
            }
        }
    }
}