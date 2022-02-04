using Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class BuildingContext : DbContext
    {
        public BuildingContext()
        {
        }
        public BuildingContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Brigade> Brigades { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Place> Places { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-6149JFK;Initial Catalog=HomeBuild;Integrated Security=True;Pooling=False");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
