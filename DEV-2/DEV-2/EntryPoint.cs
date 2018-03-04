using System;
using System.Text;

namespace DEV_2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your string: ");
            StringBuilder theString = new StringBuilder(Console.ReadLine());
            StringCreator newString = new StringCreator();
            newString.GetNewStringOddIndices(theString);
        }
    }
}
