using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoWebFormEntity.Models
{
    public class WebFormDbContext : DbContext
    {
        public WebFormDbContext() : base("WebFormEFCodeFirst") { }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
    }
}