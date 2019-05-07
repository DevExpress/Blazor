using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Demo.Blazor.Model
{
    public partial class FMRDemoContext : DbContext
    {
        public FMRDemoContext(DbContextOptions<FMRDemoContext> options)
            : base(options) { }

        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Rentinfo> Rentinfo { get; set; }

        public virtual DbQuery<AreaRentInfo> AreaRentInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "3.0.0-preview3.19153.1");

            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK__AREA__C2FFCF137F60ED59");

                entity.ToTable("AREA");

                entity.Property(e => e.Oid)
                    .HasColumnName("oid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Area1)
                    .IsRequired()
                    .HasColumnName("area")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Population2000).HasColumnName("population2000");

                entity.Property(e => e.Population2010).HasColumnName("population2010");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Rentinfo>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK__RENTINFO__C2FFCF1303317E3D");

                entity.ToTable("RENTINFO");

                entity.HasIndex(e => e.Area)
                    .HasName("INDEX_RENTINFO_AREA");

                entity.HasIndex(e => e.Bedrooms)
                    .HasName("INDEX_RENTINFO_BEDROOMS");

                entity.HasIndex(e => e.Rent)
                    .HasName("INDEX_RENTINFO_RENT");

                entity.HasIndex(e => e.Year)
                    .HasName("IX_RENTINFO_YEAR");

                entity.Property(e => e.Oid)
                    .HasColumnName("oid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Bedrooms).HasColumnName("bedrooms");

                entity.Property(e => e.Rent)
                    .HasColumnName("rent")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Year).HasColumnName("year");

                entity.HasOne(d => d.AreaNavigation)
                    .WithMany(p => p.Rentinfo)
                    .HasForeignKey(d => d.Area)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RENTINFO__area__0519C6AF");
            });

            modelBuilder.Query<AreaRentInfo>().ToView("AreaRentInfo");
        }
    }
}
