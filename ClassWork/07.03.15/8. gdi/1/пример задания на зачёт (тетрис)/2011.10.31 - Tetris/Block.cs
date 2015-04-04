using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace _2011._10._31___Tetris
{
    class Block
    {
        public static UInt16 SizeX { get; set; }
        public static UInt16 SizeY { get; set; }
        public Color BackColor { get; set; }
        public Color BorderColor { get; set; }
        public Point Position { get; set; }
    }
}
