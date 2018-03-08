using System.Text;
using System;

namespace DEV_3
{
    /// <summary>
    /// This Class works with numbers.
    /// </summary>
    class NumberConverter
    {
        StringBuilder NewNumber = new StringBuilder();
        private int baseOfNewNumeralSystem;
        public int InitialNumber { get; set; }
        public int BaseOfNewNumeralSystem
        {
            get
            {
                return baseOfNewNumeralSystem;
            }
            set
            {
                if (value < 2 || value > 20)
                {
                    throw new ArgumentException();
                }
                baseOfNewNumeralSystem = value;
            }
        }

        public NumberConverter(int initialNumber, int baseOfNewNumeralSystem)
        {
            InitialNumber = initialNumber;
            BaseOfNewNumeralSystem = baseOfNewNumeralSystem;
        }

        private void AppendSymbolToNumber(int RemainderOfDivision)
        {
            if (RemainderOfDivision < 10)
            {
                NewNumber.Append(RemainderOfDivision);
            }
            else
            {
                NewNumber.Append((char)('A' - 10 + RemainderOfDivision));
            }
        }
        private void ReverseNumber(StringBuilder Number)
        {
            char temp;
            int lenght = Number.Length - 1;
            for (int i = 0; i < lenght; i++, lenght--)
            {
                temp = Number[i];
                Number[i] = Number[lenght];
                Number[lenght] = temp;
            }
        }

        /// <summary>
        /// This Method converts initial number to new number from decimal numeral system to another one (from 2 to 20).
        /// </summary>
        /// <param name="InitialNumber">Initial number to be converted.</param>
        /// <param name="NumeralBase">Base of new numeral system.</param>
        /// <returns></returns>
        public StringBuilder ConvertToNewNumeralSystem()
        {
            int RemainderOfDivision;
            for (int i = 0; InitialNumber != 0; i++)
            {
                RemainderOfDivision = InitialNumber % BaseOfNewNumeralSystem;
                InitialNumber /= BaseOfNewNumeralSystem;
                AppendSymbolToNumber(RemainderOfDivision);
            }
            ReverseNumber(NewNumber);
            return NewNumber;
        }
    }
}
