using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace NTetris
{
    public class saveProcess
    {
        //параметры для сохранения
        public class saveOptions
        {
            public saveOptions()
            {
                coords = new mainForm.WiHd(12, 20);
            }

            public int[,] cells;
            public int x, y;
            public int figure, nextFigure,fc,nfc;
            public int level, point;
            public mainForm.WiHd coords;
            public int timer;
        }

        //очистка файла
        public static void clearFile()
        {
            using (StreamWriter write = new StreamWriter("conf.ini"))
            {
                write.WriteLine("");
                write.Close();
            }
        }

        //сохраняем параметры в файл
        public static void saveToFile(saveOptions opts)
        {
            using (StreamWriter write = new StreamWriter("conf.ini"))
            {
                write.WriteLine(opts.coords.eX);
                write.WriteLine(opts.coords.eY);
                for (int i = 0; i < opts.coords.eY; i++)
                {
                    String str = "";
                    for (int l = 0; l < opts.coords.eX; l++)
                    {
                        if (str.Length > 0) str += " ";
                        str += opts.cells[l, i].ToString();
                    }
                    write.WriteLine(str);
                }

                write.WriteLine("endOfCell");

                write.WriteLine(opts.figure);
                write.WriteLine(opts.nextFigure);

                write.WriteLine("endOfFigure");
                write.WriteLine(opts.x);
                write.WriteLine(opts.y);
                write.WriteLine(opts.point);
                write.WriteLine(opts.level);
                write.WriteLine(opts.timer);
                write.WriteLine(opts.fc);
                write.WriteLine(opts.nfc);
                write.Close();
                write.Dispose();
            }
        }

        //обрабатываем параметры
        public static bool ifSave(ref saveOptions opts)
        {
            bool returned = true;

            List<string> lst = new List<string>();

            if (File.Exists("conf.ini"))
            {
                //читаем файл в строковый массив
                using (StreamReader reader = new StreamReader("conf.ini"))
                {
                    while (!reader.EndOfStream)
                        lst.Add(reader.ReadLine());
                }

                //вслучае ошибки параметров в файле генерируем исключение
                try
                {
                    //читаем количество ячеек по ширеине
                    opts.coords.eX = Convert.ToInt32(lst[0]);
                    if (!(opts.coords.eX == 12 || opts.coords.eX == 15 || opts.coords.eX == 17))
                        returned = false;

                    //читаем количество ячеек по высоте
                    opts.coords.eY = Convert.ToInt32(lst[1]);
                    if (!(opts.coords.eY == 20 || opts.coords.eY == 25 || opts.coords.eY == 30))
                        returned = false;

                    //выделяем место в массиве для игрового поля
                    opts.cells = new int[opts.coords.eX, opts.coords.eY];

                    //считываем значения массива из файла
                    for (int Y = 0; Y < opts.coords.eY; Y++)
                    {
                        String str = lst[Y + 2];
                        String[] a = str.Split(' ');
                        for (int l = 0; l < opts.coords.eX; l++)
                        {
                            opts.cells[l, Y] = int.Parse(a[l]);                           
                        }
                    }

                    //текущая фигура
                    opts.figure = Convert.ToInt32(lst[3 + opts.coords.eY]);
                    if (!(opts.figure >= 0 && opts.figure <= 4))
                        returned = false;

                    //следующая фигура
                    opts.nextFigure = Convert.ToInt32(lst[4 + opts.coords.eY]);
                    if (!(opts.nextFigure >= 0 && opts.nextFigure <= 4))
                        returned = false;

                    //считываем координату нахождения фигуры по ширине массиво
                    opts.x = Convert.ToInt32(lst[6 + opts.coords.eY]);
                    if (!(opts.x >= 0 && opts.x < opts.coords.eX))
                        returned = false;

                    //считываем координату нахождения фигуры по высоте массива
                    opts.y = Convert.ToInt32(lst[7 + opts.coords.eY]);
                    if (!(opts.y >= 0 && opts.y < opts.coords.eY))
                        returned = false;

                    //очки
                    opts.point = Convert.ToInt32(lst[8 + opts.coords.eY]);
                    if (!(opts.point >= 0 && opts.point < 99999))
                        returned = false;

                    //уровень
                    opts.level = Convert.ToInt32(lst[9 + opts.coords.eY]);
                    if (!(opts.level > 0 && opts.level < 99999))
                        returned = false;

                    //таймер
                    opts.timer = Convert.ToInt32(lst[10 + opts.coords.eY]);
                    if (!(opts.timer > 0 && opts.timer < 1000))
                        returned = false;
                    // цвет текущей фиругы
                    opts.fc = Convert.ToInt32(lst[11 + opts.coords.eY]);
                    if (!(opts.fc > 0 && opts.fc < 8))
                        returned = false;
                    // цвет следующей фигуры
                    opts.nfc = Convert.ToInt32(lst[12 + opts.coords.eY]);
                    if (!(opts.nfc > 0 && opts.nfc < 8))
                        returned = false;
                }
                catch { returned = false; }
            }
            else
                returned = false;
            
            return returned;
        }
    }
}
