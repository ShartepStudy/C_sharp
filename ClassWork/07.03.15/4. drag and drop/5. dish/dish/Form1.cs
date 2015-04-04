using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dish
{
    public partial class Form1 : Form
    {
        //Kokteyl kok = new Kokteyl("Ананасово-имбирный смузи", "ананас", "банан", "греческий йогурт", "тертый свежий имбирь", "лед", "ананасовый сок");
        Kokteyl[] massKok = new Kokteyl[6];
        //string[] spisokIngr;
        public Form1()
        {
            InitializeComponent();
            massKok[0] = new Kokteyl("Ананасово-имбирный смузи", "ананас", "банан", "греческий йогурт", "тертый свежий имбирь", "лед", "ананасовый сок");
            massKok[1] = new Kokteyl("Смузи из киви", "киви", "яблоко", "лимон","яблочный сок","молотая корица","сахар","лед");
            massKok[2] = new Kokteyl("Молочный шейк с черникой", "молоко", "сахар", "черника", "лед");
            massKok[3] = new Kokteyl("Лимонад Дюшес", "груша", "лимон", "сахар", "содовая", "лед");
            massKok[4] = new Kokteyl("Безалкогольный мохито", "лайм", "сахар темно-коричневый", "содовая", "мята свежая", "сироп гренадин");
            massKok[5] = new Kokteyl("Лимонный пунш", "чай черный", "лимон", "ром темный", "сахар");
            
            foreach (Kokteyl item in massKok)
            {
                comboBox1.Items.Add(item.Name);
            }
        }

        private void label3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int indexOfItem = listBox1.IndexFromPoint(e.X, e.Y);
            if (indexOfItem >= 0 && indexOfItem
              < listBox1.Items.Count)  // check we clicked down on a string
            {
                // Set allowed DragDropEffect to Copy selected 
                // from DragDropEffects enumberation of None, Move, All etc.
                listBox1.DoDragDrop(listBox1.Items[indexOfItem], DragDropEffects.Copy);
            }
        }

        private void label3_DragDrop(object sender, DragEventArgs e)
        {
            string[] str = label3.Text.Split('\n');
            if (str.Contains(e.Data.GetData(DataFormats.StringFormat).ToString()))
                 return;
            label3.Text += e.Data.GetData(DataFormats.StringFormat).ToString() + '\n';
        }

        private void button2_Click(object sender, EventArgs e)
        {

            CheckKoktel(label3.Text.Split('\n'));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
        }
        private bool CompareStringArray(string[] arr0, string[] arr1)
        {
            Array.Sort(arr0);
            Array.Sort(arr1);
            if (arr0.Length != arr1.Length) return false;
            for (int i = 0; i < arr0.Length; i++)
                if (arr0[i] != arr1[i]) return false;
            return true;
        }
        private void CheckKoktel(string[] str)
        {
            Array.Resize<string>(ref str, str.Length - 1);
            foreach (Kokteyl kok in massKok)
            {
                bool chk = CompareStringArray(str, kok.mass);
                if (chk)
                {
                    MessageBox.Show("Получили \"" + kok.Name + "\"");
                    return;
                }
            }
            MessageBox.Show("УПС!");
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string str = ((ComboBox)sender).Text;
            listBox2.Items.Clear();
            foreach (Kokteyl kok in massKok)
            {
                if (kok.Name == str)
                {
                    listBox2.Items.AddRange(kok.mass);
                }

            }
        }
    }
}
