using System;
using System.Text;

namespace DEV_2
{
    class StringCreator
    {
        /// <summary>
        /// This Method checks possibility of using string.
        /// </summary>
        /// <param name="theString">The main string.</param>
        private void CheckPossibilityOfUsing(StringBuilder theString)
        {
            if (theString.Length<1)
            {
                Console.WriteLine("The string is empty. Try again. ");
                return;
            }
        }
        /// <summary>
        /// This Method make a new string with odd indices from the main string.
        /// </summary>
        /// <param name="theString">The main string.</param>
        public void GetNewStringOddIndices(StringBuilder theString)
        {
            CheckPossibilityOfUsing(theString);
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < theString.Length; i+=2)
            {
                newString.Append(theString[i]);
            }
            Console.WriteLine("New string: ");
            Console.WriteLine(newString);
        }
    }
}
