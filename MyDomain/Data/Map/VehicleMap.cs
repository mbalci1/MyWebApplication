
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace myApp.Data.Map
{
    public class VehicleMap:IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> modelBuilder)
        {
            modelBuilder.HasKey(a => a.Id);
            modelBuilder.HasIndex(u => u.Guid).IsUnique(true);
            modelBuilder.Property(b => b.RecordDate).HasDefaultValueSql("getdate()");
            modelBuilder.ToTable(nameof(Vehicle));
        }
    }
}
