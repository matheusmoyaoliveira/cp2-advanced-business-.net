using Microsoft.EntityFrameworkCore;
using cp2_advanced_business_.net.Models;

namespace cp2_advanced_business_.net.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Animal> Animais { get; set; }
    }
}