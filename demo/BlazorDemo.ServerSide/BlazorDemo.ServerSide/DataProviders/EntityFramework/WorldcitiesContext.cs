using BlazorDemo.Data.Worldcities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorDemo.DataProviders {
    public partial class WorldcitiesContext : DbContext {
        public WorldcitiesContext() {
        }
        public WorldcitiesContext(DbContextOptions<WorldcitiesContext> options)
            : base(options) {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Country>(entity => {
                entity.HasKey(t => new { t.CountryId });
                // Properties
                entity.Property(t => t.CountryId);
                entity.Property(t => t.CountryName)
                    .HasMaxLength(255);
                entity.Property(t => t.CapitalId);
            });
            modelBuilder.Entity<City>(entity => {
                entity.HasKey(t => new { t.CityId });
                // Properties
                entity.Property(t => t.CityId);
                entity.Property(t => t.CityName)
                    .HasMaxLength(255);
                entity.Property(t => t.CountryId);
            });
        }
    }
}
