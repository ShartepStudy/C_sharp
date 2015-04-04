using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForms
{
    internal partial class CustomForm :
        Form
    {
        public CustomForm()
        {
            InitializeComponent();
            UpdateColor();
        }

        private void OnScrollBlue(Object sender, EventArgs arguments)
        {
            UpdateColor();
        }

        private void OnScrollGreen(Object sender, EventArgs arguments)
        {
            UpdateColor();
        }

        private void OnScrollRed(Object sender, EventArgs arguments)
        {
            UpdateColor();
        }

        private void UpdateColor()
        {
            BackColor = Color.FromArgb(
                m_trackBarRed.Value, 
                m_trackBarGreen.Value, 
                m_trackBarBlue.Value
            );
        }
    }
}
