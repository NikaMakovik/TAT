using System;

namespace DEV_6
{
    /// <summary>
    /// Does CountAll command.
    /// </summary>
    class RepositoryCountAll : ICommands
    {
        /// <summary>
        /// Execute method for count all command.
        /// </summary>
        public void Execute()
        {
            Console.WriteLine($"Numer of items: {RepositoryOfItems.GetListOfItems().GetNumberOfAllItems()}");
        }
    }
}
