using ClothesStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ClothesStore.DatabaseContext
{
    public class ClothesStoreDbInitializer: DropCreateDatabaseIfModelChanges<ClothesStoreDbContext>
    {
        protected override void Seed(ClothesStoreDbContext context)
        {
            context.Items.AddOrUpdate(x => x.Name,
                new Item
                {
                    Name = "T-shirt",
                    Price = 19.90,
                    Category = Category.Men
                },
                new Item
                {
                    Name = "Blouse",
                    Price = 14.90,
                    Category = Category.Kids
                },
                new Item
                {
                    Name = "Jeans",
                    Price = 29.90,
                    Category = Category.Women
                },
                new Item
                {
                    Name = "Hat",
                    Price = 5.50,
                    Category = Category.Men
                },
                new Item
                {
                    Name = "Shoes",
                    Price = 20.10,
                    Category = Category.Kids
                },
                new Item
                {
                    Name = "Pajamas",
                    Price = 23.90,
                    Category = Category.Kids
                },
                new Item
                {
                    Name = "Dress",
                    Price = 32.90,
                    Category = Category.Women
                },
                new Item
                {
                    Name = "Jacket",
                    Price = 40.50,
                    Category = Category.Men
                },
                new Item
                {
                    Name = "Scarf",
                    Price = 3.05,
                    Category = Category.Women
                });
        }






               
        
    }
}