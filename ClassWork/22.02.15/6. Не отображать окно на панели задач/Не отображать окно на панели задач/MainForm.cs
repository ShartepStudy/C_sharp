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

        private void OnClick(Object sender, EventArgs arguments)
        {
            var form = new AdditionalForm();

            AddOwnedForm(form);

            form.ShowInTaskbar = false;
            form.Show();
        }
    }
}