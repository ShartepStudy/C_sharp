﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Tick();
            timer1.Start();
        }

      
        void Tick()
        {
            // Представляет последовательность соединенных линий и кривых. 
            GraphicsPath myPath = new GraphicsPath();
            DateTime dt = DateTime.Now;// получим текущее время
            string str = String.Format("{0:D2}:{1:D2}:{2:D2}", dt.Hour, dt.Minute, dt.Second);
            FontFamily family = new FontFamily("Arial");//семейство шрифтов
            int fontStyle = (int)FontStyle.Italic;// курсивное начертание
            fontStyle |= (int)FontStyle.Bold; // полужирное начертание
            int emSize = 200; // Высота рамки максимального пробела, ограничивающей символ. 
            Point origin = new Point(20, 20); // Объект Point, представляющий точку начала текста. 
           // Объект StringFormat задает информацию о форматировании текста, такую как интервал между строками и выравнивание. 
            StringFormat format = StringFormat.GenericDefault;
            // AddString - добавляет строку текста в траекторию
            myPath.AddString(str,
                family,
                fontStyle,
                emSize,
                origin,
                format);

            Region rgn1 = new Region(myPath); // создаем регион на основе траектории
            this.Region = rgn1; // применяем регион к форме
            this.BackColor = Color.DarkViolet;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tick();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                Close();
        }
    }
}
 