using ShoppingCartTests.Models;
using System.Diagnostics;

namespace ShoppingCartUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddTest()
        {
            IShoppingCart operations = new ShoppingCart();
            string itemName = "milk";
            int quantity = 4;
            decimal price = 1;

            operations.AddItem(itemName, quantity, price);

            Assert.Equal(1, operations.GetItems().Count);
        }

        [Fact]
        public void RemoveTest()
        {
            IShoppingCart operations = new ShoppingCart();
            string itemName = "milk";
            int quantity = 4;
            decimal price = 1;

            operations.AddItem(itemName, quantity, price);
            operations.RemoveItem(itemName);

            Assert.Equal(0, operations.GetItems().Count);


        }

        [Fact]
        public void TotalPriceTest()
        {
            IShoppingCart operations = new ShoppingCart();
            string itemName = "milk";
            int quantity = 4;
            decimal price = 1;
            string itemName2 = "eggs";
            int quantity2 = 2;
            decimal price2 = 2;
            decimal result = 8;

            operations.AddItem(itemName, quantity, price);
            operations.AddItem(itemName2, quantity2, price2);

            decimal actualResult = operations.GetTotalPrice();

            Assert.Equal(result, actualResult);
        }

        [Fact]
        public void GetItemsTest()
        {
            IShoppingCart operations = new ShoppingCart();
            string itemName = "milk";
            int quantity = 4;
            decimal price = 1;
            string itemName2 = "eggs";
            int quantity2 = 2;
            decimal price2 = 2;
            decimal result = 8;

            operations.AddItem(itemName, quantity, price);
            operations.AddItem(itemName2, quantity2, price2);

            Assert.NotEqual(0, operations.GetItems().Count);
            Assert.NotNull(operations.GetItems());
        }
    }
}