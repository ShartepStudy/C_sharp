using System;
using System.Windows.Forms;

namespace WindowsForms
{
    internal class CustomForm : 
        Form
    {
        public CustomForm()
        {
            Height = 300;
            Text = String.Format(
                "Screen resolution: {0}x{1} Working area: {2}x{3}", 
                Screen.PrimaryScreen.Bounds.Width, 
                Screen.PrimaryScreen.Bounds.Height, 
                Screen.GetWorkingArea(this).Width, 
                Screen.GetWorkingArea(this).Height
            );
            Width = 600;
        }

        protected override void OnKeyDown(KeyEventArgs arguments)
        {
            if (arguments.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}