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
    public partial class Form1 : Form
    {
        public static int[] mass = new int[1000];

        static Random rand = new Random();

        public static int otgadka = 0;
        public static int zagadka = 0;
        public static int popitka = 0;
        public static int min = 1;
        public static int max = 2000;
        public static bool _sovpad = false;

        public Form1()
        {
            InitializeComponent();
            //первая попытка компа отгадать число
            otgadka = rand.Next(min, max);
            popitka = 1;
            mass[popitka - 1] = otgadka;
        }

        public static bool SetOtgadka()
        {
            otgadka = rand.Next(min, max);
            for (int i = 0; i <= Form1.popitka - 1; i++)
            {
                if (Form1.mass[i] == Form1.otgadka)
                {
                    Form1._sovpad = true;
                    return false;
                }
            }
            if (!_sovpad)
            {
                mass[popitka - 1] = otgadka;
                popitka++;
                
            }
            return true;
        }

        public int Getotgadka()
        {
            return otgadka;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void button1Try_Click(object sender, EventArgs e)
        {
            zagadka = Convert.ToInt32(textBox2.Text);
            otgadivanie();
        }

        public static void otgadivanie()
        {
            if (min >= max || max <= min)
            {
                MessageBox.Show("Вы жульничаете! Попробуйте сначала...");
                min = 0;
                max = 2000;
            }

            if(zagadka == otgadka)
                MessageBox.Show("Это - чило : " + otgadka.ToString());

            Form2 f2 = new Form2();
            f2.SetTextBox1Text(otgadka.ToString());
            f2.Text = "Попытка № " + popitka.ToString();
            DialogResult result;
            result = f2.ShowDialog();
        }
    }
}
