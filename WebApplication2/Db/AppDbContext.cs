using Microsoft.EntityFrameworkCore;
using WebApplication2.Entities;

namespace WebApplication2.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Product> Products { get; set; }
    }
}
