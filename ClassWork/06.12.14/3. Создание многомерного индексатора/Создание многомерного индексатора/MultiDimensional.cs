using System;

namespace Indexers
{
    class MultiDimensional
    {
        private Int32[,] m_array = null;
        private Int32 m_colums = 0;
        private Int32 m_rows = 0;
        
        public MultiDimensional(Int32 rows, Int32 cols)
        {
            m_array = new Int32[rows, cols];
            m_colums = cols;
            m_rows = rows;
        }

        public Int32 Cols
        {
            get
            {
                return m_colums;
            }
        }

        public Int32 Rows
        {
            get
            {
                return m_rows;
            }
        }

        public Int32 this[Int32 row, Int32 column]
        {
            get
            {
                return m_array[row, column];
            }
            set
            {
                m_array[row, column] = value;
            }
        }
    }
}