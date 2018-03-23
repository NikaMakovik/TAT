using System;

namespace DEV_6
{
    /// <summary>
    /// Does AveragePriceType command.
    /// </summary>
    class RepositoryAveragePriceType : ICommands
    {
        /// <summary>
        /// Execute method for average price type command.
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("Enter the type.");
            string type = Console.ReadLine();
            Console.WriteLine($"{RepositoryOfItems.GetListOfItems().GetAveragePriceType(type)}");
        }
    }
}
