using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
// Для класса ArrayList
using System.Collections;
using System.Diagnostics;

// Класс, реализующий экранную заставку
namespace ScreenSaver
{
    class ScreenSaver : Form
    {
        // Позиция курсора на момент запуска программы
        Point StartCursorPosition = Control.MousePosition;
        // Таймер для смены изображений
        Timer tm = new Timer();
        // Изображение
        Image im = null;
        // Список путей к изображениям
        ArrayList PathList;
        // Размеры графической поверхности
        RectangleF ScreenRect;
        // Объект класса, который предоставляет методы
        // для рисования объектов на графическом устройстве
        Graphics gr = null;

        // Мютекс для предотвращения запусков
        // нескольких экземпляров данного приложения
        static System.Threading.Mutex mutex;

        // Путь к каталогу с изображениями
        static string Path;

        static void Main(string[] args /* параметры командной строки */)
        {
            // Запуск приложения
            Application.Run(new ScreenSaver());
        }

        // Конструктор
        ScreenSaver()
        {
            // Цвет фона формы
            this.BackColor = Color.Black;
            // Убираем у формы рамку
            this.FormBorderStyle = FormBorderStyle.None;

            // Прячем курсор
            Cursor.Hide();

            // Растягиваем форму на весь экран
            this.ClientSize = Screen.GetBounds(this).Size;
            // Установка расположения формы
            this.Location = new Point(0, 0);

            // Убираем приложение из панели задач
            this.ShowInTaskbar = false;

            // Обработчик таймера
            tm.Tick += new EventHandler(tm_Tick);
            tm.Interval = 1000;
        }

        // Обработчик нажатия клавиш
        protected override void OnKeyDown(KeyEventArgs e)
        {
            // Закрываем приложение
            Application.Exit();
        }

        // Обработчик движения мыши
        protected override void OnMouseMove(MouseEventArgs e)
        {
            // Если с момента запуска приложения мышь дернулась
            if (StartCursorPosition != Control.MousePosition)
            {
                // Закрываем приложение
                Application.Exit();
            }
        }

        // Обработчик отрисовки поверхности формы
        protected override void OnPaint(PaintEventArgs e)
        {

            // Графическая поверхность формы
            gr = e.Graphics;


            // Определяем размеры видимой поверхности
            ScreenRect = gr.VisibleClipBounds;


            // Создаем черную кисть
            Brush br = new SolidBrush(Color.Black);
            // Заливаем поверхность 
            // (стираем предыдущее изображение)
            gr.FillRectangle(br, ScreenRect);

            // Если список файлов пуст
            if (PathList != null && PathList.Count == 0)
            {
                // Создаем синюю кисть
                br = new SolidBrush(Color.Blue);
                // Создаем шрифт
                Font font = new Font("Times New Roman", 12);
                // Отрисовываем строку
                gr.DrawString("Каталог\n" + Path + "\nпуст!", font, br, 0, 0);
            }
            else if (PathList != null)
            {
                // Вычисляем коэффициент пропорциональности
                // для показа изображения на весь экран
                SizeF sizef = new SizeF(im.Width / im.HorizontalResolution,
                                        im.Height / im.VerticalResolution);
                float Scale = Math.Min(ScreenRect.Width / sizef.Width,
                                       ScreenRect.Height / sizef.Height);
                // Пропорционально изменяем размер изображения
                sizef.Width *= Scale;
                sizef.Height *= Scale;

                // Отрисовываем изображение
                gr.DrawImage(im,
                   ScreenRect.X + (ScreenRect.Width - sizef.Width) / 2,
                   ScreenRect.Y + (ScreenRect.Height - sizef.Height) / 2,
                   sizef.Width, sizef.Height);

                tm.Interval = 3000;
            }

            base.OnPaint(e);

            // Запуск таймера
            tm.Start();
        }

        // Обработчик таймера
        private void tm_Tick(object sender, EventArgs e)
        {
            // Останавливаем таймер
            tm.Stop();

            // Запускаем поиск изображений в указанном 
            // пользователем каталоге
            if (PathList == null)
                SearchPictures();

            // Текущее изображение
            string picture = null;

            // Если каталог существует
            if (PathList != null)
            {
                // Если в каталоге присутствуют изображения
                if (PathList.Count == 0)
                {
                    // Перерисовываемся (на экран выводится строка текста)
                    Invalidate();
                    return;
                }

                // Инициализируем генератор случайных чисел
                Random rand = new Random();
                // Выбираем случайное изображение из списка
                picture = (string)PathList[rand.Next(PathList.Count)];
            }
            else  // Указанный каталог не доступен
            {
                // Подставляем стандартный каталог Windows
                // для хранения изображений
                Path = @"C:\Users\Public\Pictures\Sample Pictures";
                tm.Interval = 100;
                // Запуск таймера
                tm.Start();
                return;
            }

            try
            {
                // Считываем картинку из файла
                im = Image.FromFile(picture);
            }
            catch
            {
                // Неудача
                im = null;
                tm.Interval = 100;
                // Запуск таймера (повторный вызов функции)
                tm.Start();
                return;
            }

            // Перерисовываемся
            Invalidate();
        }

        // Функция поиска изображений
        void SearchPictures()
        {
            try
            {
                // Ищем в каталоге картинки
                string[] files1 = Directory.GetFiles(Path, "*.jpg");
                string[] files2 = Directory.GetFiles(Path, "*.bmp");

                // Создаем общий список найденных файлов
                // и сгружаем в него найденные пути
                PathList = new ArrayList(files1.Length + files2.Length);
                PathList.AddRange(files1);
                PathList.AddRange(files2);
            }
            catch
            {
                // Проблемы
                PathList = null;
            }
        }
    }
}