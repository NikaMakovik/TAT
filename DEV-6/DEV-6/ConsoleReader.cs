using System;

namespace DEV_6
{
    /// <summary>
    /// Reads data from console.
    /// </summary>
    public class ConsoleReader
    {
        /// <summary>
        /// Creates console menu.
        /// </summary>
        public void ConsoleMenu()
        {
            while (true)
            {
                Console.WriteLine("Use 'add item' to add item in the repository.");
                Console.WriteLine("Use 'count types' to count number of types in the repository.");
                Console.WriteLine("Use 'count all' to count number of items in the repository.");
                Console.WriteLine("Use 'average price' to count average price of items in the repository.");
                Console.WriteLine("Use 'average price + type' to count average price of items of defined type in the repository.");
                Console.WriteLine("Use 'exit' to exit from the program.");
                InterfaceCommandInvoker interfaceCommandInvoker = new InterfaceCommandInvoker();
                string action = Console.ReadLine();
                if (action == "exit")
                {
                    return;
                }
                interfaceCommandInvoker.CommandRequest(action);
            }
        }
    }
}

