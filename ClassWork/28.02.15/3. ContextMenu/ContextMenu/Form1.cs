﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContextMenu
{
    public partial class Form1 : Form
    {
        ContextMenuStrip m;
        public Form1()
        {
            InitializeComponent();
            m = new ContextMenuStrip();
            m.Items.Add("Open");
            m.Items.Add("Close");
            textBox1.ContextMenuStrip = m;
            m.Items[0].Click += _contextMenuItem1Click;
        }

        private void _contextMenuItem1Click(object sender, EventArgs eventArgs)
        {
            m.Items[1].Text = "Hello!";
        }
    }
}
