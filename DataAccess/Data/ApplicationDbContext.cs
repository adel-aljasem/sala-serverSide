using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Product> Product { get; set; }

        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Order { get; set; }

        public DbSet<Image> Images { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }
        public DbSet<TotalOrder> TotalOrder { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }


}
