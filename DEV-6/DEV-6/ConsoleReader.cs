using System;

namespace DEV_6
{
    /// <summary>
    /// Reads data from console.
    /// </summary>
    public class CommandReader
    {
        const string menu = "Use 'add item' to add item in the repository.\n" +
            "Use 'count types' to count number of types in the repository.\n" +
            "Use 'count all' to count number of items in the repository.\n" +
            "Use 'average price' to count average price of items in the repository.\n" +
            "Use 'average price + type' to count average price of items of defined type in the repository." +
            "Use 'exit' to exit from the program.";
        /// <summary>
        /// Creates console menu.
        /// </summary>
        public void ConsoleMenu()
        {
            while (true)
            {
                Console.WriteLine(menu);                
                CommandInvoker interfaceCommandInvoker = new CommandInvoker();
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

