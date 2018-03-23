using System.Collections;

namespace DEV_6
{
    /// <summary>
    /// Class-container.
    /// </summary>
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
        public int Amount
        {
            get
            {
                return amount;
            }
            private set { }
        }
        public float Cost
        {
            get
            {
                return cost;
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

        /// <summary>
        /// Redefinition of GetEnumerator method of IEnumerator interface.
        /// </summary>
        /// <returns>Throw Exception</returns>
        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}