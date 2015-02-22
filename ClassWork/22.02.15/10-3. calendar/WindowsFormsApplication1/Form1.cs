using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DotNetConsoleApp
{
    public partial class Form1 : Form
    {

        Timer secondsTimer = new Timer() { Interval = 1 };
        MonthCalendar calendar = new MonthCalendar();

        public Form1()
        {
            calendar.Parent = this;
            calendar.ShowTodayCircle = false;
            
            calendar.DateChanged += new DateRangeEventHandler(calendar_DateChanged);

            secondsTimer.Tick += new EventHandler(secondsTimer_Tick);
            secondsTimer.Start();
        }

        void secondsTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = calendar.SelectionStart - DateTime.Now;
            this.Text = ts.ToString();
        }

        void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }


    }
}
