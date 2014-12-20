using System;

namespace Indexers
{
    class Laptop
    {
        private Double m_price = 0.0;
        private String m_vendor = String.Empty;
        
        public Laptop(String vendor, Double price)
        {
            m_vendor = vendor;
            m_price = price;
        }

        public Double Price
        {
            get
            {
                return m_price;
            }
            set
            {
                m_price = value;
            }

        }

        public String Vendor
        {
            get
            {
                return m_vendor;
            }
            set
            {
                m_vendor = value;
            }
        }

        public override String ToString()
        {
            return m_vendor + " " + m_price.ToString();
        }
    }
}