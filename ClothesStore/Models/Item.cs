using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothesStore.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<string> AvailableSizes = new List<string>();
        public IList<string> Sizes { get { return AvailableSizes; } }
        public double Price { get; set; }

        public ICollection<ShoppingCart> ShoppingCarts { get; set; }

        public Category Category { get; set; }

        public Item()
        {
            Id = Guid.NewGuid();
            AvailableSizes.Add("XS|");
            AvailableSizes.Add("S|");
            AvailableSizes.Add("M|");
            AvailableSizes.Add("L|");
            AvailableSizes.Add("XL|");
            AvailableSizes.Add("XXL");
        }

        public string DisplaySizes()
        {
            string sizes = "";
            foreach (var item in AvailableSizes)
            {
                sizes = sizes + item + " ";
            }
            return sizes;
        }
    }

    public enum Category { Men, Women, Kids }
}