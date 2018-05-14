using System;

namespace DEV_11App
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            DaysCounter.DaysFromTheBeginningOfEra daysCount = new DaysCounter.DaysFromTheBeginningOfEra();
            try
            {
                Console.WriteLine("Enter date in format dd.mm.yyyy");
                DateTime date = DateTime.Parse(Console.ReadLine());
                int days = daysCount.HowManyDays(date);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
