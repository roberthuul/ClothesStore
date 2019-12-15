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
                    Name = "T-särk",
                    Price = 19.90,
                    Category = Category.Men
                },
                new Item
                {
                    Name = "Pluus",
                    Price = 14.90,
                    Category = Category.Kids
                },
                new Item
                {
                    Name = "Teksapüksid",
                    Price = 29.90,
                    Category = Category.Women
                });
        }
    }
}