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

        public static Boolean operator==(Point point1, Point point2)
        {
            bool result = false;

            // Проверка, что переменные ссылаются на один и тот же адрес сравнение point1 == point2 
            // приведет к бесконечной рекурсии.
            if (ReferenceEquals(point1, point2))
            {
                result = true;
            }
            // Приведение к Object необходимо, так как сравнение point1 == null приведет к 
            // бесконечной рекурсии.
            else if ((Object)point1 != null)
            {
                result = point1.Equals(point2);
            }

            return result;
        }

        public static Boolean operator!=(Point point1, Point point2)
        {
            return !(point1 == point2);
        }

        // Перегрузка метода Equals.
        public override Boolean Equals(Object obj)
        {
            bool result = false;

            // Если obj == null, значит obj != объекту, от имени которого вызывается этот метод.
            if (obj != null)
            {
                Point point = obj as Point;

                // Переданный объект не является ссылкой на Point.
                if (point != null)
                {
                    // Проверяется равенство содержимого.
                    result = m_x == point.m_x && m_y == point.m_y;
                }

            }

            return result;
        }

        // При перегрузке Equals необходимо также перегрузить GetHashCode.
        public override Int32 GetHashCode()
        {
            // Использование XOR для получения хеш кода.
            return m_x ^ m_y;
        }
    }
}