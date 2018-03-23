using System;
using System.Collections.Generic;

namespace DEV_6
{
    class RepositoryCountTypes : ICommands
    {
        public void Execute()
        {
            List<string> types = RepositoryOfItems.GetListOfItems().GetTypes();
            int counter = 0;
            foreach (string type in types)
            {
                counter++;
            }
            Console.WriteLine($"  types {counter}");
        }
    }
}
