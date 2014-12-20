using System;

namespace Indexers
{
    class Shop
    {
        private Laptop[] m_laptops = null;

        public Shop(Int32 size)
        {
            m_laptops = new Laptop[size];
        }

        public Int32 Length
        {
            get
            {
                return m_laptops.Length;
            }
        }

        public Laptop this[Int32 index]
        {
            get
            {
                if (index < 0 || index >= m_laptops.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return m_laptops[index] as Laptop;
                }
            }
            set
            {
                m_laptops[index] = value as Laptop;
            }
        }
    }
}