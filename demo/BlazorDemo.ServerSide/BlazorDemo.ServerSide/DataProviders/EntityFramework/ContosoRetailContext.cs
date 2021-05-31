using BlazorDemo.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemo.DataProviders {
    class ContosoRetailContext : DbContext {
        public ContosoRetailContext(DbContextOptions<ContosoRetailContext> options)
            : base(options) {
        }

        public virtual DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.HasAnnotation("ProductVersion", "3.0.0-preview3.19153.1");

            modelBuilder.Entity<Sale>(entity => {
                entity.HasIndex(e => e.DateKey).HasDatabaseName("I_DateKey");
                entity.HasIndex(e => e.ProductCategoryName).HasDatabaseName("I_ProductCategoryName");
                entity.HasIndex(e => e.ProductName).HasDatabaseName("I_ProductName");
                entity.HasIndex(e => e.ProductSubcategoryName).HasDatabaseName("I_ProductSubcategoryName");
                entity.HasIndex(e => e.SalesAmount).HasDatabaseName("I-SalesAmount");
                entity.HasIndex(e => e.StoreName).HasDatabaseName("I_StoreName");

                entity.Property(e => e.DateKey).HasColumnType("datetime");

                entity.Property(e => e.ProductCategoryName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ProductSubcategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesAmount).HasColumnType("money");

                entity.Property(e => e.StoreName).HasMaxLength(100);

                entity.Property(e => e.UnitPrice).HasColumnType("money");
            });
        }
    }
}
