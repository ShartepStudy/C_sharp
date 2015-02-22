using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        private double ac;  // аккумулятор
        private string co;  // текущая операция:
        private Boolean fd; // fd == true - ждем первую цифру числа,
        private bool pBAct;
        double ind_n;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            fd = true;
            pBAct = false;
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            co = "ButtonResult"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fd)
            {
                textBox1.Text = button1.Text;
               fd = false;
            }
            else
                textBox1.Text += button1.Text;
            if (!pBAct)
            {
                ac = Convert.ToDouble(textBox1.Text);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fd)
            {
                textBox1.Text = button2.Text;

                fd = false;
            }
            else
                textBox1.Text += button2.Text;
            if (!pBAct)
            {
                ac = Convert.ToDouble(textBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fd)
            {
                textBox1.Text = button3.Text;
                //ac = Convert.ToDouble(textBox1.Text);
                fd = false;
            }
            else
                textBox1.Text += button3.Text;
            if (!pBAct)
            {
                ac = Convert.ToDouble(textBox1.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fd)
            {
                textBox1.Text = button4.Text;
                //ac = Convert.ToDouble(textBox1.Text);
                fd = false;
            }
            else
                textBox1.Text += button4.Text;
            if (!pBAct)
            {
                ac = Convert.ToDouble(textBox1.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (fd)
            {
                textBox1.Text = button5.Text;
                //ac = Convert.ToDouble(textBox1.Text);
                fd = false;
            }
            else
                textBox1.Text += button5.Text;
            if (!pBAct)
            {
                ac = Convert.ToDouble(textBox1.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (fd)
            {
                textBox1.Text = button6.Text;
                //ac = Convert.ToDouble(textBox1.Text);
                fd = false;
            }
            else
                textBox1.Text += button6.Text;
            if (!pBAct)
            {
                ac = Convert.ToDouble(textBox1.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (fd)
            {
                textBox1.Text = button7.Text;
                //ac = Convert.ToDouble(textBox1.Text);
                fd = false;
            }
            else
                textBox1.Text += button7.Text;
            if (!pBAct)
            {
                ac = Convert.ToDouble(textBox1.Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (fd)
            {
                textBox1.Text = button8.Text;
                ac = Convert.ToDouble(textBox1.Text);
                fd = false;
            }
            else
                textBox1.Text += button8.Text;
            if (!pBAct)
            {
                ac = Convert.ToDouble(textBox1.Text);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (fd)
            {
                textBox1.Text = button9.Text;
                ac = Convert.ToDouble(textBox1.Text);
                fd = false;
            }
            else
                textBox1.Text += button9.Text;
            if (!pBAct)
            {
                ac = Convert.ToDouble(textBox1.Text);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (fd)
            {
                textBox1.Text = button10.Text;
                ac = Convert.ToDouble(textBox1.Text);
                fd = false;
            }
            else
                textBox1.Text += button10.Text;
            if (!pBAct)
            {
                ac = Convert.ToDouble(textBox1.Text);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (fd)
            {
                textBox1.Text = "0,";
                //ac = Convert.ToDouble(textBox1.Text);
                fd = false;
            }
            else
                if (textBox1.Text.IndexOf(",") == -1)
                {
                    if (String.IsNullOrEmpty(textBox1.Text))
                    {
                        textBox1.Text = "0";
                    }
                    textBox1.Text += button11.Text;
                }
            if (!pBAct)
            {
                ac = Convert.ToDouble(textBox1.Text);
            }
                    
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            //ind_n = Convert.ToDouble(textBox1.Text);
            if (fd == false)
            {
                 //ac += ind_n;
                co = "ButtonPlus";
                fd = false;
                pBAct = true;
                textBox1.Text = "";
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            //ind_n = Convert.ToDouble(textBox1.Text);
            if (fd == false)
            {
                //ac -= ind_n;
                co = "ButtonMinus";
                fd = false;
                pBAct = true;
                textBox1.Text = "";
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            //ind_n = Convert.ToDouble(textBox1.Text);
            if (fd == false)
            {
                //ac *= ind_n;
                co = "ButtonMultiply";
                fd = false;
                pBAct = true;
                textBox1.Text = "";
            }
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            //ind_n = Convert.ToDouble(textBox1.Text);
            if (fd == false)
            {
                //ac /= ind_n;
                co = "ButtonDivision";
                fd = false;
                pBAct = true;
                textBox1.Text = "";
            }
            
            
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            ind_n = Convert.ToDouble(textBox1.Text);
            if (co.Equals("ButtonPlus")) ac += ind_n;
            if (co.Equals("ButtonMinus")) ac -= ind_n;
            if (co.Equals("ButtonMultiply")) ac *= ind_n;
            if (co.Equals("ButtonDivision")) ac /= ind_n;
            textBox1.Text = ac.ToString();
            co = "ButtonResult";
            fd = true;
            pBAct = false;

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ac = 0;
            fd = true;
            pBAct = false;
            textBox1.Text = "0";
            co = "ButtonResult";
        }
    }
}
