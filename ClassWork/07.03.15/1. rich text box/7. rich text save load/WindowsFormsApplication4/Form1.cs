﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication4
{


    public partial class Form1 : Form
    {
        public string path = @"D:\1\Test.txt";
        public Button Save = new Button() { Dock = DockStyle.Bottom, Size = new Size(100, 20), Text = "Save" };
        public Button Open = new Button() { Dock = DockStyle.Bottom, Size = new Size(100, 20), Text = "Load" };
        public Button but = new Button() { Dock = DockStyle.Bottom, Size = new Size(100, 20), Text = "Color" };
        public RichTextBox rtb = new RichTextBox();
        public Form1()
        {
            InitializeComponent();
            rtb.Parent = this;
            rtb.Dock = DockStyle.Fill;
            but.Parent = this;
            Save.Parent = this;
            Open.Parent = this;
            but.Click += new EventHandler(but_Click);
            Save.Click += new EventHandler(Save_Click);
            Open.Click += new EventHandler(Open_Click);
        }

        void Open_Click(object sender, EventArgs e)
        {
            rtb.LoadFile(path);
        }

        void Save_Click(object sender, EventArgs e)
        {
            rtb.SaveFile(path);
        }

        void but_Click(object sender, EventArgs e)
        {
            rtb.SelectionColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



    }


}
