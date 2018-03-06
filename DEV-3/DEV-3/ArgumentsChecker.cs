using System;

namespace DEV_3
{
    class ArgumentsChecker
    {
        public void CheckStringArgs(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Wrong number of arguments.");
                Environment.Exit(0);
            }
            int result1, result2 = 0;
            if (!Int32.TryParse(args[0], out result1) || !Int32.TryParse(args[1], out result2))
            {
                Console.WriteLine("Wrong type of arguments.");
                Environment.Exit(0);
            }
            if (result2 < 2 || result2 > 20)
            {
                Console.WriteLine("Wrong number of base of numeral system.");
                Environment.Exit(0);
            }
        }
    }
}
