using System;
using System.Windows.Forms;

namespace FourthSample
{
    public partial class Form1 : Form
    {
        // создаём таймер
        private static readonly Timer VTimer = new Timer();
        // Обработчик тика для таймера
        private void ShowTime(object vObj, EventArgs e)
        {
            // преобразование к строке
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

        public Form1()
        {
            InitializeComponent();
            // преобразование к строке
            labelTime.Text = DateTime.Now.ToLongTimeString();
            // закрепление обработчика
            VTimer.Tick += new EventHandler(ShowTime);
            // установка интервала времени
            VTimer.Interval = 500;
            // стартуем таймер
            VTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
