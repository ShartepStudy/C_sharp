using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatisticField
{
    public partial class Form1 : Form
    {
        private int word;
        private int symb;
        private int predlog;
        private int digit;
        private int znakov;
        private int strok;
        public Form1()
        {
            InitializeComponent();
            Refresh();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Refresh();
        }
        public void Count()
        {
            string[] Words = textBox1.Text.Split('\n', ' ');
            string[] Strok = textBox1.Text.Split('\n');
            string[] Predlogen = textBox1.Text.Split('.');
            symb = textBox1.TextLength;
            word = Words.Length;
            strok = Strok.Length;
            znakov = textBox1.Text.Count(char.IsPunctuation);
            predlog = Predlogen.Length - 1;
            digit = textBox1.Text.Count(char.IsDigit);
        }
        public void Refresh()
        {
            Count();
            toolStripStatusLabel1.Text = "Символов: " + symb.ToString();
            toolStripStatusLabel2.Text = "Слов: " + word.ToString();
            toolStripStatusLabel3.Text = "Предложений: " + predlog.ToString();
            toolStripStatusLabel4.Text = "Цифр: " + digit.ToString();
            toolStripStatusLabel5.Text = "Пунктуаций: " + znakov.ToString();
            toolStripStatusLabel6.Text = "Строк: " + strok.ToString();
            toolStripProgressBar1.Value = symb;
        }
    }
}
