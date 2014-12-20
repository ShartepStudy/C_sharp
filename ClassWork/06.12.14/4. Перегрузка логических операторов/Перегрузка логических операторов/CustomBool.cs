using System;

namespace Operators
{
    class CustomBool
    {
        // Значение параметра может быть:
        // -1 - false
        // 1 - true
        // 0 - null
        public static readonly CustomBool s_null = new CustomBool(0);
        public static readonly CustomBool s_false = new CustomBool(-1);
        public static readonly CustomBool s_true = new CustomBool(1);
    
        private SByte m_value;

        private CustomBool(Int32 value)
        {
            m_value = (SByte)value;
        }

        public CustomBool(CustomBool value)
        {
            m_value = (SByte)value.m_value;
        }
    
        // Оператор Логическое И. Возвращает:
        // False, если один из операндов False независимо от 2-ого операнда
        // Null, если один из операндов Null, а другой Null или True
        // True, если оба операнда True
        public static CustomBool operator&(CustomBool left, CustomBool right)
        {
            return new CustomBool(left.m_value < right.m_value ? left.m_value : right.m_value);
        }

        // Оператор Логическое ИЛИ. Возвращает:
        // True, если один из операндов True независимо от 2-ого операнда
        // Null, если один из операндов Null, а другой False или Null
        // False, если оба операнда False
        public static CustomBool operator|(CustomBool left, CustomBool right)
        {
            return new CustomBool(left.m_value > right.m_value ? left.m_value : right.m_value);
        }

        // Оператор Логическая инверсия. Возвращает:
        // False, если операнд содержит True
        // True, если операнд содержит False
        // Null, если операнд содержит Null
        public static CustomBool operator!(CustomBool obj)
        {
            return new CustomBool(-obj.m_value);
        }

        // Возвращает true, если в операнде содержится True, иначе возвращает false.
        public static Boolean operator true(CustomBool obj)
        {
            return obj.m_value > 0;
        }

        // Возвращает true, если в операнде содержится False, иначе возвращает false.
        public static Boolean operator false(CustomBool obj)
        {
            return obj.m_value < 0;
        }

        public override String ToString()
        {
            String result = String.Empty;

            if (m_value > 0)
            {
                result = "CustomBool.s_true";
            }
            else if (m_value < 0)
            {
                result = "CustomBool.s_false";
            }
            else
            {
                result = "CustomBool.s_null";
            }

            return result;
        }
    }
}