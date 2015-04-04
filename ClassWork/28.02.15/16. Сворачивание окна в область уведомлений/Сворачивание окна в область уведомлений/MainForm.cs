using System;
using System.Windows.Forms;

namespace WindowsForms
{
    internal partial class MainForm :
        Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnClickExit(Object sender, EventArgs arguments)
        {
            Close();
        }

        private void OnClickRestore(Object sender, EventArgs arguments)
        {
            Show();

            WindowState = FormWindowState.Normal;

            m_notifyIcon.Visible = false;
        }

        private void OnLoad(Object sender, EventArgs arguments)
        {
            m_notifyIcon.Visible = false;
        }

        private void OnMouseDoubleClick(Object sender, MouseEventArgs arguments)
        {
            Show();

            WindowState = FormWindowState.Normal;

            m_notifyIcon.Visible = false;
        }

        private void OnResize(Object sender, EventArgs arguments)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();

                m_notifyIcon.Visible = true;
                m_notifyIcon.ShowBalloonTip(3);
            }

        }
    }
}