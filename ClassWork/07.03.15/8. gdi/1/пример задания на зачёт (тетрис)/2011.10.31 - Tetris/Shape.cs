using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace _2011._10._31___Tetris
{
    enum ShapeType : byte { O, I, L, J, T, S, Z }
    enum ShapeDirection : byte { Normal, CW90, CW180, CW270 }

    class Shape
    {
        private Block[] _blocks = new Block[4];
        private Point _position;
        private ShapeDirection _direction = ShapeDirection.Normal;

        public readonly ShapeType _type;
        public ShapeDirection Direction { get { return _direction; } }
        public Shape(ShapeType type)
        {
            _type = type;
            _blocks[0] = new Block();
            _blocks[1] = new Block();
            _blocks[2] = new Block();
            _blocks[3] = new Block();
            foreach (Block b in _blocks)
            {
                switch (_type)
                {
                    case ShapeType.I:
                        b.BackColor = Color.FromArgb(255, 0, 0);
                        b.BorderColor = Color.FromArgb(128, 0, 0);
                        break;
                    case ShapeType.J:
                        b.BackColor = Color.FromArgb(0, 255, 0);
                        b.BorderColor = Color.FromArgb(0, 128, 0);
                        break;
                    case ShapeType.L:
                        b.BackColor = Color.FromArgb(0, 0, 255);
                        b.BorderColor = Color.FromArgb(0, 0, 128);
                        break;
                    case ShapeType.O:
                        b.BackColor = Color.FromArgb(255, 255, 0);
                        b.BorderColor = Color.FromArgb(128, 128, 0);
                        break;
                    case ShapeType.S:
                        b.BackColor = Color.FromArgb(0, 255, 255);
                        b.BorderColor = Color.FromArgb(0, 128, 128);
                        break;
                    case ShapeType.T:
                        b.BackColor = Color.FromArgb(255, 0, 255);
                        b.BorderColor = Color.FromArgb(128, 0, 128);
                        break;
                    case ShapeType.Z:
                        b.BackColor = Color.FromArgb(255, 255, 255);
                        b.BorderColor = Color.FromArgb(128, 128, 128);
                        break;
                }
            }
            _position = new Point(Form1.PlaneDimensions.X / 2 - 1, 0);
            Refresh();
        }

        private void Refresh()
        {
            switch (_type)
            {
                case ShapeType.I:
                    switch (_direction)
                    {
                        case ShapeDirection.Normal:
                        case ShapeDirection.CW180:
                            _blocks[0].Position = new Point(_position.X, _position.Y);
                            _blocks[1].Position = new Point(_position.X, _position.Y + 1);
                            _blocks[2].Position = new Point(_position.X, _position.Y + 2);
                            _blocks[3].Position = new Point(_position.X, _position.Y + 3);
                            break;
                        case ShapeDirection.CW90:
                        case ShapeDirection.CW270:
                            _blocks[0].Position = new Point(_position.X, _position.Y);
                            _blocks[1].Position = new Point(_position.X + 1, _position.Y);
                            _blocks[2].Position = new Point(_position.X + 2, _position.Y);
                            _blocks[3].Position = new Point(_position.X + 3, _position.Y);
                            break;
                    }
                    break;
                case ShapeType.J:
                    switch (_direction)
                    {
                        case ShapeDirection.Normal:
                            _blocks[0].Position = new Point(_position.X + 1, _position.Y);
                            _blocks[1].Position = new Point(_position.X + 1, _position.Y + 1);
                            _blocks[2].Position = new Point(_position.X + 1, _position.Y + 2);
                            _blocks[3].Position = new Point(_position.X, _position.Y + 2);
                            break;
                        case ShapeDirection.CW90:
                            _blocks[0].Position = new Point(_position.X, _position.Y);
                            _blocks[1].Position = new Point(_position.X, _position.Y + 1);
                            _blocks[2].Position = new Point(_position.X + 1, _position.Y + 1);
                            _blocks[3].Position = new Point(_position.X + 2, _position.Y + 1);
                            break;
                        case ShapeDirection.CW180:
                            _blocks[0].Position = new Point(_position.X, _position.Y);
                            _blocks[1].Position = new Point(_position.X + 1, _position.Y);
                            _blocks[2].Position = new Point(_position.X, _position.Y + 1);
                            _blocks[3].Position = new Point(_position.X, _position.Y + 2);
                            break;
                        case ShapeDirection.CW270:
                            _blocks[0].Position = new Point(_position.X, _position.Y);
                            _blocks[1].Position = new Point(_position.X + 1, _position.Y);
                            _blocks[2].Position = new Point(_position.X + 2, _position.Y);
                            _blocks[3].Position = new Point(_position.X + 2, _position.Y + 1);
                            break;
                    }
                    break;
                case ShapeType.L:
                    switch (_direction)
                    {
                        case ShapeDirection.Normal:
                            _blocks[0].Position = new Point(_position.X, _position.Y);
                            _blocks[1].Position = new Point(_position.X, _position.Y + 1);
                            _blocks[2].Position = new Point(_position.X, _position.Y + 2);
                            _blocks[3].Position = new Point(_position.X + 1, _position.Y + 2);
                            break;
                        case ShapeDirection.CW90:
                            _blocks[0].Position = new Point(_position.X, _position.Y);
                            _blocks[1].Position = new Point(_position.X, _position.Y + 1);
                            _blocks[2].Position = new Point(_position.X + 1, _position.Y);
                            _blocks[3].Position = new Point(_position.X + 2, _position.Y);
                            break;
                        case ShapeDirection.CW180:
                            _blocks[0].Position = new Point(_position.X, _position.Y);
                            _blocks[1].Position = new Point(_position.X + 1, _position.Y);
                            _blocks[2].Position = new Point(_position.X + 1, _position.Y + 1);
                            _blocks[3].Position = new Point(_position.X + 1, _position.Y + 2);
                            break;
                        case ShapeDirection.CW270:
                            _blocks[0].Position = new Point(_position.X, _position.Y + 1);
                            _blocks[1].Position = new Point(_position.X + 1, _position.Y + 1);
                            _blocks[2].Position = new Point(_position.X + 2, _position.Y + 1);
                            _blocks[3].Position = new Point(_position.X + 2, _position.Y);
                            break;
                    }
                    break;
                case ShapeType.O:
                    switch (_direction)
                    {
                        case ShapeDirection.Normal:
                        case ShapeDirection.CW90:
                        case ShapeDirection.CW180:
                        case ShapeDirection.CW270:
                            _blocks[0].Position = new Point(_position.X, _position.Y);
                            _blocks[1].Position = new Point(_position.X, _position.Y + 1);
                            _blocks[2].Position = new Point(_position.X + 1, _position.Y);
                            _blocks[3].Position = new Point(_position.X + 1, _position.Y + 1);
                            break;
                    }
                    break;
                case ShapeType.S:
                    switch (_direction)
                    {
                        case ShapeDirection.Normal:
                        case ShapeDirection.CW180:
                            _blocks[0].Position = new Point(_position.X, _position.Y);
                            _blocks[1].Position = new Point(_position.X, _position.Y + 1);
                            _blocks[2].Position = new Point(_position.X + 1, _position.Y + 1);
                            _blocks[3].Position = new Point(_position.X + 1, _position.Y + 2);
                            break;
                        case ShapeDirection.CW90:
                        case ShapeDirection.CW270:
                            _blocks[0].Position = new Point(_position.X, _position.Y + 1);
                            _blocks[1].Position = new Point(_position.X + 1, _position.Y);
                            _blocks[2].Position = new Point(_position.X + 1, _position.Y + 1);
                            _blocks[3].Position = new Point(_position.X + 2, _position.Y);
                            break;
                    }
                    break;
                case ShapeType.T:
                    switch (_direction)
                    {
                        case ShapeDirection.Normal:
                            _blocks[0].Position = new Point(_position.X, _position.Y);
                            _blocks[1].Position = new Point(_position.X + 1, _position.Y);
                            _blocks[2].Position = new Point(_position.X + 2, _position.Y);
                            _blocks[3].Position = new Point(_position.X + 1, _position.Y + 1);
                            break;
                        case ShapeDirection.CW90:
                            _blocks[0].Position = new Point(_position.X, _position.Y + 1);
                            _blocks[1].Position = new Point(_position.X + 1, _position.Y);
                            _blocks[2].Position = new Point(_position.X + 1, _position.Y + 1);
                            _blocks[3].Position = new Point(_position.X + 1, _position.Y + 2);
                            break;
                        case ShapeDirection.CW180:
                            _blocks[0].Position = new Point(_position.X, _position.Y + 1);
                            _blocks[1].Position = new Point(_position.X + 1, _position.Y);
                            _blocks[2].Position = new Point(_position.X + 1, _position.Y + 1);
                            _blocks[3].Position = new Point(_position.X + 2, _position.Y + 1);
                            break;
                        case ShapeDirection.CW270:
                            _blocks[0].Position = new Point(_position.X, _position.Y);
                            _blocks[1].Position = new Point(_position.X, _position.Y + 1);
                            _blocks[2].Position = new Point(_position.X, _position.Y + 2);
                            _blocks[3].Position = new Point(_position.X + 1, _position.Y + 1);
                            break;
                    }
                    break;
                case ShapeType.Z:
                    switch (_direction)
                    {
                        case ShapeDirection.Normal:
                        case ShapeDirection.CW180:
                            _blocks[0].Position = new Point(_position.X + 1, _position.Y);
                            _blocks[1].Position = new Point(_position.X + 1, _position.Y + 1);
                            _blocks[2].Position = new Point(_position.X, _position.Y + 1);
                            _blocks[3].Position = new Point(_position.X, _position.Y + 2);
                            break;
                        case ShapeDirection.CW90:
                        case ShapeDirection.CW270:
                            _blocks[0].Position = new Point(_position.X, _position.Y);
                            _blocks[1].Position = new Point(_position.X + 1, _position.Y);
                            _blocks[2].Position = new Point(_position.X + 1, _position.Y + 1);
                            _blocks[3].Position = new Point(_position.X + 2, _position.Y + 1);
                            break;
                    }
                    break;
            }
        }

        public void Rotate()
        {
            if (_direction == ShapeDirection.CW270)
                _direction = ShapeDirection.Normal;
            else
                _direction++;
            bool f = true;
            while (!MoveRight())
            {
                MoveLeft();
                f = false;
            }
            if(f)
                MoveLeft();
            Refresh();
        }

        public Block[] GetBlocks()
        {
            return _blocks;
        }

        public void MoveDown()
        {
            _position = new Point(_position.X, _position.Y + 1);
            Refresh();
        }

        public void MoveUp()
        {
            _position = new Point(_position.X, _position.Y - 1);
            Refresh();
        }

        public bool MoveLeft()
        {
            if (_position.X != 0)
                _position = new Point(_position.X - 1, _position.Y);
            else
                return false;
            Refresh();
            return true;
        }

        public bool MoveRight()
        {
            switch (_type)
            {
                case ShapeType.I:
                    switch (_direction)
                    {
                        case ShapeDirection.Normal:
                        case ShapeDirection.CW180:
                            if (_position.X + 1 >= Form1.PlaneDimensions.X) return false;
                            break;
                        case ShapeDirection.CW90:
                        case ShapeDirection.CW270:
                            if (_position.X + 4 >= Form1.PlaneDimensions.X) return false;
                            break;
                    }
                    break;
                case ShapeType.J:
                    switch (_direction)
                    {
                        case ShapeDirection.Normal:
                        case ShapeDirection.CW180:
                            if (_position.X + 2 >= Form1.PlaneDimensions.X) return false;
                            break;
                        case ShapeDirection.CW90:
                        case ShapeDirection.CW270:
                            if (_position.X + 3 >= Form1.PlaneDimensions.X) return false;
                            break;
                    }
                    break;
                case ShapeType.L:
                    switch (_direction)
                    {
                        case ShapeDirection.Normal:
                        case ShapeDirection.CW180:
                            if (_position.X + 2 >= Form1.PlaneDimensions.X) return false;
                            break;
                        case ShapeDirection.CW90:
                        case ShapeDirection.CW270:
                            if (_position.X + 3 >= Form1.PlaneDimensions.X) return false;
                            break;
                    }
                    break;
                case ShapeType.O:
                    switch (_direction)
                    {
                        case ShapeDirection.Normal:
                        case ShapeDirection.CW90:
                        case ShapeDirection.CW180:
                        case ShapeDirection.CW270:
                            if (_position.X + 2 >= Form1.PlaneDimensions.X) return false;
                            break;
                    }
                    break;
                case ShapeType.S:
                    switch (_direction)
                    {
                        case ShapeDirection.Normal:
                        case ShapeDirection.CW180:
                            if (_position.X + 2 >= Form1.PlaneDimensions.X) return false;
                            break;
                        case ShapeDirection.CW90:
                        case ShapeDirection.CW270:
                            if (_position.X + 3 >= Form1.PlaneDimensions.X) return false;
                            break;
                    }
                    break;
                case ShapeType.T:
                    switch (_direction)
                    {
                        case ShapeDirection.Normal:
                        case ShapeDirection.CW180:
                            if (_position.X + 3 >= Form1.PlaneDimensions.X) return false;
                            break;
                        case ShapeDirection.CW90:
                        case ShapeDirection.CW270:
                            if (_position.X + 2 >= Form1.PlaneDimensions.X) return false;
                            break;
                    }
                    break;
                case ShapeType.Z:
                    switch (_direction)
                    {
                        case ShapeDirection.Normal:
                        case ShapeDirection.CW180:
                            if (_position.X + 2 >= Form1.PlaneDimensions.X) return false;
                            break;
                        case ShapeDirection.CW90:
                        case ShapeDirection.CW270:
                            if (_position.X + 3 >= Form1.PlaneDimensions.X) return false;
                            break;
                    }
                    break;
            }
            _position = new Point(_position.X + 1, _position.Y);
            Refresh();
            return true;
        }
    }
}
