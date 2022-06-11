using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using myApp.Data.Map;

namespace myApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
                throw new ArgumentException("Model Builder is null!");
        
            modelBuilder.ApplyConfiguration(new VehicleMap());
            modelBuilder.ApplyConfiguration(new TireProductMap());

            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<TireProduct> TireProducts { get; set; }
    }
}