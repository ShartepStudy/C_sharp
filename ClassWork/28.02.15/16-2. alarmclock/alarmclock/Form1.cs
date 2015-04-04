using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace alarmclock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Icon = alarmclock.Properties.Resources.ALARM;
            this.notifyIcon1.Icon = alarmclock.Properties.Resources.ALARM;
            timer1.Start();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
                this.notifyIcon1.Visible = true;
                this.notifyIcon1.ShowBalloonTip(3);
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SetTimer()
        {
            if (checkBox1.Checked)
            {
                DateTime alarmtime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)numericUpDown1.Value, (int)numericUpDown2.Value,0);
                if (alarmtime<DateTime.Now)
                    alarmtime=alarmtime.AddDays(1);  
                timer2.Interval = (int)(alarmtime - DateTime.Now).TotalMilliseconds;
                timer2.Start();
            }
            else
                timer2.Stop();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SetTimer();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(alarmclock.Properties.Resources.ring);
            player.Play();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SetTimer();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
