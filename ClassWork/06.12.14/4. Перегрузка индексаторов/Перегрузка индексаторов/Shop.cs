using System;
using System.Collections;

namespace Indexers
{
    class Shop : IEnumerable
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
                    return m_laptops[index];
                }
            }
            set
            {
                if (index < 0 || index >= m_laptops.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    m_laptops[index] = value;
                }
            }
        }
        
        public Laptop this[Double price]
        {
            get
            {
                if (price == 0.0)
                {
                    throw new IndexOutOfRangeException();
                }

                return this[FindByPrice(price)];
            }
        }

        public Laptop this[String name]
        {
            get
            {
                if (name.Length == 0)
                {
                    //return null;
                    throw new IndexOutOfRangeException();
                }

                return this[Find(name)];
            }
        }

        private Int32 Find(String name)
        {
            Int32 result = -1;

            for (Int32 i = 0; i < m_laptops.Length; i++)
            {
                if (m_laptops[i].Vendor == name)
                {
                    result = i;
                }
            }

            return result;
        }
        
        public Int32 FindByPrice(Double price)
        {
            Int32 result = -1;

            for (Int32 i = 0; i < m_laptops.Length; i++)
            {
                if (m_laptops[i].Price == price)
                {
                    result = i;
                }
            }

            return result;
        }

        #region IEnumerable members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return m_laptops.GetEnumerator();
        }

        #endregion
    }
}