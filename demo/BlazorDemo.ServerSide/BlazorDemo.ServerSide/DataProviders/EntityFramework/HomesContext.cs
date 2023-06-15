using System;
using System.Collections.Generic;
using BlazorDemo.Data.Homes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorDemo.DataProviders
{
    public partial class HomesContext : DbContext
    {
        public HomesContext() {
        }

        public HomesContext(DbContextOptions<HomesContext> options) : base(options) {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Home> Homes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address).HasColumnType("nvarchar(50)");

                entity.Property(e => e.City).HasColumnType("nvarchar(20)");

                entity.Property(e => e.Company).HasColumnType("nvarchar(50)");

                entity.Property(e => e.Customer1)
                    .HasColumnType("nvarchar(1)")
                    .HasColumnName("Customer");

                entity.Property(e => e.Description).HasColumnType("nvarchar");

                entity.Property(e => e.Email).HasColumnType("nvarchar(255)");

                entity.Property(e => e.FaxPhone).HasColumnType("nvarchar(15)");

                entity.Property(e => e.FirstName).HasColumnType("nvarchar(25)");

                entity.Property(e => e.HomePhone).HasColumnType("nvarchar(15)");

                entity.Property(e => e.Id)
                    .HasColumnType("integer")
                    .HasColumnName("ID");

                entity.Property(e => e.LastName).HasColumnType("nvarchar(25)");

                entity.Property(e => e.Occupation).HasColumnType("nvarchar(25)");

                entity.Property(e => e.Prefix).HasColumnType("nvarchar(15)");

                entity.Property(e => e.Source).HasColumnType("nvarchar(10)");

                entity.Property(e => e.Spouse).HasColumnType("nvarchar(50)");

                entity.Property(e => e.State).HasColumnType("nvarchar(2)");

                entity.Property(e => e.Title).HasColumnType("nvarchar(15)");

                entity.Property(e => e.ZipCode).HasColumnType("nvarchar(10)");
            });

            modelBuilder.Entity<Home>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Price).HasColumnType("NUMERIC");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CustomerId)
                    .HasColumnType("integer")
                    .HasColumnName("CustomerID");

                entity.Property(e => e.Description).HasColumnType("nvarchar");

                entity.Property(e => e.Id)
                    .HasColumnType("integer")
                    .HasColumnName("ID");

                entity.Property(e => e.PaymentAmount).HasColumnType("numeric");

                entity.Property(e => e.PaymentType).HasColumnType("nvarchar(7)");

                entity.Property(e => e.ProductId)
                    .HasColumnType("integer")
                    .HasColumnName("ProductID");

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnType("integer");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
