using System;

namespace DEV_3
{
    class EntryPiont
    {
        static void Main(string[] args)
        {
            try
            {
                int NumberToConvert = int.Parse(args[0]);
                int NumeralBaseToConvert = int.Parse(args[1]);
                NumberConverter NewNumbersJob = new NumberConverter(NumberToConvert, NumeralBaseToConvert);
                Console.WriteLine($"New Number: {NewNumbersJob.ConvertToNewNumeralSystem()}");
                }
            catch(Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}
