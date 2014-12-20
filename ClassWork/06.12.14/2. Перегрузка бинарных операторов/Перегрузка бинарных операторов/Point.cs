using System;

namespace Operators
{
    class Point
    {
        private Int32 m_x = 0;
        private Int32 m_y = 0;

        public Point(Int32 x, Int32 y)
        {
            m_x = x;
            m_y = y;
        }
        
        // Перегрузка бинарного оператора "*".
        public static Point operator*(Point left, Int32 right)
        {
            return new Point(left.m_x * right, left.m_y * right);
        }
        
        public static Point operator*(Int32 left, Point right)
        {
            return right * left;
        }

        // Перегрузка бинарного оператора "+".
        public static Point operator+(Point left, Vector right)
        {
            return new Point(left.m_x + right.m_x, left.m_y + right.m_y);
        }
        
        // Перегрузка бинарного оператора "-".
        public static Vector operator-(Point left, Point right)
        {
            return new Vector(left.m_x - right.m_x, left.m_y - right.m_y);
        }

        public override String ToString()
        {
            return String.Format("Point: X = {0} Y = {1}", m_x, m_y);
        }
    }
}