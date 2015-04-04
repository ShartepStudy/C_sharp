using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication1
{
	class ContainerForm : Form
	{
        private LoginForm loginForm2;
        private LoginForm loginForm3;
        private LoginForm loginForm1;
		
		public ContainerForm()
		{
            InitializeComponent();
            this.loginForm1.OKPressed += new LoginForm.LoginFormOkDelegate(loginForm1_OKPressed);
			this.Paint += new PaintEventHandler(ContainerForm_Paint);			
		}

        void loginForm1_OKPressed(object sender, LoginForm.LoginFormEventArgs e)
        {
            if (!e.ArePasswordsEqual)
            {
                MessageBox.Show("Type equal passwords");
            }
        }
		
		void ContainerForm_Paint(object sender, PaintEventArgs e)
		{
			
		}

        private void InitializeComponent()
        {
            this.loginForm1 = new WindowsFormsApplication1.LoginForm();
            this.loginForm2 = new WindowsFormsApplication1.LoginForm();
            this.loginForm3 = new WindowsFormsApplication1.LoginForm();
            this.SuspendLayout();
            // 
            // loginForm1
            // 
            this.loginForm1.Location = new System.Drawing.Point(13, 12);
            this.loginForm1.Login = "";
            this.loginForm1.Name = "loginForm1";
            this.loginForm1.Other = "";
            this.loginForm1.Password = "";
            this.loginForm1.Size = new System.Drawing.Size(435, 180);
            this.loginForm1.TabIndex = 0;
            // 
            // loginForm2
            // 
            this.loginForm2.Location = new System.Drawing.Point(13, 199);
            this.loginForm2.Login = "";
            this.loginForm2.Name = "loginForm2";
            this.loginForm2.Other = "";
            this.loginForm2.Password = "";
            this.loginForm2.Size = new System.Drawing.Size(435, 179);
            this.loginForm2.TabIndex = 1;
            // 
            // loginForm3
            // 
            this.loginForm3.Location = new System.Drawing.Point(13, 384);
            this.loginForm3.Login = "";
            this.loginForm3.Name = "loginForm3";
            this.loginForm3.Other = "";
            this.loginForm3.Password = "";
            this.loginForm3.Size = new System.Drawing.Size(435, 179);
            this.loginForm3.TabIndex = 1;
            // 
            // ContainerForm
            // 
            this.ClientSize = new System.Drawing.Size(487, 594);
            this.Controls.Add(this.loginForm3);
            this.Controls.Add(this.loginForm2);
            this.Controls.Add(this.loginForm1);
            this.Name = "ContainerForm";
            this.ResumeLayout(false);

        }

      
	}
}




