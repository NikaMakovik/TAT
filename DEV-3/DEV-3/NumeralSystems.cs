using System.Text;

namespace DEV_3
{
    /// <summary>
    /// This Class works with numbers.
    /// </summary>
    class NumbersWorker
    {
        StringBuilder NewNumber = new StringBuilder(" ");

        /// <summary>
        /// This Method insert numeral or letter to number in new numeral system.
        /// </summary>
        /// <param name="RemainderOfDivision">Remainder of division.</param>
        private void InsertSymbolToNumber(int RemainderOfDivision)
        {
            if (RemainderOfDivision < 10)
            {
                NewNumber.Insert(1, RemainderOfDivision);
            }
            else
            {
                NewNumber.Insert(1, (char)(55 + RemainderOfDivision));
            }
        }
        /// <summary>
        /// This Method converts initial number to new number from decimal numeral system to another one (from 2 to 20).
        /// </summary>
        /// <param name="InitialNumber">Initial number to be converted.</param>
        /// <param name="NumeralBase">Base of new numeral system.</param>
        /// <returns></returns>
        public StringBuilder ConvertToNewNumeralSystem(int InitialNumber, int NumeralBase)
        {
            int RemainderOfDivision;
            for (int i = 0; InitialNumber != 0; i++)
            {
                RemainderOfDivision = InitialNumber % NumeralBase;
                InitialNumber /= NumeralBase;
                InsertSymbolToNumber(RemainderOfDivision);
            }
            return NewNumber;
        } 
    }
}
