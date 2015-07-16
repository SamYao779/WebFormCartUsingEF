using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoWebFormEntity.Models
{
    public class WebFormInitializer : DropCreateDatabaseIfModelChanges<WebFormDbContext>
    {
        protected override void Seed(WebFormDbContext context)
        {
            base.Seed(context);

            context.Categories.Add(new Category { Name = "Nokia", Origin = "Phần Lan" });
            context.Categories.Add(new Category { Name = "Apple", Origin = "Mỹ" });
            context.Categories.Add(new Category { Name = "SamSung", Origin = "Hàn Quốc" });
            context.Categories.Add(new Category { Name = "HTC", Origin = "Đài Loan" });
            context.Categories.Add(new Category { Name = "Asus", Origin = "Đài Loan" });

            context.Products.Add(new Product { Name = "Iphone 6 Plus", Quantity = 100, CategoryId = 2, UnitPrice = 640 });
            context.Products.Add(new Product { Name = "Nokia 1020", Quantity = 200, CategoryId = 1, UnitPrice = 510 });
            context.Products.Add(new Product { Name = "Iphone 5S", Quantity = 100, CategoryId = 2, UnitPrice = 400 });
            context.Products.Add(new Product { Name = "One M9", Quantity = 300, CategoryId = 4, UnitPrice = 740 });
            context.Products.Add(new Product { Name = "Galaxy S6", Quantity = 100, CategoryId = 3, UnitPrice = 790 });
            context.Products.Add(new Product { Name = "One E8", Quantity = 100, CategoryId = 4, UnitPrice = 430 });
            context.Products.Add(new Product { Name = "ZenFone 2", Quantity = 400, CategoryId = 5, UnitPrice = 230 });
            context.Products.Add(new Product { Name = "Galaxy S6 Edge", Quantity = 100, CategoryId = 3, UnitPrice = 850 });

            context.SaveChanges();
        }
    }
}