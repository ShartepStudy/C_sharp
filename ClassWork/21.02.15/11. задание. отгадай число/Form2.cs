using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Отгадай_число
{
    public partial class Form2 : Form
    {
        Random rand = new Random();

        

        public Form2()
        {
            InitializeComponent();
        }

        public void SetTextBox1Text(string s)
        {
            this.textBox1.Text = s;
        }

        private void buttonPravilno_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Компьютер угадал ваше число за " + Form1.popitka + "попыток");
        }

        private void buttonMenshe_Click(object sender, EventArgs e)
        {
            Form1.max = Form1.otgadka;
            if (Form1.SetOtgadka())
                Form1.otgadivanie();
            else
                Form1.SetOtgadka();
            
        }

        private void buttonBolshe_Click(object sender, EventArgs e)
        {
            Form1.min = Form1.otgadka;
            if (Form1.SetOtgadka())
                Form1.otgadivanie();
            else
                Form1.SetOtgadka();
        }
    }
}
