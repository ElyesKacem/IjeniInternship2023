using Microsoft.EntityFrameworkCore;
using ProductMicroservice.Model;

namespace ProductMicroservice.Data
{
    public class DbContextClass : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {
        }
    }
}
