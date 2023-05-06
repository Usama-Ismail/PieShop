using Microsoft.EntityFrameworkCore;

namespace PieShop.Models
{
    public class PieDbContext:DbContext
    {
        public PieDbContext(DbContextOptions<PieDbContext> options):base(options)
        {
            
        }

        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
