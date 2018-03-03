using System;
namespace DEV_1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.Write("Wrong number of arguments.");
                return;
            }
            SerialIdenticalSymbols serialIdenticalSymbols = new SerialIdenticalSymbols();
            int MaxNumberOfSerialIdenticalSymbols = serialIdenticalSymbols.GetMaxNumberOfSerialIdenticalSymbols(args[0]);
            Console.WriteLine("Max value of serial identical symbols is: " + MaxNumberOfSerialIdenticalSymbols);
        }
    }
}
