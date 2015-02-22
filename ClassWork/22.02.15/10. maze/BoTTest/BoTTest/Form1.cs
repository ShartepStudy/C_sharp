using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoTTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        //Финиш
        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы выиграли!");
            Close();
        }

        //Старт
        private void MoveToStart()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);

        }

        //На странт при косании стены
        private void wall_MouseEnter(object sender, EventArgs e)
        {
            //MessageBox.Show("Проиграл!");
            MoveToStart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
