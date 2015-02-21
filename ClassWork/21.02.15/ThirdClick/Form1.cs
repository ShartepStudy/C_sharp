using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdClick
{
    public partial class Form1 : Form
    {
        private bool fClick = false;
        Timer vTimer = new Timer();
        private int clk = 0;
        public Form1()
        {
            InitializeComponent();
            vTimer.Tick += new EventHandler(DoIt);
            vTimer.Interval = 500;
        }
        private void DoIt(object vObject, EventArgs e)
        {
            //останавливаем таймер
            vTimer.Stop();
            if (clk == 3)
            {
                MessageBox.Show("Тройное нажатие.");
            }else if (clk > 3)
            {
                MessageBox.Show("Вы нажали больше трех раз.");
            }
            fClick = false;
            clk = 0;


        }

        private void Form1_Click(object sender, EventArgs e)
        {
            vTimer.Start();
            if (!fClick)
            {
                fClick = true;
            }
            if (fClick)
            {
                clk++;
            }
            Text = "Нажато " + clk + " раз";
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            if (fClick)
            {
                clk++;
            }
            Text = "Нажато " + clk + " раз";
        }
    }
}
