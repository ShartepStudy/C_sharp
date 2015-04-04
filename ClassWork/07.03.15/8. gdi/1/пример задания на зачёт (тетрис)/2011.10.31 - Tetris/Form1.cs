using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _2011._10._31___Tetris
{
    struct Settings
    {
        public static Point dimensions = new Point(10, 20);
        public static UInt16 speed = 1;
    }

    public partial class Form1 : Form
    {
        public static Point PlaneDimensions = new Point(10, 20);

        private Block[,] _plane;
        private bool _isGameStarted = false;
        private Timer _fallTimer = new Timer();
        private Shape _currShape;
        private Shape _nextShape;
        private UInt16 __speed = 1;
        private UInt32 _points = 0;
        private SortedDictionary<UInt32, string> _score;
        private bool _isPaused = false;

        private UInt16 _speed
        {
            get { return __speed; }
            set
            {
                __speed = value;
                _fallTimer.Interval = 1100 - (int)__speed * 100;
                label2.Text = "Speed: " + __speed.ToString();
            }
        }

        public Form1()
        {
            InitializeComponent();
            Block.SizeX = (UInt16)(pictureBox2.Width / PlaneDimensions.X);
            Block.SizeY = (UInt16)(pictureBox2.Height / PlaneDimensions.Y);
            _fallTimer.Tick += new EventHandler(OnTimer);
            if (File.Exists("./score.dat"))
            {
                FileStream f = new FileStream("./score.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter read = new BinaryFormatter();
                _score = (SortedDictionary<UInt32, string>)read.Deserialize(f);
                f.Close();
            }
            else
            {
                _score = new SortedDictionary<UInt32,string>();
            }
        }

        private void NewGame()
        {
            PlaneDimensions = new Point(Settings.dimensions.X, Settings.dimensions.Y);
            _speed = Settings.speed;

            _points = 0;
            label1.Text = "Points: " + _points.ToString();
            label2.Text = "Speed: " + _speed.ToString();

            _plane = new Block[PlaneDimensions.X, PlaneDimensions.Y];
            for (int i = 0; i < PlaneDimensions.X; i++)
                for (int j = 0; j < PlaneDimensions.Y; j++)
                    _plane[i, j] = null;

            _fallTimer.Interval = 1100 - (int)_speed * 100;
            _fallTimer.Start();

            Random r = new Random(DateTime.Now.Millisecond);
            _currShape = new Shape((ShapeType)r.Next(0, (int)ShapeType.Z));
            _nextShape = new Shape((ShapeType)r.Next(0, (int)ShapeType.Z));

            _isGameStarted = true;
            NextTurn();
        }

        private void EndGame()
        {
            if (!_isGameStarted) return;
            _fallTimer.Stop();
            _isGameStarted = false;
            MessageBox.Show("GAME OVER!");
            FNickName form = new FNickName(_points);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _score.Add(_points, form.name);
                if (_score.Count > 10)
                {
                    _score.Remove(_score.ElementAt(0).Key);
                }
                topScoresToolStripMenuItem_Click(null, null);
            }
        }

        private void NextTurn()
        {
            if (!_isGameStarted) return;
            Random r = new Random(DateTime.Now.Millisecond);
            _currShape = _nextShape;
            _nextShape = new Shape((ShapeType)r.Next(0, (int)ShapeType.Z + 1));
            while (_nextShape.MoveLeft()) ;
            bool canPlace = false;
            do{
                bool err = false;
                foreach(Block b in _currShape.GetBlocks()){
                    if(_plane[b.Position.X, b.Position.Y] != null){
                        err = true;
                        break;
                    }
                }
                if (err)
                {
                    if (!_currShape.MoveRight())
                    {
                        break;
                    }
                }
                else
                    canPlace = true;
                
            }while (!canPlace);
            if (!canPlace)
            {
                EndGame();
                return;
            }

            foreach (Block b in _currShape.GetBlocks())
                _plane[b.Position.X, b.Position.Y] = b;

            pictureBox1_SizeChanged(null, null);
            pictureBox2_Paint();
        }

        private void CheckLine()
        {
            for (int j = PlaneDimensions.Y - 1; j >= 0;)
            {
                bool clearLine = true;
                for (int i = 0; i < PlaneDimensions.X; i++)
                {
                    if (_plane[i, j] == null)
                    {
                        clearLine = false;
                        break;
                    }
                }
                if (clearLine)
                {
                    for (int m = j; m > 0; m--)
                    {
                        for (int k = 0; k < PlaneDimensions.X; k++)
                        {
                            _plane[k, m] = _plane[k, m - 1];
                        }
                    }
                    for (int k = 0; k < PlaneDimensions.X; k++)
                        _plane[k, 0] = null;
                    _points += (uint)(PlaneDimensions.X * _speed);
                    label1.Text = "Points: " + _points.ToString();
                    if (_points > (_speed * PlaneDimensions.X * PlaneDimensions.Y * 5) && _speed != 10)
                        _speed++;
                }
                else
                {
                    j--;
                }
            }
        }

        private void MoveDown()
        {
            foreach (Block b in _currShape.GetBlocks())
                _plane[b.Position.X, b.Position.Y] = null;

            _currShape.MoveDown();

            bool error = false;
            foreach (Block b in _currShape.GetBlocks())
            {
                if ((b.Position.Y >= PlaneDimensions.Y) ||
                    (_plane[b.Position.X, b.Position.Y] != null))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                _currShape.MoveUp();
                foreach (Block b in _currShape.GetBlocks())
                    _plane[b.Position.X, b.Position.Y] = b;
                CheckLine();
                NextTurn();
            }
            else
            {
                foreach (Block b in _currShape.GetBlocks())
                    _plane[b.Position.X, b.Position.Y] = b;
            }
        }

        private void OnTimer(object sender, EventArgs e)
        {
            MoveDown();
            pictureBox2_Paint();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!_isGameStarted) return;
            if (_isPaused && e.KeyCode != Keys.P) return;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    {
                        foreach (Block b in _currShape.GetBlocks())
                            _plane[b.Position.X, b.Position.Y] = null;

                        _currShape.MoveLeft();

                        bool error = false;
                        foreach (Block b in _currShape.GetBlocks())
                        {
                            if (_plane[b.Position.X, b.Position.Y] != null)
                            {
                                error = true;
                                break;
                            }
                        }
                        if (error)
                            _currShape.MoveRight();
                        foreach (Block b in _currShape.GetBlocks())
                            _plane[b.Position.X, b.Position.Y] = b;
                    }
                    break;

                case Keys.Right:
                    {
                        foreach (Block b in _currShape.GetBlocks())
                            _plane[b.Position.X, b.Position.Y] = null;

                        _currShape.MoveRight();

                        bool error = false;
                        foreach (Block b in _currShape.GetBlocks())
                        {
                            if (_plane[b.Position.X, b.Position.Y] != null)
                            {
                                error = true;
                                break;
                            }
                        }
                        if (error)
                            _currShape.MoveLeft();
                        foreach (Block b in _currShape.GetBlocks())
                            _plane[b.Position.X, b.Position.Y] = b;
                    }
                    break;

                case Keys.Down:
                    {
                        MoveDown();
                    }
                    break;

                case Keys.Space:
                    {
                        foreach (Block b in _currShape.GetBlocks())
                            _plane[b.Position.X, b.Position.Y] = null;

                        _currShape.Rotate();

                        bool error = false;
                        foreach (Block b in _currShape.GetBlocks())
                        {
                            if (_plane[b.Position.X, b.Position.Y] != null)
                            {
                                error = true;
                                break;
                            }
                        }
                        if (error)
                        {
                            _currShape.Rotate();
                            _currShape.Rotate();
                            _currShape.Rotate();
                        }
                        foreach (Block b in _currShape.GetBlocks())
                            _plane[b.Position.X, b.Position.Y] = b;
                    }
                    break;

                case Keys.P:
                    Pause();
                    break;
            }
            pictureBox2_Paint();
        }

        private void Pause()
        {
            _isPaused = !_isPaused;
            if (_isPaused)
                _fallTimer.Stop();
            else
                _fallTimer.Start();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSettings form = new FSettings(
                new Point(4, pictureBox2.Width/7),
                new Point(4, pictureBox2.Height/7));
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Settings.dimensions = new Point(form._width, form._height);
                Settings.speed = (UInt16)form._iSpeed;
            }
            pictureBox2_SizeChanged(null, null);
        }

        private void pictureBox2_SizeChanged(object sender, EventArgs e)
        {
            Block.SizeX = (UInt16)(pictureBox2.Width / PlaneDimensions.X);
            Block.SizeY = (UInt16)(pictureBox2.Height / PlaneDimensions.Y);
            if(this.WindowState != FormWindowState.Minimized)
                pictureBox2_Paint();
        }

        private void pictureBox2_Paint()
        {
            if (!_isGameStarted) return;
            Bitmap picture = new Bitmap(
                Block.SizeX * PlaneDimensions.X,
                Block.SizeY * PlaneDimensions.Y);
            Graphics gr = Graphics.FromImage(picture);

            for (int i = 0; i < PlaneDimensions.X; i++)
                for (int j = 0; j < PlaneDimensions.Y; j++)
                    if (_plane[i, j] != null)
                    {
                        Pen p = new Pen(_plane[i, j].BorderColor);
                        p.Width = 2;
                        gr.DrawRectangle(p,
                            i * Block.SizeX,
                            j * Block.SizeY,
                            Block.SizeX,
                            Block.SizeY);
                        gr.FillRectangle(new SolidBrush(_plane[i, j].BackColor),
                            i * Block.SizeX + 2,
                            j * Block.SizeY + 2,
                            Block.SizeX - 4,
                            Block.SizeY - 4);
                        p.Dispose();
                    }
            if (_isPaused)
            {
                gr.DrawString("PAUSED",
                    new Font("Verdana", 30),
                    new SolidBrush(Color.White),
                    new PointF(0, pictureBox2.Height / (float)2));
            }
            gr.Dispose();
            picture = new Bitmap(picture, pictureBox2.Size);
            pictureBox2.Image = picture;
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            if (!_isGameStarted) return;
            if (this.WindowState == FormWindowState.Minimized) return;
            Bitmap nextF = new Bitmap(Block.SizeX * 3, Block.SizeY * 4);
            Graphics g = Graphics.FromImage(nextF);
            Block[,] pl = new Block[3, 4];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    pl[i, j] = null;
            foreach (Block b in _nextShape.GetBlocks())
            {
                pl[b.Position.X, b.Position.Y] = b;
            }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    if (pl[i, j] != null)
                    {
                        Pen p = new Pen(pl[i, j].BorderColor);
                        p.Width = 2;
                        g.DrawRectangle(p,
                            i * Block.SizeX,
                            j * Block.SizeY,
                            Block.SizeX,
                            Block.SizeY);
                        g.FillRectangle(new SolidBrush(pl[i, j].BackColor),
                            i * Block.SizeX + 2,
                            j * Block.SizeY + 2,
                            Block.SizeX - 4,
                            Block.SizeY - 4);
                        p.Dispose();
                    }
            g.Dispose();
            nextF = new Bitmap(nextF, pictureBox1.Size);
            pictureBox1.Image = nextF;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FScores sc = new FScores((SortedDictionary<UInt32, string>)_score.Reverse());
            FScores sc = new FScores(_score);
            sc.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream f = new FileStream("./score.dat", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter write = new BinaryFormatter();
            write.Serialize(f, _score);
            f.Close();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized ||
                WindowState == FormWindowState.Maximized)
                Pause();
        }
    }
}
