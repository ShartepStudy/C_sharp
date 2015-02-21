// пространство для Windows.Forms
using System;
using System.Windows.Forms;

namespace wf_5
{
    class MyForm : Form
    {
        public MyForm(string caption)
        {
            // установка заголовка окна
            Text = caption;

            // закрепляем обработчик события
            Click += new EventHandler(ClickHandler);

            // например, щелчок только правой кнопкой:
            MouseClick += MyForm_MouseClick;
        }

        private void MyForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MessageBox.Show("Click Left!");
        }

        public void ClickHandler(Object sender, EventArgs e)
        {
            MessageBox.Show("Click!");
        }
    }
    class FirstWinFormApp
    {
        public static void Main()
        {
            // создание объекта пользовательского класса формы
            // запуск обработки очереди сообщений и отображение формы
            Application.Run(new MyForm("Hello, world !"));
        }
    }
}