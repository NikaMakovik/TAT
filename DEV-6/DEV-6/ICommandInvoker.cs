using System.Collections.Generic;

namespace DEV_6
{
    /// <summary>
    /// Invokes actions on commands.
    /// </summary>
    class InterfaceCommandInvoker
    {
        RepositoryAddItem repositoryAddItem;
        RepositoryCountTypes repositoryCountTypes;
        RepositoryCountAll repositoryCountAll;
        RepositoryAveragePrice repositoryAveragePrice;
        RepositoryAveragePriceType repositoryAveragePriceType;
        private Dictionary<string, ICommands> commandsDictionary;

        public InterfaceCommandInvoker()
        {
            repositoryAddItem = new RepositoryAddItem();
            repositoryCountTypes = new RepositoryCountTypes();
            repositoryCountAll = new RepositoryCountAll();
            repositoryAveragePrice = new RepositoryAveragePrice();
            repositoryAveragePriceType = new RepositoryAveragePriceType();
            commandsDictionary = new Dictionary<string, ICommands>();
        }

        /// <summary>
        /// Invoke actions on commands.
        /// </summary>
        public void CommandRequest(string action)
        {
            MadeDictionary();
            ICommands command = commandsDictionary[action];
            command.Execute();
        }
        private void MadeDictionary()
        {
            commandsDictionary.Add("add item", repositoryAddItem);
            commandsDictionary.Add("count types", repositoryCountTypes);
            commandsDictionary.Add("count all", repositoryCountAll);
            commandsDictionary.Add("average price", repositoryAveragePrice);
            commandsDictionary.Add("average price type", repositoryAveragePriceType);
        }
    }
}
