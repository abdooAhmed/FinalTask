using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Mooo.Models;

namespace Mooo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Department> Dapartments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Section> Sections { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
