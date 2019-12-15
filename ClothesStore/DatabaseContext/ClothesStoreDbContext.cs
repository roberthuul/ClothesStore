﻿using ClothesStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ClothesStore.DatabaseContext
{
    public class ClothesStoreDbContext : DbContext
    {
        public DbSet<Item> Items {get; set;}
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}