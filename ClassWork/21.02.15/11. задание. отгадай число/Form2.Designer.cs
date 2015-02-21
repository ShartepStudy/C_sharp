namespace Отгадай_число
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBolshe = new System.Windows.Forms.Button();
            this.buttonMenshe = new System.Windows.Forms.Button();
            this.buttonPravilno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonBolshe
            // 
            this.buttonBolshe.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonBolshe.Location = new System.Drawing.Point(69, 79);
            this.buttonBolshe.Name = "buttonBolshe";
            this.buttonBolshe.Size = new System.Drawing.Size(75, 23);
            this.buttonBolshe.TabIndex = 5;
            this.buttonBolshe.Text = "Больше";
            this.buttonBolshe.UseVisualStyleBackColor = true;
            this.buttonBolshe.Click += new System.EventHandler(this.buttonBolshe_Click);
            // 
            // buttonMenshe
            // 
            this.buttonMenshe.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonMenshe.Location = new System.Drawing.Point(162, 79);
            this.buttonMenshe.Name = "buttonMenshe";
            this.buttonMenshe.Size = new System.Drawing.Size(75, 23);
            this.buttonMenshe.TabIndex = 6;
            this.buttonMenshe.Text = "Меньше";
            this.buttonMenshe.UseVisualStyleBackColor = true;
            this.buttonMenshe.Click += new System.EventHandler(this.buttonMenshe_Click);
            // 
            // buttonPravilno
            // 
            this.buttonPravilno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonPravilno.Location = new System.Drawing.Point(254, 79);
            this.buttonPravilno.Name = "buttonPravilno";
            this.buttonPravilno.Size = new System.Drawing.Size(75, 23);
            this.buttonPravilno.TabIndex = 7;
            this.buttonPravilno.Text = "Угадал";
            this.buttonPravilno.UseVisualStyleBackColor = true;
            this.buttonPravilno.Click += new System.EventHandler(this.buttonPravilno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Это - число :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(39, 20);
            this.textBox1.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 141);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPravilno);
            this.Controls.Add(this.buttonMenshe);
            this.Controls.Add(this.buttonBolshe);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBolshe;
        private System.Windows.Forms.Button buttonMenshe;
        private System.Windows.Forms.Button buttonPravilno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}