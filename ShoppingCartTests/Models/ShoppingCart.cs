using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartTests.Models
{
    public class ShoppingCart : IShoppingCart
    {
        public List<Item> Items;
        public ShoppingCart()
        {
            Items = new List<Item>();
        }

        public void AddItem (string itemName, int quantity, decimal price)
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

        public void RemoveItem (string itemName)
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

        public decimal GetTotalPrice()
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
    }
    public interface IShoppingCart
    {
        void AddItem(string itemName, int quantity, decimal price);
        void RemoveItem(string itemName);
        decimal GetTotalPrice();
        List<Item> GetItems();
    }
}
