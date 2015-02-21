using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Пользователь щёлкает мышкой как можно быстрее: через 20 секунд выводится мессадж бокс, который
 * сообщает сколько было кликов сделано за это время. Реализовать таблицу рекордов: сообщается текущий
 * результат, самый лучший результат, и если текущий результат больше чем самый лучший — выдаётся поздравление.*/

namespace кликер
{
    public partial class Form1 : Form
    {
        int click;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Всего кликов - " + click.ToString());
            click = 0;
            
            bStart.Visible = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            timer2.Start();
            ++click;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (timer2.Enabled)
                ++click;

            timer2.Stop();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            click = 0;
            timer1.Start();
            bStart.Visible = false;
        }

    }
}
