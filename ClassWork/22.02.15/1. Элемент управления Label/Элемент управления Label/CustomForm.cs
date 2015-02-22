using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForms
{
    internal class CustomForm :
        Form
    {
        private Label m_label = new Label();

        public CustomForm()
        {
            // Цвет фона формы.
            BackColor = Color.AliceBlue;

            // Высота формы.
            Height = 500;

            // Степень прозрачности формы.
            Opacity = 0.8;

            // Ширина форма.
            Width = 500;

            // Подстройка размера статика под содержимое.
            // m_label.AutoSize = true;

            // Цвет фона статика.
            m_label.BackColor = Color.Orange;

            // Трехмерный стиль границ.
            m_label.BorderStyle = BorderStyle.Fixed3D;

            // Тип курсора.
            m_label.Cursor = Cursors.Hand;

            // Цвет текста на статике.
            m_label.ForeColor = Color.FromArgb(255, 0, 0);

            // Высота статика.
            m_label.Height = 200;

            // Позиция левого верхнего угла.
            m_label.Location = new Point(10, 10);

            // Обработчик события движения курсора мыши на статике.
            m_label.MouseMove += new MouseEventHandler(OnMouseMoveLabel);

            // Родительский элемент статика.
            m_label.Parent = this;

            // Текст статика.
            m_label.Text = "Label";

            // Ширина статика.
            m_label.Width = 200;
        }

        protected override void OnMouseMove(MouseEventArgs arguments)
        {
            Text = String.Format("X = {0} Y = {1}", arguments.X, arguments.Y);
        }

        private void OnMouseMoveLabel(Object sender, MouseEventArgs arguments)
        {
            var label = sender as Label;
            label.Text = String.Format("X = {0} Y = {1}", arguments.X, arguments.Y);
        }
    }
}