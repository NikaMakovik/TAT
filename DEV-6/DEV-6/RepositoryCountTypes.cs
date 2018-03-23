using System;

namespace DEV_6
{
    /// <summary>
    /// Does CountTypes command.
    /// </summary>
    class RepositoryCountTypes : ICommands
    {
        /// <summary>
        /// Execute method for count types command. 
        /// </summary>
        public void Execute()
        {
            Console.WriteLine($"Number of types: {RepositoryOfItems.GetListOfItems().GetNumberOfTypes()}");
        }
    }
}
