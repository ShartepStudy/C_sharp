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

        // Может быть потеря точности, преобразование должно быть явным.
        public static explicit operator Int32(Point point)
        {
            return (Int32)Math.Sqrt(point.m_x * point.m_x + point.m_y * point.m_y);
            // Можно и так:
            //return (Int32)(Double)point;    
        }

        // Преобразование без потери точности, может быть неявным.
        public static implicit operator Double(Point point)
        {
            return Math.Sqrt(point.m_x * point.m_x + point.m_y * point.m_y);
        }

        // Переданное значение сохраняется в m_x и m_y координате, преобразование без потери 
        // точности, может быть неявным.
        public static implicit operator Point(Int32 integer)
        {
            return new Point(integer, integer);
        }

        // Преобразование c потерей точности, должно быть явным.
        public static explicit operator Point(Double floating)
        {
            return new Point((Int32)floating, (Int32)floating);
        }

        public override String ToString()
        {
            return String.Format("X = {0} Y = {1}", m_x, m_y);
        }
    }
}