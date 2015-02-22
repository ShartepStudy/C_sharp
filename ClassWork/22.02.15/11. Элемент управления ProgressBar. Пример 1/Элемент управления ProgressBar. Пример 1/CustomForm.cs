using System;
using System.Windows.Forms;

namespace WindowsForms
{
    internal partial class CustomForm :
        Form
    {
        private Timer m_timer = new Timer();

        public CustomForm()
        {
            InitializeComponent();

            m_timer.Interval = 1000;
            m_timer.Tick += new EventHandler(OnTick);
        }

        private void OnClick(Object sender, EventArgs arguments)
        {
            m_button.Enabled = false;
            m_progressBar.Value = 0;

            m_timer.Start();
        }

        private void OnTick(Object sender, EventArgs arguments)
        {
            m_progressBar.Value += 10;

            if (m_progressBar.Value == m_progressBar.Maximum)
            {
                m_button.Enabled = true;

                m_timer.Stop();
            }
        }
    }
}