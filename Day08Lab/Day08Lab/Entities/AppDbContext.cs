using Microsoft.EntityFrameworkCore;
using Day08Lab.Models;
namespace Day08Lab.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories {  get; set; }
        public DbSet<Product> Products {  get; set; }
        protected AppDbContext()
        {
        }
    }
}
