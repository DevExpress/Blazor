
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Sql.DataApi;
using System.Collections.Generic;

namespace BlazorDemo.Reports.CachedDocumentSourceReport {
    public class Customer {
        static List<Customer> currentCustomers = new List<Customer>();

        public static List<Customer> Customers { get { return currentCustomers; } }
        static Customer() {
            try {
                SqlDataSource ds = new SqlDataSource("NWindConnectionString");
                SelectQuery query = SelectQueryFluentBuilder
                    .AddTable("Customers")
                    .SelectAllColumns()
                    .Build("Customers");
                ds.Queries.Add(query);
                ds.RebuildResultSchema();
                ds.Fill();
                ITable src = ds.Result["Customers"];
                foreach(var row in src) {
                    currentCustomers.Add(new Customer() {
                        CustomerID = row.GetValue<string>("CustomerID"),
                        Address = row.GetValue<string>("Address"),
                        CompanyName = row.GetValue<string>("CompanyName"),
                        ContactName = row.GetValue<string>("ContactName"),
                        ContactTitle = row.GetValue<string>("ContactTitle"),
                        Country = row.GetValue<string>("Country"),
                        City = row.GetValue<string>("City"),
                        Fax = row.GetValue<string>("Fax"),
                        Phone = row.GetValue<string>("Phone"),
                        PostalCode = row.GetValue<string>("PostalCode"),
                        Region = row.GetValue<string>("Region")
                    });
                }
            } catch {
                currentCustomers.Add(new Customer() { 
                    Address = "Obere Str. 57",
                    City = "Berlin",
                    CompanyName = "Alfreds Futterkiste",
                    ContactName = "Maria Anders",
                    ContactTitle = "Sales Representative",
                    Country = "Germany",
                    CustomerID = "ALFKI",
                    Fax = "030-0076545",
                    Phone = "030-0074321",
                    PostalCode = "12209"
                });
            }
        }

        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

    }
}
