using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartTests.Models
{
    public class ShoppingCart
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
            Items.Remove(Items.Find(x => x.ItemName == itemName));
        }
    }
}
