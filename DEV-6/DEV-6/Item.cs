using System.Collections;
using System.Collections.Generic;

namespace DEV_6
{
    class Item : IEnumerable 
    {
        public string Type
        {
            get
            {
                return type;
            }
            private set { }
        }
        private string type;
        private string name;
        private int amount;
        private float cost;

        public Item() { }
        public Item(string type, string name, int amount, float cost)
        {
            this.type = type;
            this.name = name;
            this.amount = amount;
            this.cost = cost;
        }

        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}