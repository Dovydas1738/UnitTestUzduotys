using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApplication.Models
{
    public class Order : IOrder
    {
        public List<Item> Items;

        public Order()
        {
            Items = new List<Item>();
        }

        public void AddItem(string itemName, int quantity, decimal price)
        {
            try
            {
                Item newItem = new Item(itemName, quantity, price);
                Items.Add(newItem);
            }
            catch
            {
                throw new Exception("Check inputs!");
            }
        }

        public void RemoveItem(string itemName)
        {
            try
            {
                Items.Remove(Items.Find(x => x.ItemName == itemName));
            }
            catch
            {
                throw new Exception("No such item found.");
            }

        }

        public decimal GetTotalAmount()
        {
            decimal totalPrice = 0;
            foreach (Item item in Items)
            {
                totalPrice += item.Price * item.Quantity;
            }
            return totalPrice;
        }

        public List<Item> GetItems()
        {
            return Items;
        }

        public decimal ApplyDiscount(decimal discountPercentage)
        {
            decimal totalPrice = GetTotalAmount();

            return totalPrice * discountPercentage;
        }
    }

    public interface IOrder
    {
        void AddItem(string itemName, int quantity, decimal price);
        void RemoveItem(string itemName);
        decimal GetTotalAmount();
        List<Item> GetItems();
        decimal ApplyDiscount(decimal discountPercentage);
    }
}
