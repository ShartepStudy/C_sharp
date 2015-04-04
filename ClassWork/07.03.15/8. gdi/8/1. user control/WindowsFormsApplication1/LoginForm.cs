using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class LoginForm : UserControl
    {
        public class LoginFormEventArgs : EventArgs
        {
            public string Login { get; set; }
            public string Password { get; set; }
            public string Other { get; set; }
            public bool ArePasswordsEqual { get; set; }

            public LoginFormEventArgs(LoginForm form)
            {
                this.Login = form.Login;
                this.Password = form.Password;
                this.ArePasswordsEqual = form.ArePasswordsEqual;
                this.Other = form.Other;
            }
        }
        public delegate void LoginFormOkDelegate(object sender, LoginFormEventArgs e);

        public string Login { get { return loginTB.Text; } set { loginTB.Text = value; } }
        public string Password { get { return pwdTB.Text; } set { pwdTB.Text = value; } }
        public string Other { get { return otherTB.Text; } set { otherTB.Text = value; } }
        public bool ArePasswordsEqual { get { return pwdTB.Text == pwdRepeatTB.Text; } }

        public event LoginFormOkDelegate OKPressed;

        public LoginForm()
        {
            InitializeComponent();
            pwdRepeatTB.TextChanged += pwdTB_TextChanged;
            OKPressed += LoginForm_OKPressed;
        }

        void LoginForm_OKPressed(object sender, LoginForm.LoginFormEventArgs e)
        {
            MessageBox.Show("!!!");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if(OKPressed != null)
                OKPressed(this, new LoginFormEventArgs(this));
        }

        private void pwdTB_TextChanged(object sender, EventArgs e)
        {
            if (this.ArePasswordsEqual)
            {
                errLB.Text = "";
            }
            else
            {
                errLB.Text = "Type equal passwords";
            }
        }

       

    }
}
