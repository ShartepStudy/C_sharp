namespace WindowsForms
{
    partial class MainForm
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
            this.m_listBoxWeek = new System.Windows.Forms.ListBox();
            this.m_listBoxMonth = new System.Windows.Forms.ListBox();
            this.m_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // m_listBoxWeek
            // 
            this.m_listBoxWeek.FormattingEnabled = true;
            this.m_listBoxWeek.Location = new System.Drawing.Point(143, 36);
            this.m_listBoxWeek.Margin = new System.Windows.Forms.Padding(2);
            this.m_listBoxWeek.Name = "m_listBoxWeek";
            this.m_listBoxWeek.Size = new System.Drawing.Size(130, 160);
            this.m_listBoxWeek.TabIndex = 5;
            // 
            // m_listBoxMonth
            // 
            this.m_listBoxMonth.FormattingEnabled = true;
            this.m_listBoxMonth.Location = new System.Drawing.Point(10, 36);
            this.m_listBoxMonth.Margin = new System.Windows.Forms.Padding(2);
            this.m_listBoxMonth.Name = "m_listBoxMonth";
            this.m_listBoxMonth.Size = new System.Drawing.Size(130, 160);
            this.m_listBoxMonth.TabIndex = 4;
            // 
            // m_comboBox
            // 
            this.m_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_comboBox.FormattingEnabled = true;
            this.m_comboBox.Location = new System.Drawing.Point(10, 11);
            this.m_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.m_comboBox.Name = "m_comboBox";
            this.m_comboBox.Size = new System.Drawing.Size(263, 21);
            this.m_comboBox.TabIndex = 3;
            this.m_comboBox.SelectedIndexChanged += new System.EventHandler(this.OnSelectedValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 207);
            this.Controls.Add(this.m_listBoxWeek);
            this.Controls.Add(this.m_listBoxMonth);
            this.Controls.Add(this.m_comboBox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CultureInfo";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox m_listBoxWeek;
        private System.Windows.Forms.ListBox m_listBoxMonth;
        private System.Windows.Forms.ComboBox m_comboBox;
    }
}

