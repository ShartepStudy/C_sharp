using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Timer tm = new Timer();

        List<Icon> IconsArr = new List<Icon>();
        int currIconInd = 0;
        public Form1()
        {
            InitializeComponent();

            IconsArr.Add( SystemIcons.Application );
            IconsArr.Add( SystemIcons.Asterisk );
            IconsArr.Add( SystemIcons.Error );
            IconsArr.Add( SystemIcons.Exclamation );
            IconsArr.Add( SystemIcons.Hand );
            IconsArr.Add( SystemIcons.Information );
            IconsArr.Add( SystemIcons.Question );
            IconsArr.Add( SystemIcons.Shield );
            IconsArr.Add( SystemIcons.Warning );
            IconsArr.Add( SystemIcons.WinLogo );

            tm.Interval = 1000;
            tm.Tick += new EventHandler(tm_Tick);
            tm.Start();

            this.Icon = IconsArr[ currIconInd++ ];// as Icon;
        }

        void tm_Tick(object sender, EventArgs e)
        {
            this.Icon = IconsArr[ currIconInd++];
            CheckIconInd();
        }

        void CheckIconInd()
        {
            if( currIconInd >= IconsArr.Count )
                currIconInd = 0;
            else if( currIconInd < 0 )
                currIconInd = IconsArr.Count - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Все сделано!");
        }
    }
}
