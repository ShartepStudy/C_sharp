using System;
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
            Controls.SetChildIndex(sender as Button, 0);
        }
    }
}