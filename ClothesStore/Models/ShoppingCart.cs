using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothesStore.Models
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }
        public double Sum { get; set; }
        public DateTime DateCreated { get; private set; }

        public bool Paid { get; set; }
        public virtual ICollection<Item> Items { get; set; }

        public ShoppingCart()
        {
            Id = Guid.NewGuid();
            DateCreated = DateTime.Now;
            Sum = 0;
            Items = new List<Item>();
            Paid = false;
        }

        public void addToCart(Item item)
        {
            Items.Add(item);
            Sum += item.Price;
        }

    }
}