namespace WindowsForms
{
    partial class CustomForm
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
            this.components = new System.ComponentModel.Container();
            this.m_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.m_textBoxLeftOperand = new System.Windows.Forms.TextBox();
            this.m_comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.m_textBoxRightOperand = new System.Windows.Forms.TextBox();
            this.m_buttonCalculate = new System.Windows.Forms.Button();
            this.m_labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_textBoxLeftOperand
            // 
            this.m_textBoxLeftOperand.Location = new System.Drawing.Point(12, 15);
            this.m_textBoxLeftOperand.Name = "m_textBoxLeftOperand";
            this.m_textBoxLeftOperand.Size = new System.Drawing.Size(48, 20);
            this.m_textBoxLeftOperand.TabIndex = 0;
            this.m_toolTip.SetToolTip(this.m_textBoxLeftOperand, "First operand");
            // 
            // m_comboBoxOperation
            // 
            this.m_comboBoxOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_comboBoxOperation.FormattingEnabled = true;
            this.m_comboBoxOperation.Location = new System.Drawing.Point(66, 15);
            this.m_comboBoxOperation.Name = "m_comboBoxOperation";
            this.m_comboBoxOperation.Size = new System.Drawing.Size(48, 21);
            this.m_comboBoxOperation.TabIndex = 2;
            this.m_toolTip.SetToolTip(this.m_comboBoxOperation, "Operation");
            // 
            // m_textBoxRightOperand
            // 
            this.m_textBoxRightOperand.Location = new System.Drawing.Point(120, 15);
            this.m_textBoxRightOperand.Name = "m_textBoxRightOperand";
            this.m_textBoxRightOperand.Size = new System.Drawing.Size(48, 20);
            this.m_textBoxRightOperand.TabIndex = 3;
            this.m_toolTip.SetToolTip(this.m_textBoxRightOperand, "Second operand");
            // 
            // m_buttonCalculate
            // 
            this.m_buttonCalculate.Location = new System.Drawing.Point(174, 14);
            this.m_buttonCalculate.Name = "m_buttonCalculate";
            this.m_buttonCalculate.Size = new System.Drawing.Size(37, 22);
            this.m_buttonCalculate.TabIndex = 4;
            this.m_buttonCalculate.Text = "=";
            this.m_toolTip.SetToolTip(this.m_buttonCalculate, "Calculate result");
            this.m_buttonCalculate.UseVisualStyleBackColor = true;
            this.m_buttonCalculate.Click += new System.EventHandler(this.OnClickButton);
            // 
            // m_labelResult
            // 
            this.m_labelResult.AutoSize = true;
            this.m_labelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_labelResult.Location = new System.Drawing.Point(217, 15);
            this.m_labelResult.MinimumSize = new System.Drawing.Size(50, 2);
            this.m_labelResult.Name = "m_labelResult";
            this.m_labelResult.Size = new System.Drawing.Size(50, 15);
            this.m_labelResult.TabIndex = 5;
            this.m_toolTip.SetToolTip(this.m_labelResult, "Result");
            // 
            // CustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 49);
            this.Controls.Add(this.m_labelResult);
            this.Controls.Add(this.m_buttonCalculate);
            this.Controls.Add(this.m_textBoxRightOperand);
            this.Controls.Add(this.m_comboBoxOperation);
            this.Controls.Add(this.m_textBoxLeftOperand);
            this.Name = "CustomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip m_toolTip;
        private System.Windows.Forms.TextBox m_textBoxLeftOperand;
        private System.Windows.Forms.ComboBox m_comboBoxOperation;
        private System.Windows.Forms.TextBox m_textBoxRightOperand;
        private System.Windows.Forms.Button m_buttonCalculate;
        private System.Windows.Forms.Label m_labelResult;
    }
}

