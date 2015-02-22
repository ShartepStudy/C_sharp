using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChangeIcon
{
    public partial class Form1 : Form
    {
        private Timer vTimer = new Timer();
        private int indexIcon = 1;
        public Form1()
        {
            InitializeComponent();
            vTimer.Tick += new EventHandler(DoIt);
            vTimer.Interval = 500;
            vTimer.Start();
            this.Icon = new Icon(@"icon\event_online_" + indexIcon + ".ico");
        }
        private void DoIt(object vObject, EventArgs e)
        {
            indexIcon++;
            if (indexIcon > 14)
                indexIcon = 1;
            this.Icon = new Icon(@"icon\event_online_" + indexIcon + ".ico");
            
        }
    }
}
