using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2011._10._31___Tetris
{
    public partial class FScores : Form
    {
        public FScores(SortedDictionary<UInt32, string> dic)
        {
            InitializeComponent();
            //MessageBox.Show(this.Controls.Find("label1",true).ElementAt(0).Text);

            int i = 0;
            for (; i < dic.Count; i++)
            {
                this.Controls.Find("label" + (i+1).ToString(), true).ElementAt(0).Text =
                    (i + 1).ToString() + ".  " +
                    dic.ElementAt(i).Key.ToString() + "  " +
                    dic.ElementAt(i).Value;
            }
            for (; i < 10; i++)
            {
                this.Controls.Find("label" + (i + 1).ToString(), true).ElementAt(0).Text = 
                    (i + 1).ToString() + ".";
            }
        }
    }
}
