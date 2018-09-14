using System;

namespace Test_1_Task_2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(args[0]);
                Console.WriteLine(args[1]);
                var rectangle = new Rectangle(double.Parse(args[0]), double.Parse(args[1]));
                rectangle.GetSquare();
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
