using System;

namespace Test_1_Task_1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Hello, world!\nAnd hi again!\n");
            for (int i = 0; i <= random.Next(5, 50); i++)
            {
                Console.Write("!");
            }
        }
    }
}
