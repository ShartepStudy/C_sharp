using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_1
{
    public partial class Form1 : Form
    {
        private int _count = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            var parent = (sender as ToolStripMenuItem);
            if (parent != null && parent.DropDownItems.Count == 0)
            {
                var newItem = new ToolStripMenuItem
                {
                    Text = (_count++).ToString()
                };
                newItem.MouseEnter += new System.EventHandler(this.toolStripMenuItem1_MouseEnter);
                parent.DropDownItems.Add(newItem);
            }
        }


    }
}
