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

            m_comboBoxOperation.Items.Add("+");
            m_comboBoxOperation.Items.Add("-");
            m_comboBoxOperation.Items.Add("*");
            m_comboBoxOperation.Items.Add("/");

            m_comboBoxOperation.SelectedIndex = 0;
        }

        private void OnClickButton(Object sender, EventArgs arguments)
        {
            try
            {
                Double leftOperand = Convert.ToDouble(m_textBoxLeftOperand.Text);
                Double rightOperand = Convert.ToDouble(m_textBoxRightOperand.Text);

                String operation = m_comboBoxOperation.SelectedItem.ToString();

                switch (operation)
                {
                    case "+":
                        m_labelResult.Text = (leftOperand + rightOperand).ToString();
                        break;
                    case "-":
                        m_labelResult.Text = (leftOperand - rightOperand).ToString();
                        break;
                    case "*":
                        m_labelResult.Text = (leftOperand * rightOperand).ToString();
                        break;
                    case "/":
                        m_labelResult.Text = (leftOperand / rightOperand).ToString();
                        break;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}