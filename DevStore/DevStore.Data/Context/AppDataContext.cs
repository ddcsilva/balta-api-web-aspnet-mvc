using DevStore.Domain;
using System.Data.Entity;

namespace DevStore.Data.Context
{
    public class AppDataContext : DbContext
    {
        public AppDataContext() : base("AppConnectionString") { }

        public DbSet<Product> Products { get; set; }
    }
}
