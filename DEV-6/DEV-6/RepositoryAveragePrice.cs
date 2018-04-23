using System;

namespace DEV_6
{
    /// <summary>
    /// Does AveragePrice command.
    /// </summary>
    class RepositoryAveragePrice : ICommands
    {
        /// <summary>
        /// Execute method for average price command.
        /// </summary>
        public void Execute()
        {
            Console.WriteLine($"Average price of all items: {RepositoryOfItems.GetListOfItems().GetAveragePrice()}");
        }
    }
}
