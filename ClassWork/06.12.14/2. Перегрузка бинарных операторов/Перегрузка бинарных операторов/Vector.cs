using System;

namespace Operators
{
    class Vector
    {
        public Int32 m_x = 0;
        public Int32 m_y = 0;

        public Vector(Int32 x, Int32 y)
        {
            m_x = x;
            m_y = y;
        }

        public override String ToString()
        {
            return String.Format("Vector: X = {0} Y = {1}", m_x, m_y);
        }
    }
}