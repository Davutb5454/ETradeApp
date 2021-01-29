using System.Data.Entity;
using ETradeApp.Entities.Concrete;

namespace ETradeApp.DataAccess.Concrete.EntityFramework
{
    public class ETradeContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}