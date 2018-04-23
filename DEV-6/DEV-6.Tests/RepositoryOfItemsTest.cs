using System;
using Xunit;

namespace DEV_6.Tests
{
    public class RepositoryOfItemsTest
    {
        [Theory]
        [InlineData("type", "name", 2, 3, 1)]
        public void GetNumberOfTypes_GetValidResult(string type, string name, int amount, float cost, int expected)
        {
            Item item = new Item(type, name, amount, cost);
            RepositoryOfItems.GetListOfItems().AddItem(item);
            Assert.Equal(expected, RepositoryOfItems.GetListOfItems().GetNumberOfTypes());
        }

        [Theory]
        [InlineData("type", "name", 2, 3, 4)]
        public void GetNumberOfAllItems_GetValidResult(string type, string name, int amount, float cost, int expected)
        {
            Item item = new Item(type, name, amount, cost);
            RepositoryOfItems.GetListOfItems().AddItem(item);
            Assert.Equal(expected, RepositoryOfItems.GetListOfItems().GetNumberOfAllItems());
        }

        [Theory]
        [InlineData("type", "name", 2, 3, 3)]
        public void GetAveragePrice_GetValidResult(string type, string name, int amount, float cost, int expected)
        {
            Item item = new Item(type, name, amount, cost);
            RepositoryOfItems.GetListOfItems().AddItem(item);
            Assert.Equal(expected, RepositoryOfItems.GetListOfItems().GetAveragePrice());
        }

        [Theory]
        [InlineData("type", "name", 2, 3, 3)]
        public void GetAveragePriceType_GetValidResult(string type, string name, int amount, float cost, int expected)
        {
            Item item = new Item(type, name, amount, cost);
            RepositoryOfItems.GetListOfItems().AddItem(item);
            Assert.Equal(expected, RepositoryOfItems.GetListOfItems().GetAveragePriceType(type));
        }
    }
}
