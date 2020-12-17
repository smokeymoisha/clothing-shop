using ClothingShop.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ClothingShop.DataAccess
{
    public class ClothingShopContext : DbContext
    {
        public ClothingShopContext(DbContextOptions<ClothingShopContext> options): base(options)
        {
            //Database.EnsureCreated();
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
