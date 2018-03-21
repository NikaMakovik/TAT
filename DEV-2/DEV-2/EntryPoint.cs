using System;

namespace DEV_2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your string: ");
                string oldString = Console.ReadLine();
                LineBuilder lineBuilder = new LineBuilder();
                string newString = lineBuilder.BuildNewLineFromOddIndeciesOfOld(oldString);
                Console.WriteLine($"New string: {newString}");
            }
            catch(ArgumentException)
            {
                Console.WriteLine("ArgumentException");
            }
        }
        }
    }
