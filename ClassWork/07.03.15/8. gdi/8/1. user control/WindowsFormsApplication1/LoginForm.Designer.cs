namespace WindowsFormsApplication1
{
    partial class LoginForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainGB = new System.Windows.Forms.GroupBox();
            this.okButton = new System.Windows.Forms.Button();
            this.otherLB = new System.Windows.Forms.Label();
            this.pwdRepeatLabel = new System.Windows.Forms.Label();
            this.pwdLB = new System.Windows.Forms.Label();
            this.LoginLB = new System.Windows.Forms.Label();
            this.otherTB = new System.Windows.Forms.TextBox();
            this.pwdRepeatTB = new System.Windows.Forms.TextBox();
            this.pwdTB = new System.Windows.Forms.TextBox();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.errLB = new System.Windows.Forms.Label();
            this.mainGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGB
            // 
            this.mainGB.Controls.Add(this.errLB);
            this.mainGB.Controls.Add(this.okButton);
            this.mainGB.Controls.Add(this.otherLB);
            this.mainGB.Controls.Add(this.pwdRepeatLabel);
            this.mainGB.Controls.Add(this.pwdLB);
            this.mainGB.Controls.Add(this.LoginLB);
            this.mainGB.Controls.Add(this.otherTB);
            this.mainGB.Controls.Add(this.pwdRepeatTB);
            this.mainGB.Controls.Add(this.pwdTB);
            this.mainGB.Controls.Add(this.loginTB);
            this.mainGB.Location = new System.Drawing.Point(4, 4);
            this.mainGB.Name = "mainGB";
            this.mainGB.Size = new System.Drawing.Size(428, 172);
            this.mainGB.TabIndex = 1;
            this.mainGB.TabStop = false;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(347, 143);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // otherLB
            // 
            this.otherLB.AutoSize = true;
            this.otherLB.Location = new System.Drawing.Point(6, 98);
            this.otherLB.Name = "otherLB";
            this.otherLB.Size = new System.Drawing.Size(33, 13);
            this.otherLB.TabIndex = 1;
            this.otherLB.Text = "Other";
            // 
            // pwdRepeatLabel
            // 
            this.pwdRepeatLabel.AutoSize = true;
            this.pwdRepeatLabel.Location = new System.Drawing.Point(7, 72);
            this.pwdRepeatLabel.Name = "pwdRepeatLabel";
            this.pwdRepeatLabel.Size = new System.Drawing.Size(90, 13);
            this.pwdRepeatLabel.TabIndex = 1;
            this.pwdRepeatLabel.Text = "Repeat password";
            // 
            // pwdLB
            // 
            this.pwdLB.AutoSize = true;
            this.pwdLB.Location = new System.Drawing.Point(7, 46);
            this.pwdLB.Name = "pwdLB";
            this.pwdLB.Size = new System.Drawing.Size(53, 13);
            this.pwdLB.TabIndex = 1;
            this.pwdLB.Text = "Password";
            // 
            // LoginLB
            // 
            this.LoginLB.AutoSize = true;
            this.LoginLB.Location = new System.Drawing.Point(7, 20);
            this.LoginLB.Name = "LoginLB";
            this.LoginLB.Size = new System.Drawing.Size(33, 13);
            this.LoginLB.TabIndex = 1;
            this.LoginLB.Text = "Login";
            // 
            // otherTB
            // 
            this.otherTB.Location = new System.Drawing.Point(185, 98);
            this.otherTB.Name = "otherTB";
            this.otherTB.Size = new System.Drawing.Size(237, 20);
            this.otherTB.TabIndex = 0;
            // 
            // pwdRepeatTB
            // 
            this.pwdRepeatTB.Location = new System.Drawing.Point(185, 72);
            this.pwdRepeatTB.Name = "pwdRepeatTB";
            this.pwdRepeatTB.Size = new System.Drawing.Size(237, 20);
            this.pwdRepeatTB.TabIndex = 0;
            // 
            // pwdTB
            // 
            this.pwdTB.Location = new System.Drawing.Point(185, 46);
            this.pwdTB.Name = "pwdTB";
            this.pwdTB.Size = new System.Drawing.Size(237, 20);
            this.pwdTB.TabIndex = 0;
            this.pwdTB.TextChanged += new System.EventHandler(this.pwdTB_TextChanged);
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(185, 20);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(237, 20);
            this.loginTB.TabIndex = 0;
            // 
            // errLB
            // 
            this.errLB.AutoSize = true;
            this.errLB.Location = new System.Drawing.Point(5, 131);
            this.errLB.Name = "errLB";
            this.errLB.Size = new System.Drawing.Size(0, 13);
            this.errLB.TabIndex = 3;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainGB);
            this.Name = "LoginForm";
            this.Size = new System.Drawing.Size(435, 179);
            this.mainGB.ResumeLayout(false);
            this.mainGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainGB;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label otherLB;
        private System.Windows.Forms.Label pwdRepeatLabel;
        private System.Windows.Forms.Label pwdLB;
        private System.Windows.Forms.Label LoginLB;
        private System.Windows.Forms.TextBox otherTB;
        private System.Windows.Forms.TextBox pwdRepeatTB;
        private System.Windows.Forms.TextBox pwdTB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Label errLB;
    }
}
