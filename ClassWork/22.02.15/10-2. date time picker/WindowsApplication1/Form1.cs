using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        Timer t;
        public Form1()
        {
            InitializeComponent();
            t = new Timer();
            t.Tick += new EventHandler(t_Tick);
            t.Interval = 1000;
            t.Start();           
        }

        private void t_Tick(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            textBox1.Text = today.ToString() + "   " + today.DayOfWeek;
            DateTime dtp = dateTimePicker1.Value;
            TimeSpan ts = (today > dtp) ? today - dtp : dtp - today;
            textBox2.Text = String.Format("{0} days  {1} hours  {2} minutes {3} seconds", ts.Days, ts.Hours, ts.Minutes, ts.Seconds);
       }
        
    }
}