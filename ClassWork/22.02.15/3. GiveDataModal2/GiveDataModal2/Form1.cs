﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GiveDataModal2
{
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            Child form1 = new Child();
            //form1.SomeMeth(textBox1.Text);
            
            // есть ещё и другой способ - обращение к некоторому свойству
            form1.TText = textBox1.Text;
            form1.Show();
        }
    }
}
