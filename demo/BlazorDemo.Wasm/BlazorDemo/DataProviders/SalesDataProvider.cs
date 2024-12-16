using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemo.Data.Sales;
using DevExpress.Data.Utils;

namespace BlazorDemo.DataProviders {
    public class SalesDataProvider : ISalesDataProvider {
        readonly static NonCryptographicRandom random = NonCryptographicRandom.Default;
        static readonly string[] FirstNames = { "Julia", "Stephanie", "Alex", "John", "Curtis", "Keith", "Timothy", "Jack", "Miranda", "Alice" };
        static readonly string[] LastNames = { "Black", "White", "Brown", "Smith", "Cooper", "Parker", "Walker", "Hunter", "Burton", "Douglas", "Fox", "Simpson" };
        static readonly string[] Adjectives = { "Ancient", "Modern", "Mysterious", "Elegant", "Red", "Green", "Blue", "Amazing", "Wonderful", "Astonishing", "Lovely", "Beautiful", "Inexpensive", "Famous", "Magnificent", "Fancy" };
        static readonly string[] ProductNames = { "Ice Cubes", "Bicycle", "Desk", "Hamburger", "Notebook", "Tea", "Cellphone", "Butter", "Frying Pan", "Napkin",
                    "Armchair", "Chocolate", "Yoghurt", "Statuette", "Keychain" };
        static readonly string[] CategoryNames = { "Business", "Presents", "Accessories", "Home", "Hobby" };

        public Task<IList<SaleEntity>> GetDataAsync(int recordsCount) {
            return Task.Factory.StartNew(() => {
                return GenerateData(recordsCount);
            });
        }

        static IList<SaleEntity> GenerateData(int recordsCount) {
            int rowsRemaining = recordsCount;
                int salesPersonCount = random.Next(40, 50);
                int customersCount = random.Next(40, 50);
                int productsCount = random.Next(80, 100);
                List<string> peopleNames = GeneratePeopleNames(salesPersonCount + customersCount);
                List<string> fullProductNames = GenerateProductNames(productsCount);
                int indexPersonName = 0;

                List<SalesPersonEntity> salesPeople = new List<SalesPersonEntity>();
                for(int i = 0; i < salesPersonCount; i++) {
                    salesPeople.Add(new SalesPersonEntity(peopleNames[indexPersonName]));
                    indexPersonName++;
                }
                List<CustomerEntity> customers = new List<CustomerEntity>();
                for(int i = 0; i < customersCount; i++) {
                    customers.Add(new CustomerEntity(peopleNames[indexPersonName]));
                    indexPersonName++;
                }
                List<CategoryEntity> categories = new List<CategoryEntity>();
                for(int i = 0; i < CategoryNames.Length; i++)
                    categories.Add(new CategoryEntity(CategoryNames[i]));
                List<ProductEntity> products = new List<ProductEntity>();
                for(int i = 0; i < productsCount; i++)
                    products.Add(new ProductEntity(fullProductNames[i], categories[random.Next(categories.Count)], random.Next(500)));

                List<SaleEntity> sales = new List<SaleEntity>();
                do {
                    for(int k = 0; k < 300; k++) {
                        OrderEntity order = new OrderEntity(salesPeople[random.Next(salesPeople.Count)], customers[random.Next(customers.Count)], GetDate());
                        int salesCount = rowsRemaining >= 5 ? random.Next(1, 6) : rowsRemaining;
                        for(int j = 0; j < salesCount; j++) {
                            ProductEntity product = products[random.Next(products.Count)];
                            sales.Add(new SaleEntity(order, product, random.Next(1, 100), GetProductPrice(product)));
                            rowsRemaining--;
                        }
                    }
                }
                while(rowsRemaining > 0);

            return sales;
        }

        static List<string> GeneratePeopleNames(int count) {
            HashSet<string> names = new HashSet<string>(count);
            while(names.Count < count)
                names.Add(GeneratePeopleName());
            return names.ToList();
        }
        static List<string> GenerateProductNames(int count) {
            HashSet<string> names = new HashSet<string>(count);
            while(names.Count < count)
                names.Add(GenerateProductName());
            return names.ToList();
        }
        static string GeneratePeopleName() {
            return FirstNames[random.Next(FirstNames.Length)] + " " + LastNames[random.Next(LastNames.Length)];
        }
        static string GenerateProductName() {
            return Adjectives[random.Next(Adjectives.Length)] + " " + ProductNames[random.Next(ProductNames.Length)];
        }
        static decimal GetProductPrice(ProductEntity product) {
            return product.Price * (decimal)(0.5 + random.NextDouble());
        }
        static DateTime GetDate() {
            DateTime dateTime = DateTime.Now;
            return new DateTime(random.Next(dateTime.Year - 1, dateTime.Year + 1), random.Next(1, 13), random.Next(1, 28));
        }
    }
}
