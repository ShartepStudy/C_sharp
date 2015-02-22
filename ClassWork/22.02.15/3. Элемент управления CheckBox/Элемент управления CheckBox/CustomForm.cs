using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForms
{
    internal class CustomForm :
        Form
    {
        private CheckBox m_checkBox = new CheckBox();
        private Label m_label = new Label();
        private Timer m_timer = new Timer();

        public CustomForm()
        {
            // Цвет фона формы.
            BackColor = Color.AliceBlue;
            Height = 80;
            Width = 300;

            // Флажок установлен.
            m_checkBox.Checked = true;
            m_checkBox.Location = new Point(120, 10);
            m_checkBox.Parent = this;
            m_checkBox.Text = "Show seconds";
            m_checkBox.Width = 200;

            // Цвет фона статика.
            m_label.BackColor = Color.Orange;

            // Трехмерный стиль границ.
            m_label.BorderStyle = BorderStyle.Fixed3D;

            // Цвет текста на статике.
            m_label.ForeColor = Color.FromArgb(255, 0, 0);

            // Высота статика.
            m_label.Height = 20;

            m_label.Location = new Point(10, 10);
            m_label.Parent = this;

            // Выравнивание.
            m_label.TextAlign = ContentAlignment.MiddleCenter;

            // Ширина статика.
            m_label.Width = 100;

            m_timer.Interval = 1000;
            m_timer.Tick += new EventHandler(OnTick);

            m_timer.Start();
        }

        private void OnTick(Object sender, EventArgs arguments)
        {
            var caption = String.Empty;

            // Получение текущего время.
            var now = DateTime.Now;

            // Если флажок установлен, то отображаются секунды.
            if (m_checkBox.Checked)
            {
                caption = String.Format("{0:D2}:{1:D2}:{2:D2}", now.Hour, now.Minute, now.Second);
            }
            else
            {
                caption = String.Format("{0:D2}:{1:D2}", now.Hour, now.Minute);
            }

            m_label.Text = caption;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CustomForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "CustomForm";
            this.ResumeLayout(false);

        }
    }
}