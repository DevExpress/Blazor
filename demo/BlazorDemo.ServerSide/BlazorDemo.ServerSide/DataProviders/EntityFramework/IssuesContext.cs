using BlazorDemo.Data.Issues;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorDemo.DataProviders {
    public partial class IssuesContext : DbContext {
        public IssuesContext(DbContextOptions<IssuesContext> options)
            : base(options) {
        }

        public DbSet<Issue> Items { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Issue>(entity => {
                entity.HasKey(t => new { t.ID });
                // Properties
                entity.Property(t => t.ID);
                entity.Property(t => t.Name)
                    .HasMaxLength(50);
                entity.Property(t => t.Description)
                    .HasMaxLength(2147483647);
                entity.Property(t => t.Resolution)
                    .HasMaxLength(2147483647);
                // Table & Column Mappings
                //entity.ToTable("Items");
                entity.Property(t => t.ID).HasColumnName("ID");
                entity.Property(t => t.Name).HasColumnName("Name");
                entity.Property(t => t.Type).HasColumnName("Type");
                entity.Property(t => t.ProjectID).HasColumnName("ProjectID");
                entity.Property(t => t.Priority).HasColumnName("Priority");
                entity.Property(t => t.Status).HasColumnName("Status");
                entity.Property(t => t.CreatorID).HasColumnName("CreatorID");
                entity.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
                entity.Property(t => t.OwnerID).HasColumnName("OwnerID");
                entity.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
                entity.Property(t => t.FixedDate).HasColumnName("FixedDate");
                entity.Property(t => t.Description).HasColumnName("Description");
                entity.Property(t => t.Resolution).HasColumnName("Resolution");
            });
            modelBuilder.Entity<Project>(entity => {
                entity.HasKey(t => t.ID);
                // Properties
                entity.Property(t => t.ID);
                entity.Property(t => t.Name)
                    .HasMaxLength(100);
                // Table & Column Mappings
                //entity.ToTable("Projects");
                entity.Property(t => t.ID).HasColumnName("ID");
                entity.Property(t => t.Name).HasColumnName("Name");
                entity.Property(t => t.ManagerID).HasColumnName("ManagerID");
            });
            modelBuilder.Entity<User>(entity => {
                entity.HasKey(t => t.ID);
                // Properties
                entity.Property(t => t.ID);
                entity.Property(t => t.FirstName)
                    .HasMaxLength(25);
                entity.Property(t => t.LastName)
                    .HasMaxLength(25);
                entity.Property(t => t.Country)
                    .HasMaxLength(15);
                entity.Property(t => t.City)
                    .HasMaxLength(15);
                entity.Property(t => t.Address)
                    .HasMaxLength(60);
                entity.Property(t => t.Phone)
                    .HasMaxLength(24);
                entity.Property(t => t.Email)
                    .HasMaxLength(50);
                // Table & Column Mappings
                //entity.ToTable("Users");
                entity.Property(t => t.ID).HasColumnName("ID");
                entity.Property(t => t.FirstName).HasColumnName("FirstName");
                entity.Property(t => t.LastName).HasColumnName("LastName");
                entity.Property(t => t.Country).HasColumnName("Country");
                entity.Property(t => t.City).HasColumnName("City");
                entity.Property(t => t.Address).HasColumnName("Address");
                entity.Property(t => t.Phone).HasColumnName("Phone");
                entity.Property(t => t.Email).HasColumnName("Email");
            });
        }
    }
}
