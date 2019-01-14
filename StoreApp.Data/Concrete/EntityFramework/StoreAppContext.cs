using System.Data.Entity;
using StoreApp.Entities.Concrete;

namespace StoreApp.Data.Concrete.EntityFramework
{
    public class StoreAppContext : DbContext
    {
        public StoreAppContext() : base("StoreAppConnection")
        {
            Database.SetInitializer(new StoreDataInitializer());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
    }
}
