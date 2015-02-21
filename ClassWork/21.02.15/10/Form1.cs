using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пробег_мышки
{
    public partial class Form1 : Form
    {
        // объявляем API
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        static protected long totalPixels = 0;
        static protected int currX;
        static protected int currY;
        static protected int diffX;
        static protected int diffY;
        static protected double sm;

        public Form1()
        {
            InitializeComponent();
        }

        private void tmrDef_Tick(object sender, EventArgs e)
        {
            // Новый объект типа Point для хранения стартовых координат
            Point defPnt = new Point();
            // Вызов Win Api функции для получения координат
            GetCursorPos(ref defPnt);
            // Если курсор изменил положение
            if (diffX != defPnt.X | diffY != defPnt.Y)
            {
                // подсчёт разницы по горизонтали и вертикали в пикселях
                diffX = (defPnt.X - currX);
                diffY = (defPnt.Y - currY);
                // Если значение отрицательное(курсор сдвинут влево)
                // делаем его положительным
                if (diffX < 0)
                {
                    diffX *= -1;
                }
                if (diffY < 0)
                {
                    diffY *= -1;
                }
                // Плюсуем всё в переменную
                totalPixels += diffX + diffY;

                //Пробег в метрах 
                sm = (totalPixels * 0.3) / 10000;
                // Отображаем :
                this.lblProbeg.Text = "Пробег мышки = " + totalPixels + " пикселей = " + sm + " метров.";
            }
            // Назначаем следующую позицию курсора стартовой:
            currX = defPnt.X;
            currY = defPnt.Y;
        }
    }
}
