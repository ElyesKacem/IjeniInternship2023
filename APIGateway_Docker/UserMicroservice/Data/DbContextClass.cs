using Microsoft.EntityFrameworkCore;
using UserMicroservice.Model;

namespace UserMicroservice.Data
{
    public class DbContextClass : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {
        }
    }
}
