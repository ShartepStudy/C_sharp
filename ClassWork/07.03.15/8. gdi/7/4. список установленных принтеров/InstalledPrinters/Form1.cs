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
            // PrinterSettings.InstalledPrinters �������� �������� ���� ���������, ������������� �� ����������.
            foreach (string printerName in PrinterSettings.InstalledPrinters)
            {
                // ������� ��� ��������
                textBox1.Text += "�������: " + printerName + "\r\n";
                // �������� ��������� ��������
                PrinterSettings printer = new PrinterSettings();
                printer.PrinterName = printerName;
                // ���������, ������������ �� �������
                if (printer.IsValid)
                {
                    // ������� ������ �������������� ����������
                    textBox1.Text += "�������������� ����������:" + "\r\n";
                    foreach (PrinterResolution resolution in printer.PrinterResolutions)
                    {
                        textBox1.Text += resolution + "\r\n";
                    }
                }
            }
        }
    }
}