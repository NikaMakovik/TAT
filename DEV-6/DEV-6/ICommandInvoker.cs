using System.Collections.Generic;

namespace DEV_6
{
    class ICommandInvoker
    {
        RepositoryAddItem repositoryAddItem = new RepositoryAddItem();
        RepositoryCountTypes repositoryCountTypes = new RepositoryCountTypes();
        RepositoryCountAll repositoryCountAll = new RepositoryCountAll();
        RepositoryAveragePrice repositoryAveragePrice = new RepositoryAveragePrice();
        RepositoryAveragePriceType repositoryAveragePriceType = new RepositoryAveragePriceType();
        private Dictionary<string, ICommands> commandsDictionary = new Dictionary<string, ICommands>();
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
