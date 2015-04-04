using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NTetris.Properties;
using sounds;


namespace NTetris
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            defaultOptions(12, 20);// настройка размеров поля

            // взять тексты меню из ресурсов
            новаяИграToolStripMenuItem1.Text = Resources.new_game;
            паузаToolStripMenuItem.Text = Resources.pause;
            продолжитьToolStripMenuItem.Text = Resources.nopause;
            остановитьИгруToolStripMenuItem.Text = Resources.stop_game;
            сохранитьИгруToolStripMenuItem.Text = Resources.save_game;
            выходToolStripMenuItem1.Text = Resources.exit_game;

            toolStripButton1.Text = Resources.new_game;
            toolStripButton2.Text = Resources.pause;
            toolStripButton3.Text = Resources.nopause;
            toolStripButton4.Text = Resources.stop_game;
            toolStripButton5.Text = Resources.save_game;
            toolStripButton7.Text = Resources.exit_game;

        }

        //размеры игрового поля
        public static int mX, mY;
        //интервалы таймера
        public static int timerFast, timerSlow;
        //расположение фигуры на игровом поле
        public int xfig, yfig;
        public bool generate;
        //таблица со значениями клеток
        public int[,] cell; // тут образ игрового поля числа обозначают цвета фигур
        public int[,] cellBuffer;
        //массив фигуры
        public int[,] figure; // тут лежат образы всех фигур
        //активация клавиш
        public bool activeKey;
        //активность игры
        public bool game;
        //сохранение игры
        public bool saved;
        //размерность массива фигуры
        public WiHd coords;
        //следующаяя фигура
        public int nextFigure;
        //подсчёт уровней
        public int level;
        //подсчёт очков
        public int point;

        public int fc;//цвет текущей фиругы
        public int nfc;//цвет следующей фигуры
        
        Image cellPallete;

        fSounds soundPlayer;
        
        public saveProcess.saveOptions options;//настройки игры там храняться

        public class WiHd
        {
            public WiHd(int endX, int endY)
            {
                eX = endX;
                eY = endY;
            }

            public int eX,
                eY,
                cX,
                cY;
        }

        //настройки формы и компонентов по умолчанию
        public void defaultOptions(int cellWidth, int cellHeight)
        {
            //ячеёки по ширине
            mX = cellWidth;
            //ячейки по высоте
            mY = cellHeight;
            //быстрый спуск
            timerFast = 10;
            //обычный спуск
            timerSlow = 700;

            //устанавливаем установки по умолчанию
            try
            {
                resetGame();
            }
            catch
            {
                MessageBox.Show("Ошибка!!! Перезапустите игру!", 
                    "Ошибка!!!Пререустановите программу Тетрис!!!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }

            //задаём размер 
            pallete.Width = mX * 15;
            pallete.Height = mY * 15;
            pallete.Top = menu.Height+toolStrip1.Height + 3;
            pallete.Left = 3;

            //задаём позицию лэйбла
            label1.Left = ((pallete.Width / 2) - (label1.Width / 2)) + pallete.Left;
            label1.Top = ((pallete.Height / 2) - (label1.Height / 2)) + pallete.Top;

            nextFigurePallete.Left = pallete.Width + 6;
            nextFigurePallete.Top = menu.Height + toolStrip1.Height + 3;
            nextFigurePallete.Width = 3 * 15;
            nextFigurePallete.Height = 4 * 15;

            //задаём размеры формы
            Width = (pallete.Width + (Width - ClientSize.Width) + 9) + nextFigurePallete.Width;
            Height = (pallete.Height + (Height - ClientSize.Height) + 6) + menu.Height + toolStrip1.Height;

            information.Width = nextFigurePallete.Width;
            information.Top = menu.Height + toolStrip1.Height + nextFigurePallete.Height + 6;
            information.Left = pallete.Width + 6;

            //cell_1 = new Bitmap(NTetris.Properties.Resources.cell_1);
            //cell_0 = new Bitmap(NTetris.Properties.Resources.cell_0);
        }

        public void levelInformation()
        {
            String str = "Уровень";
            str += "\r\n" + level.ToString();
            str += "\r\n\r\n" + "Очки";
            str += "\r\n" + (point * level);
            information.Text = str;
        }

        //установки  по умолчанию
        public void resetGame()
        {
            timer.Interval = timerSlow;
            cell = new int[mX, mY];
            cellBuffer = new int[mX, mY];
            brushCells();
            arrayCopy(ref cellBuffer, cell);
            xfig = 0;
            yfig = 0;
            generate = false;
            activeKey = false;
            game = false;
            Random r = new Random();
            soundPlayer = new fSounds();
            nextFigure = r.Next(0, 7);
            point = 0;
            level = 1;
            timerSlow = 700;

            if (saveProcess.ifSave(ref options))
                saved = true;
            else
                saved = false;

            options = new saveProcess.saveOptions();
            if (timer.Enabled)
            {
                остановитьИгруToolStripMenuItem.Enabled = true;
                паузаToolStripMenuItem.Enabled = true;
            }
            else
            {
                остановитьИгруToolStripMenuItem.Enabled = false;
                паузаToolStripMenuItem.Enabled = false;
            }
        }

        //копирование массивов
        public void arrayCopy(ref int[,] outArray, int[,] inArray)
        {
            for (int Y = 0; Y < mY; Y++)
                for (int X = 0; X < mX; X++)
                    outArray[X, Y] = inArray[X, Y];
        }

        //заполнение массива игрового поля (cell) пустыми ячейками
        private void brushCells()
        {
            for (int Y = 0; Y < mY; Y++)
                for (int X = 0; X < mX; X++)
                    cell[X, Y] = 0;
        } 

        //меняем местами значения
        private void swap(ref int first, ref int second)
        {
            int buffer = first;
            first = second;
            second = buffer;
        }

        //поворот фигуры
        public void rotateFigure()
        {
            swap(ref coords.eX, ref coords.eY);
            int[,] figureBuffer = new int[coords.eX, coords.eY];
            int x = 0, y = coords.eX - 1;
            for (int Y = 0; Y < coords.eY; Y++)
            {
                for (int X = 0; X < coords.eX; X++)
                {
                    figureBuffer[X, Y] = figure[x, y];
                    y--;
                }
                x++;
                y = coords.eX - 1;
            }
            figure = figureBuffer;
        }


        //генерация фигуры
        public void generateFigure(int f, ref int[,] fig, ref WiHd coor,ref int cl)
        {
            
            Random r = new Random();            
            //int color = r.Next(1, 8);//цвет фигуры
            //if (cl > 0) color = cl;
            int color = f + 1; // цвет привязан к фигуре
            if (cl == 0) cl = color;//возвращаем цвет сгенерированой фиругы
           
            switch (/*r.Next(0, 5)*/f)
            {
                case 0:
                    /*
                       ###
                     ###
                     */
                    fig = new int[,]{
                        { 0, color, color }, 
                        { color, color, 0 },
                    };
                    coor = new WiHd(2, 3);
                    break;
                case 5:
                    /*
                    ###
                      ###
                     */
                    fig = new int[,]{
                        { color, color, 0 }, 
                        { 0, color, color },
                    };
                    coor = new WiHd(2, 3);
                    break;
                case 1:
                    /*
                     ####
                      ##
                     */
                    fig = new int[,]{
                        { color, color, color }, 
                        { 0, color, 0 },
                    };
                    coor = new WiHd(2, 3);
                    break;              
                case 2:
                    /*
                     #### 
                     */
                    fig = new int[,]{
                        { color, color, color,color }, 
                    };
                    coor = new WiHd(1, 4);
                    break;

                case 3:
                    /*
                         #
                     #####
                     */
                    fig = new int[,]{
                        { 0, 0, color }, 
                        { color, color, color },
                    };
                    coor = new WiHd(2, 3);
                    break;
                case 6:
                    /*
                     #
                     #####
                     */
                    fig = new int[,]{
                        { color, 0, 0 }, 
                        { color, color, color },
                    };
                    coor = new WiHd(2, 3);
                    break;
                case 4:
                    /*
                     #####
                     #####
                     #####
                     */
                    fig = new int[,]{
                        { color, color }, 
                        { color, color },
                    };
                    coor = new WiHd(2, 2);
                    break;
            }
        }

        //очищаем заполненный ряд
        private void clean(int index)
        {
            for (int y = index; y > 0; y--)
                for (int x = 0; x < mX; x++)
                    cellBuffer[x, y] = cell[x, y - 1];
        }

        //находим заполненный ряд
        public void lineCleaner()
        {
            int i = 0;
            for (int y = 0; y < mY; y++)
            {
                for (int x = 0; x < mX; x++)
                    if (cellBuffer[x, y]>0)
                        i++;
                if (i == mX)
                {
                    clean(y);
                    arrayCopy(ref cell, cellBuffer);
                    point++;
                    soundPlayer.playSound("clear-line");
                }
                i = 0;
            }
        }

        //запрещаем передвижение фигуры по бокам в тоннелях
        public bool tonel(bool left)
        {
            int xLeft = xfig - 1,
                xRight = xfig + coords.eX,
                Y = yfig,
                i = 0;

            bool returned = true;

            if (xLeft < 0)
                xLeft = 0;

            if (xRight > mX - 1)
                xRight = mX - 1;

            while (i < coords.eY && Y <= mY)
            {
                if (cellBuffer[xLeft, Y]>0 && left)
                    returned = false;

                if (cellBuffer[xRight, Y]>0 && !left)
                    returned = false;

                i++;
                Y++;
            }

            return returned;
        }

        //детектор падения фигуры
        private bool detector(int x, int y, int eX, int eY)
        {
            int xF = 0,
                yF = 0,
                X = x,
                Y = y;

            bool returned = true;

            if (Y > mY - coords.eY)
                Y = mY - coords.eY;

            if (yfig + coords.eY < mY)
                while (Y < eY && returned)
                {
                    while (X < eX && returned)
                    {
                        if (cellBuffer[X, Y]>0 && figure[xF, yF]>0)
                        {
                            returned = false;
                            if (yfig < coords.eY)
                                game = false;
                        }
                        X++;
                        xF++;
                    }
                    Y++;
                    yF++;
                    X = x;
                    xF = 0;
                }
            else
                returned = false;
            return returned;
        }

        //перенос массива фигуры на массив изображения
        public bool arrayToArray(int x, int y)
        {
            int xF = 0,
                yF = 0,
                yCoord = y + coords.eY,
                xCoord = x + coords.eX;

            if (yCoord > mY)
            {
                yCoord = mY;
                y = mY - coords.eY;
                yfig = y;
            }

            if (xCoord > mX)
            {
                xCoord = mX;
                x = mX - coords.eX;
                xfig = x;
            }

            for (int Y = y; Y < yCoord; Y++)
            {
                for (int X = x; X < xCoord; X++)
                {
                    if (X < mX && Y < mY)
                        if (figure[xF, yF]>0)
                            cell[X, Y] = figure[xF, yF];
                    xF++;
                }
                yF++;
                xF = 0;
            }
            return detector(x, y + 1, xCoord, yCoord + 1);
        }

        // преобразование из кода в цвет
        private Color colorFromCode(int code)
        {
            switch (code)
            {
                case 0:
                    return Color.Red;
                case 1:
                    return Color.Orange;
                case 2:
                    return Color.Yellow;
                case 3:
                    return Color.Green;
                case 4:
                    return Color.Blue;
                case 5:
                    return Color.Aqua;
                case 6:
                    return Color.Violet;
                case 7:
                    return Color.YellowGreen;
            }
            return Color.Black;
        }

        // рисование пустой ячейки
        private void DrawClearCell(Graphics gr, int x,int y)
        {
            Pen pen = new Pen(Color.DarkGray, 1);            
            SolidBrush br = new SolidBrush(Color.Gray);
            gr.FillRectangle(br, x, y, 15, 15);
            gr.DrawRectangle(pen,x,y,15,15);            
        }

        //рисование заполненой ячейки
        private void DrawFigCell(Graphics gr, int x, int y, int code)
        {
            Pen pen = new Pen(Color.White, 1);
            Pen pen2 = new Pen(Color.Gray, 1);
            SolidBrush br = new SolidBrush(colorFromCode(code));
            gr.FillRectangle(br,x,y,15,15);
            gr.DrawLine(pen2, x, y + 15, x + 15, y + 15);
            gr.DrawLine(pen2, x + 15, y, x + 15, y + 15);
            gr.DrawLine(pen, x, y, x + 15, y);
            gr.DrawLine(pen, x, y, x, y + 15);            
        }

        //прорисовка следующего изображения
        public void drawNextFigure(int[,] nextFig, WiHd c)
        {
            Image nextFigureImg = new Bitmap(nextFigurePallete.Width, nextFigurePallete.Height);
            using (Graphics g = Graphics.FromImage(nextFigureImg))
            {
                int x, y;
                x = nextFigurePallete.Width;
                y = nextFigurePallete.Height;
                for (int Y = 0; Y < 4; Y++)
                    for (int X = 0; X < 3; X++)
                    {
                        if (Y < c.eY && X < c.eX)
                            if (nextFig[X, Y]>0)
                                //g.DrawImage(cell_1, X * (x / 3), Y * (y / 3), 15, 15);
                                DrawFigCell(g, X * (x / 3), Y * (y / 4), nextFig[X, Y]);
                            else
                                // g.DrawImage(cell_0, X * (x / 3), Y * (y / 3), 15, 15);
                                DrawClearCell(g, X * (x / 3), Y * (y / 4));
                        else
                        {
                            //   g.DrawImage(cell_0, X * (x / 3), Y * (y / 3), 15, 15);
                            DrawClearCell(g, X * (x / 3), Y * (y / 4));
                        }
                    }
                nextFigurePallete.Image = nextFigureImg;
            }
        }

        //прорисовка изображения
        public void drawCells()
        {            
            cellPallete = new Bitmap(pallete.Width, pallete.Height);
            
            using (Graphics g = Graphics.FromImage(cellPallete))
            {
                int x, y;
                x = pallete.Width;
                y = pallete.Height;
                for (int Y = 0; Y < mY; Y++)
                    for (int X = 0; X < mX; X++)
                    {
                        if (cell[X, Y]>0)
                            // g.DrawImage(cell_1, X * (x / mX), Y * (y / mY), 15, 15);
                            DrawFigCell(g, X * (x / mX), Y * (y / mY), cell[X, Y]);
                        else
                            //g.DrawImage(cell_0, X * (x / mX), Y * (y / mY), 15, 15);
                            DrawClearCell(g, X * (x / mX), Y * (y / mY));
                    }
               
                    pallete.Image = cellPallete;
            }
        
        }
 
        //установка видимости меню сохранения
        public void saveMenu()
        {
            if (saveProcess.ifSave(ref options))
            {
                сохранитьИгруToolStripMenuItem.Text = Resources.restore_game;
                toolStripButton5.Text = Resources.restore_game;
                сохранитьИгруToolStripMenuItem.Enabled = true;
                очиститьСохранениеToolStripMenuItem.Visible = true;
                toolStripButton6.Visible = true;
                saved = true;
            }
            else
            {
                сохранитьИгруToolStripMenuItem.Text = Resources.save_game;
                toolStripButton5.Text = Resources.save_game;
                сохранитьИгруToolStripMenuItem.Enabled = false;
                очиститьСохранениеToolStripMenuItem.Visible = false;
                toolStripButton6.Visible = false;
                saved = false;
            }
        }

        //очистка сохранения
        public void clearSave()
        {
            saveProcess.clearFile();
            saved = false;
            очиститьСохранениеToolStripMenuItem.Visible = false;
            toolStripButton6.Visible = false;
            сохранитьИгруToolStripMenuItem.Text = Resources.save_game;
            toolStripButton5.Text = Resources.save_game;
            if (!timer.Enabled)
                сохранитьИгруToolStripMenuItem.Enabled = false;
        }

        
        //начало игры
        public void startGame()
        {
            timer.Enabled = true;
            resetGame();
            drawCells();
            levelInformation();
            остановитьИгруToolStripMenuItem.Enabled = true;
            паузаToolStripMenuItem.Enabled = true;
            toolStripButton2.Visible = true;
            toolStripButton3.Visible = false;
            toolStripButton4.Visible = true;
            activeKey = false;
            label1.Visible = false;
            game = true;

            if (!saved)
                сохранитьИгруToolStripMenuItem.Enabled = true;
        }

        //загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                drawCells();
                drawNextFigure(cell, new WiHd(3, 3));
                levelInformation();
                saveMenu();
            }
            catch 
            {
                Application.ExitThread();
            }
        }

        //таймер
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!game)
            {
                timer.Enabled = false;
                остановитьИгруToolStripMenuItem.Enabled = false;
                паузаToolStripMenuItem.Enabled = false;
                MessageBox.Show(Resources.game_end);
            }
            else
            {

                if (!generate)
                {
                    Random r = new Random();
                    options.figure = nextFigure;
                    fc = nfc;
                    nfc = 0;
                    generateFigure(nextFigure, ref figure, ref coords,ref nfc);
                    for (int i = 0; i < r.Next(1, 3); i++)
                        rotateFigure();
                    generate = true;
                    activeKey = true;
                    nextFigure = r.Next(0, 7);
                    options.nextFigure = nextFigure;
                    int[,] nFig = new int[3, 3];
                    WiHd c = new WiHd(0, 0);
                    fc = nfc;
                    nfc = 0;
                    generateFigure(nextFigure, ref nFig, ref c,ref nfc);
                    drawNextFigure(nFig, c);
                    lineCleaner();
                    timer.Interval = timerSlow;

                    if (point >= 10)
                    {
                        level++;
                        timerSlow -= 50;
                        timer.Interval = timerSlow;
                        point = 0;
                    }

                    levelInformation();
                }

                arrayCopy(ref cell, cellBuffer);

                if (arrayToArray(xfig, yfig))
                    yfig++;
                else
                {
                    arrayCopy(ref cellBuffer, cell);
                    yfig = 0;
                    generate = false;
                    activeKey = false;
                    soundPlayer.playSound("figure-fall");
                }
            }

            drawCells(); 
        }

        //нажатие кнопок
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(functions.isButtons(e))
                if (game)
                {
                    if (!timer.Enabled)
                        паузаToolStripMenuItem_Click(null, null);
                }
                else
                    startGame();

            if (activeKey)
            {
                if (e.KeyCode == Keys.P)
                    if (timer.Enabled)
                    {
                        timer.Enabled = false;
                        label1.Visible = true;
                        продолжитьToolStripMenuItem.Visible = true;
                        паузаToolStripMenuItem.Visible = false;
                        toolStripButton2.Visible = false;
                        toolStripButton3.Visible = true;
                    }
                    else
                    {
             //           label1.Visible = false;
             //           timer.Enabled = true;
                    }
                if (e.Control && e.KeyCode == Keys.P)
                {
                         label1.Visible = false;
                         timer.Enabled = true;
                         продолжитьToolStripMenuItem.Visible = false;
                         паузаToolStripMenuItem.Visible = true;
                         toolStripButton2.Visible = true;
                         toolStripButton3.Visible = false;
                }

                if ((e.KeyCode == Keys.Left && xfig > 0) && tonel(true))
                    xfig--;
                if ((e.KeyCode == Keys.Right && xfig < mX - coords.eX) && tonel(false))
                    xfig++;
                if (e.KeyCode == Keys.Up)
                    rotateFigure();
                if (e.KeyCode == Keys.Down)
                {
                    timer.Interval = timerFast;
                    activeKey = false;
                }
                arrayCopy(ref cell, cellBuffer);
                arrayToArray(xfig, yfig);
                drawCells();
            }
        }

        //меню, новая игра
        private void новаяИграToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            startGame();
        }

        //меню, выход
        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //меню, о программе
        private void оПрограммеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            aboutForm f = new aboutForm();
            f.ShowDialog();
        }

        //меню, остановить игру
        private void остановитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            resetGame();
            drawCells();
            drawNextFigure(cell, new WiHd(3, 3));
            levelInformation();
            остановитьИгруToolStripMenuItem.Enabled = false;
            паузаToolStripMenuItem.Enabled = false;
            toolStripButton2.Visible = false;
            toolStripButton3.Visible = false;
            toolStripButton4.Visible = false;
            if(!saveProcess.ifSave(ref options))
                сохранитьИгруToolStripMenuItem.Enabled = false;
        }

        //меню, пауза
        private void паузаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Enabled = false;
                label1.Visible = true;
                продолжитьToolStripMenuItem.Visible = true;
                паузаToolStripMenuItem.Visible = false;
                toolStripButton2.Visible = false;
                toolStripButton3.Visible = true;
            }
            else
            {
              //  timer.Enabled = true;
              //  label1.Visible = false;
            }
        }

          private int getFigureColor()
        {
            return fc;
        }

        private int getNextFigureColor()
        {
            return nfc;
        }

        //меню, сохранить игру
        private void сохранитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!saved)
            {
                options.coords = new WiHd(mX, mY);
                options.cells = cellBuffer;
                options.x = xfig;
                options.y = yfig;
                options.level = level;
                options.point = point;
                options.timer = timer.Interval;
                options.fc = getFigureColor();
                options.nfc = getNextFigureColor();
                saveProcess.saveToFile(options);
                сохранитьИгруToolStripMenuItem.Text = Resources.restore_game;
                toolStripButton5.Text = Resources.restore_game;
                очиститьСохранениеToolStripMenuItem.Visible = true;
                toolStripButton6.Visible = true;
                saved = true;
            }
            else
            {
                saveProcess.saveOptions s = new saveProcess.saveOptions();
                if (saveProcess.ifSave(ref s))
                {
                   // resetGame();
                    defaultOptions(s.coords.eX, s.coords.eY);
                    game = true;
                    generate = true;
                    activeKey = true;
                    Focus();
                    timer.Enabled = true;
                    mX = s.coords.eX;
                    mY = s.coords.eY;
                    cellBuffer = s.cells;
                    xfig = s.x;
                    yfig = s.y;
                    saved = true;
                    point = s.point;
                    level = s.level;
                    nextFigure = s.nextFigure;
                    timer.Interval = s.timer;
                    timerSlow = s.timer;
                    generateFigure(s.figure, ref figure, ref coords,ref s.fc);
                    label1.Visible = false;
                    остановитьИгруToolStripMenuItem.Enabled = true;
                    паузаToolStripMenuItem.Enabled = true;

                    int[,] nFig = new int[3, 3];
                    WiHd c = new WiHd(0, 0);

                    generateFigure(s.nextFigure, ref nFig, ref c,ref s.nfc);

                    arrayCopy(ref cell, cellBuffer);
                    drawNextFigure(nFig, c);
                    drawCells();

                }
                else
                    очиститьСохранениеToolStripMenuItem_Click(null, null);
            }
        }

        //меню, очистить сохранение
        public void очиститьСохранениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearSave();
        }

        private void продолжитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            timer.Enabled = true;
            продолжитьToolStripMenuItem.Visible = false;
            паузаToolStripMenuItem.Visible = true;
            toolStripButton2.Visible = true;
            toolStripButton3.Visible = false;
        }
    }
}