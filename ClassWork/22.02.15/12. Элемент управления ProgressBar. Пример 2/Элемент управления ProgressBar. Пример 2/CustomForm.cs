using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsForms
{
    internal partial class CustomForm :
        Form
    {
        public CustomForm()
        {
            InitializeComponent();
        }

        private void OnClick(Object sender, EventArgs arguments)
        {
            m_button.Enabled = false;

            m_progressBar.Maximum = 50;
            m_progressBar.Minimum = 0;
            m_progressBar.Step = 1;
            m_progressBar.Value = 0;

            for (var i = 0; i <= 50; ++i)
            {
                m_progressBar.PerformStep();

                m_label.Text = String.Format("Value = {0}", m_progressBar.Value);

                Update();

                Thread.Sleep(50);              
            }

            m_button.Enabled = true;
        }
    }
}
