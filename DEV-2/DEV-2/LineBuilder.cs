using System;
using System.Text;

namespace DEV_2
{
    /// <summary>
    /// Class to build new line.
    /// </summary>
    public class LineBuilder
    {
        /// <summary>
        /// Method to build new string from old string's elements with odd indecies.
        /// </summary>
        /// <param name="oldString"></param>
        /// <returns>Returns new string.</returns>
        public string BuildNewLineFromOddIndeciesOfOld(string oldString)
        {
            if (oldString.Length == 0)
            {
                Console.WriteLine("The string is empty.");
                throw new ArgumentException();
            }
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < oldString.Length; i += 2)
            {
                newString.Append(oldString[i]);
            }
            return newString.ToString();
        }
    }
}
