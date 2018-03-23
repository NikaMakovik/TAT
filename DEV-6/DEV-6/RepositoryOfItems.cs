using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_6
{
    class RepositoryOfItems
    {
        private static RepositoryOfItems listOfItems;
        private List<Item> items = new List<Item>();
        private RepositoryOfItems() { }

        public static RepositoryOfItems GetListOfItems()
        {
            if (listOfItems == null)
            {
                listOfItems = new RepositoryOfItems();
            }
            return listOfItems;
        }
        public void AddItem(Item item)
        {
            items.Add(item);
        }
        public List<string> GetTypes()
        {
            List<string> types = new List<string>();
            Item item = new Item();
            foreach (Item newitem in RepositoryOfItems.GetListOfItems().items)
            {
                StringBuilder typeString = null;
                foreach (char type in item.Type)
                {
                    typeString.Append(type);
                }
                types.Add(typeString.ToString());
            }
            return types;
        }
    }
}
