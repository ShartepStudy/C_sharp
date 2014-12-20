using System;

namespace Operators
{
    // Класс точки на плоскости.
    class Point
    {
        private Int32 m_x = 0;
        private Int32 m_y = 0;

        public Point(Int32 x, Int32 y)
        {
            m_x = x;
            m_y = y;
        }

        // Перегрузка инкремента.
        public static Point operator++(Point point)
        {
            point.m_x++;
            point.m_y++;

            return point;
        }

        // Перегрузка декремента.
        public static Point operator--(Point point)
        {
            point.m_x--;
            point.m_y--;

            return point;
        }

        // Перегрузка оператора "+".
        public static Point operator-(Point point)
        {
            Point result = new Point(point.m_x, point.m_y);

            result.m_x = -result.m_x;
            result.m_y = -result.m_y;

            return result;
        }

        public override String ToString()
        {
            return String.Format("X = {0} Y = {1}", m_x, m_y);
        }
    }
}