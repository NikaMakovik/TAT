using System;

namespace DEV_3
{
    class EntryPiont
    {
        static void Main(string[] args)
        {
            ArgumentsChecker ArgsCheck = new ArgumentsChecker();
            ArgsCheck.CheckStringArgs(args);
            int NumberToConvert = Int32.Parse(args[0]);
            int NumeralBaseToConvert = Int32.Parse(args[1]);
            NumbersWorker NewNumbersJob = new NumbersWorker();
            Console.WriteLine($"New Number: {NewNumbersJob.ConvertToNewNumeralSystem(NumberToConvert, NumeralBaseToConvert)}");
        }
    }
}
