using System;
using System.Text;

namespace DEV_2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your string: ");
            string theString = Console.ReadLine();
            if (theString.Length < 1)
            {
                Console.WriteLine("The string is empty. Try again.");
                return;
            }
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < theString.Length; i += 2)
            {
                newString.Append(theString[i]);
            }
            Console.WriteLine($"New string: {newString}");
        }
    }
}
