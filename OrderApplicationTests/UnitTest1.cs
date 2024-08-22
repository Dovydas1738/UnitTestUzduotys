using OrderApplication.Models;

namespace OrderApplicationTests
{
    public class UnitTest1
    {
        [Fact]
        public void AddTest()
        {
            IOrder operations = new Order();
            string itemName = "milk";
            int quantity = 4;
            decimal price = 1;

            operations.AddItem(itemName, quantity, price);

            Assert.Equal(1, operations.GetItems().Count);

        }

        [Fact]
        public void RemoveTest()
        {
            IOrder operations = new Order();
            string itemName = "milk";
            int quantity = 4;
            decimal price = 1;

            operations.AddItem(itemName, quantity, price);
            operations.RemoveItem(itemName);

            Assert.Equal(0, operations.GetItems().Count);

        }

        [Fact]
        public void TotalAmountTest()
        {
            IOrder operations = new Order();
            string itemName = "milk";
            int quantity = 6;
            decimal price = 1;
            string itemName2 = "eggs";
            int quantity2 = 2;
            decimal price2 = 2;
            decimal result = 10;

            operations.AddItem(itemName, quantity, price);
            operations.AddItem(itemName2, quantity2, price2);

            decimal actualResult = operations.GetTotalAmount();

            Assert.Equal(result, actualResult);
        }

        [Fact]
        public void GetItemsTest()
        {
            IOrder operations = new Order();
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
            Assert.Equal(itemName, operations.GetItems()[0].ItemName);
        }

        [Fact]
        public void ApplyDiscountTest()
        {
            IOrder operations = new Order();
            string itemName = "milk";
            int quantity = 6;
            decimal price = 1m;
            string itemName2 = "eggs";
            int quantity2 = 2;
            decimal price2 = 2m;
            decimal result = 5m;
            decimal discount = 0.5m;

            operations.AddItem(itemName, quantity, price);
            operations.AddItem(itemName2, quantity2, price2);
            decimal totalPrice = operations.GetTotalAmount();
            decimal actualResult = operations.ApplyDiscount(discount);

            Assert.Equal(result, actualResult);
        }

    }
}