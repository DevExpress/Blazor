using BlazorDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorDemo.DataProviders {
    class RentInfoContext : DbContext {
        public RentInfoContext(DbContextOptions<RentInfoContext> options)
            : base(options) { }

        public virtual DbSet<AreaRentInfo> AreaRentInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<AreaRentInfo>(ConfigureAreaRentInfo);

            static void ConfigureAreaRentInfo(EntityTypeBuilder<AreaRentInfo> entity) {
                entity.HasKey(e => e.Oid);
                entity.Property(e => e.Rent).HasColumnType("money");
            };
        }

    }
}
