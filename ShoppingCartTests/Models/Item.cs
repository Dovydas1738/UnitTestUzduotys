using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartTests.Models
{
    public class Item
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Item(string itemName, int quantity, decimal price)
        {
            ItemName = itemName;
            Quantity = quantity;
            Price = price;
        }
    }
}
