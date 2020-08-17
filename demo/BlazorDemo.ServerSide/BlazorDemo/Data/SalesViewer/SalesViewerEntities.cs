using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace BlazorDemo.Data.SalesViewer {
    [Guid("D5A69515-31AE-4CB1-BE9E-57261ECE6001")]
    public partial class Channel {
        public Channel() {
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }

    [Guid("D5A69515-31AE-4CB1-BE9E-57261ECE6002")]
    public partial class City {
        public City() {
            Contacts = new HashSet<Contact>();
            Customers = new HashSet<Customer>();
            Plants = new HashSet<Plant>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Map { get; set; }
        public string Country { get; set; }
        public string State { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Plant> Plants { get; set; }
    }

    [Guid("D5A69515-31AE-4CB1-BE9E-57261ECE6003")]
    public partial class Contact {
        public Contact() {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public int? CityId { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }

    [Guid("D5A69515-31AE-4CB1-BE9E-57261ECE6004")]
    public partial class Customer {
        public Customer() {
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }

        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }

    [Guid("D5A69515-31AE-4CB1-BE9E-57261ECE6005")]
    public partial class Plant {
        public Plant() {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }

    [Guid("D5A69515-31AE-4CB1-BE9E-57261ECE6006")]
    public partial class Product {
        public Product() {
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double BaseCost { get; set; }
        public double ListPrice { get; set; }
        public int UnitsInInventory { get; set; }
        public int PlantId { get; set; }
        public int ProjectManagerId { get; set; }
        public int SupportManagerId { get; set; }
        public int UnitsInManufacturing { get; set; }
        public virtual Contact ProjectManager { get; set; }
        public virtual Contact SupportManager { get; set; }
        public virtual Plant Plant { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }

    [Guid("D5A69515-31AE-4CB1-BE9E-57261ECE6007")]
    public partial class Region {
        public Region() {
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }

    [Guid("D5A69515-31AE-4CB1-BE9E-57261ECE6008")]
    public partial class Sale {
        public int Id { get; set; }
        public int Units { get; set; }
        public double CostPerUnit { get; set; }
        public double Discount { get; set; }
        public double TotalCost { get; set; }
        public DateTime SaleDate { get; set; }
        public int ProductId { get; set; }
        public int RegionId { get; set; }
        public int ChannelId { get; set; }
        public int SectorId { get; set; }
        public int CustomerId { get; set; }
        public virtual Channel Channel { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public virtual Region Region { get; set; }
        public virtual Sector Sector { get; set; }
    }

    [Guid("D5A69515-31AE-4CB1-BE9E-57261ECE6009")]
    public partial class Sector {
        public Sector() {
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
