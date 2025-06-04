﻿using Microsoft.EntityFrameworkCore;
using Coffeshop.Models;

namespace Coffeshop.Data
{
    public class CoffeshopDbContext : DbContext
    {
        public CoffeshopDbContext(DbContextOptions<CoffeshopDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "America", Price = 25, Detail = "America product", ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", IsTrendingProduct = true },
                new Product { Id = 2, Name = "Vietnam", Price = 20, Detail = "Vietnam product", ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", IsTrendingProduct = true },
                new Product { Id = 3, Name = "UK", Price = 15, Detail = "UK product", ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", IsTrendingProduct = false },
                new Product { Id = 4, Name = "India", Price = 15, Detail = "India product", ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp" },
                new Product{Id = 5,Name = "Russian",Price = 25,Detail = "Russian product",ImageUrl ="https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp"},
                new Product{Id = 6,Name = "France",Price = 35,Detail = "France product",ImageUrl ="https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp"}
            );
        }

    }
}
