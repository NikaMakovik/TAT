using System;

namespace DEV_7
{
    /// <summary>
    /// Represents menu for User.
    /// </summary>
    class Menu
    {
        CommandInvoker commandInvoker = new CommandInvoker();

        /// <summary>
        /// Represents menu for User.
        /// </summary>
        public void UsersActionsMenu()
        {
            string action;
            do
            {
                Console.WriteLine("Use 'add options' to add needed options.");
                Console.WriteLine("Use 'check storage' to get information about produced autos waiting in storage");
                Console.WriteLine("Use 'exit' to exit from the program.");
                action = Console.ReadLine();
                Console.Clear();
            }
            while (CommandSwitcher(action));
        }

        private bool CommandSwitcher(string action)
        {
            bool key = true;
            switch (action)
            {
                case "add options":
                    commandInvoker.SetCommand(new SetOptionsAction());                    
                    commandInvoker.Run();
                    break;
                case "check storage":
                    commandInvoker.SetCommand(new CheckStorehouseAction());
                    commandInvoker.Run();
                    break;
                case "exit":
                    key = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("We don't know this command. Please try again.");
                    UsersActionsMenu();
                    break;
            }
            return key;
        }        
    }
}
