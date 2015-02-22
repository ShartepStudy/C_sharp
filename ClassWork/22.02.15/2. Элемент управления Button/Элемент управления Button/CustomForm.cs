using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForms
{
    internal class CustomForm :
        Form
    {
        private Int32 m_index = 1;
        private Button m_picture = new Button();
        private Button m_start = new Button();
        private Button m_stop = new Button();
        private Timer m_timer = new Timer();

        public CustomForm()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Height = 200;
            MaximizeBox = false;
            Text = "Slide show";

            m_picture.Height = 80;
            m_picture.Image = Image.FromFile(@"..\..\1.bmp");
            m_picture.Location = new Point(100, 10);
            m_picture.Parent = this;
            m_picture.Width = 80;

            m_start.Click += new EventHandler(OnClickStart);
            m_start.Height = 40;
            m_start.Location = new Point(30, 100);
            m_start.Parent = this;
            m_start.Text = "Start";
            m_start.Width = 100;

            m_stop.Click += new EventHandler(OnClickStop);
            m_stop.Height = 40;
            m_stop.Location = new Point(160, 100);
            m_stop.Parent = this;
            m_stop.Text = "Stop";
            m_stop.Width = 100;

            m_timer.Interval = 1000;
            m_timer.Tick += new EventHandler(OnTick);
        }

        private void OnClickStart(Object sender, EventArgs arguments)
        {
            m_timer.Start();
        }

        private void OnClickStop(Object sender, EventArgs arguments)
        {
            m_timer.Stop();
        }

        private void OnTick(Object sender, EventArgs arguments)
        {
            ++m_index;

            if (m_index > 5)
            {
                m_index = 1;
            }

            m_picture.Image = Image.FromFile(String.Format(@"..\..\{0}.bmp", m_index));
        }
    }
}