using Microsoft.EntityFrameworkCore;

namespace TutorialApp
{
    public class LocalDbContext : DbContext
    {
        public LocalDbContext(DbContextOptions<LocalDbContext> options) : base(options)
        {
        }

        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

// dotnet tool install --global dotnet-ef
// dotnet ef migrations add initialSchema
// dotnet ef database update --verbose