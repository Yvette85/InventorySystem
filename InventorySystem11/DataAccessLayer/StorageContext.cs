using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using InventorySystem11.Models;

namespace InventorySystem11.DataAccessLayer
{
    public class StorageContext:DbContext
    {
        public StorageContext() : base("DefaultConnection")
        {

        }
        public DbSet<Product> Products { get; set; }

        //public System.Data.Entity.DbSet<InventorySystem11.Models.ViewModel> ViewModels { get; set; }
    }
}