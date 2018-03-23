using System.Collections.Generic;

namespace DEV_6
{
    /// <summary>
    /// Singleton Pattern to keep only one repository with items. 
    /// </summary>
    class RepositoryOfItems
    {
        private static RepositoryOfItems listOfItems;
        private List<Item> items = new List<Item>();
        private RepositoryOfItems() { }

        /// <summary>
        /// Checks if repository has been created yet.
        /// </summary>
        /// <returns>New repository if it hasn't been created yet; already existing repository if it has been created.</returns>
        public static RepositoryOfItems GetListOfItems()
        {
            if (listOfItems == null)
            {
                listOfItems = new RepositoryOfItems();
            }
            return listOfItems;
        }
        /// <summary>
        /// Adds item to list of items.
        /// </summary>
        /// <param name="item">Item to add.</param>
        public void AddItem(Item item)
        {
            items.Add(item);
        }
        /// <summary>
        /// Calculates number of types.
        /// </summary>
        /// <returns>Number of types</returns>
        public int GetNumberOfTypes()
        {
            int counter = 0;
            List<string> types = new List<string>();
            foreach (Item newitem in RepositoryOfItems.GetListOfItems().items)
            {
                string type = newitem.Type;
                if (!types.Contains(type))
                {
                    counter++;
                }
            }
            return counter;
        }
        /// <summary>
        /// Calculates amount of items.
        /// </summary>
        /// <returns>Amount of items.</returns>
        public int GetNumberOfAllItems()
        {
            int counter = 0;
            int numberOfAllItems = 0;
            foreach (Item newitem in RepositoryOfItems.GetListOfItems().items)
            {
                int number = newitem.Amount;
                counter++;
                numberOfAllItems += number;
            }
            return numberOfAllItems;
        }
        /// <summary>
        /// Calculates average price.
        /// </summary>
        /// <returns>Average price.</returns>
        public float GetAveragePrice()
        {
            float averagePrice = 0;
            int counter = 0;
            foreach (Item newitem in RepositoryOfItems.GetListOfItems().items)
            {
                float cost = newitem.Cost;
                averagePrice += cost;
                counter++;
            }
            averagePrice /= counter;
            return averagePrice;
        }
        /// <summary>
        /// Calculates average price of items with one type.
        /// </summary>
        /// <param name="neededType"></param>
        /// <returns>Average price of items with one type.</returns>
        public float GetAveragePriceType(string neededType)
        {
            float averagePrice = 0;
            int counter = 0;

            foreach (Item newitem in RepositoryOfItems.GetListOfItems().items)
            {
                float cost = newitem.Cost;
                string type = newitem.Type;
                if (neededType == type)
                {
                    averagePrice += cost;
                    counter++;
                }
            }
            averagePrice /= counter;
            return averagePrice;
        }
    }
}
