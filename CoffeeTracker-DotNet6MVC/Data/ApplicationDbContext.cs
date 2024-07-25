using CoffeeTracker_DotNet6MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeTracker_DotNet6MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<CoffeeDay> CoffeeDays { get; set; }
    }
}
