using System;

namespace DEV_6
{
    class RepositoryAddItem : ICommands
    {
        public void Execute()
        {
            Console.WriteLine("Enter the type of an item.");
            string type = Console.ReadLine();
            Console.WriteLine("Enter the name of an item.");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the amount of an item.");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the cost of an item.");
            float cost = float.Parse(Console.ReadLine());
            Item item = new Item(type, name, amount, cost);
            RepositoryOfItems.GetListOfItems().AddItem(item);
            Console.WriteLine("Item added.");
        }
    }
}
