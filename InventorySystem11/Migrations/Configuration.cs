namespace InventorySystem11.Migrations
{
    using InventorySystem11.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<InventorySystem11.DataAccessLayer.StorageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(InventorySystem11.DataAccessLayer.StorageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            Product p = new Product() { Name = "Samsung ", Price = 7000, Category = "Electronics", Shelf = "Mobilphones", Count = 10, Description = "Galaxy9" };
            context.Products.AddOrUpdate(t => t.Name, p);
            context.Products.AddOrUpdate(t => t.Price, p);
            context.Products.AddOrUpdate(t => t.Category, p);
            context.Products.AddOrUpdate(t => t.Shelf, p);
            context.Products.AddOrUpdate(t => t.Count, p);
            context.Products.AddOrUpdate(t => t.Description, p);
        }
    }
}
