namespace DEV_1
{
    /// <summary>
    /// This class contains methods to calculate number of serial identical symbols.
    /// </summary>
    class SerialIdenticalSymbols
    {
        /// <summary>
        /// This class calculates number of serial identical symbols.
        /// </summary>
        /// <param name="theString"></param>
        /// <returns>
        /// Returns maximum number of serial identical symbols.
        /// </returns>
        static public int GetMaxNumberOfSerialIdenticalSymbols(string theString)
        {
            int counter = 1;
            int maxEquals = 1;
            for (int i = 0; i < theString.Length - 1; i++)
            { 
                if (theString[i + 1] == theString[i])
                {
                    counter++;
                    if (counter > maxEquals)
                        maxEquals = counter;
                }
                else
                    counter = 1;
            }
            return maxEquals;
        }
    }
}
