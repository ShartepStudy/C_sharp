using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordPad
{
    public partial class ReplaceForm : Form
    {
        static bool bReplaceAll = false;

        public ReplaceForm()
        {
            InitializeComponent();
        }

        public string GetOldString()
        {
            return this.tbOldString.Text;
        }

        public string GetNewString()
        {
            return this.tbNewString.Text;
        }

        private void checkBoxReplaceAll_CheckedChanged(object sender, EventArgs e)
        {
            if (bReplaceAll)
                bReplaceAll = false;
            else
                bReplaceAll = true;
        }

        static public bool GetbReplaceAll()
        {
            return bReplaceAll;
        }
    }
}
