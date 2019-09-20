using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Blazor.Model {
    public class OrderRepository {
        private static IList<Order> GenerateData() {
            Random random = new Random();

            var productNames = new List<string> { "Alice Mutton", "Aniseed Syrup5", "Boston Crab Meat", "Camembert Pierrot", "Carnarvon Tigers", "Chai", "Chang", "Chartreuse verte", "Chef Anton's Cajun Seasoning", "Chef Anton's Gumbo Mix1", "Chocolade", "Côte de Blaye", "Escargots de Bourgogne", "Filo Mix", "Flotemysost", "Geitost", "Genen Shouyu", "Gnocchi di nonna Alice", "Gorgonzola Telino", "Grandma's Boysenberry Spread", "Gravad lax", "Guaraná Fantástica", "Gudbrandsdalsost", "Gula Malacca", "Gumbär Gummibärchen", "Gustaf's Knäckebröd", "Ikura", "Inlagd Sill", "Ipoh Coffee", "Jack's New England Clam Chowder", "Konbu", "Laughing Lumberjack Lager", "Longlife Tofu", "Louisiana Fiery Hot Pepper Sauce", "Louisiana Hot Spiced Okra", "Manjimup Dried Apples", "Mascarpone Fabioli", "Maxilaku", "Mishi Kobe Niku", "Mozzarella di Giovanni", "Nord-Ost Matjeshering", "Northwoods Cranberry Sauce", "NuNuCa Nuß-Nougat-Creme", "Original Frankfurter grüne Soße", "Outback Lager", "Pâté chinois", "Perth Pasties", "Queso Cabrales", "Queso Manchego La Pastora", "Raclette Courdavault", "Ravioli Angelo", "Rhönbräu Klosterbier", "Röd Kaviar", "Rogede sild", "Rössle Sauerkraut", "Sasquatch Ale", "Schoggi Schokolade", "Scottish Longbreads", "Singaporean Hokkien Fried Mee", "Sir Rodney's Marmalade", "Sir Rodney's Scones", "Sirop d'érable", "Spegesild", "Steeleye Stout", "Tarte au sucre", "Teatime Chocolate Biscuits", "Thüringer Rostbratwurst", "Tofu", "Tourtière", "Tunnbröd", "Uncle Bob's Organic Dried Pears", "Valkoinen suklaa", "Vegie-spread", "Wimmers gute Semmelknödel", "Zaanse koeken" };
            IList<Order> orders = new List<Order>();
            foreach (var productName in productNames) {
                var order = new Order() {
                    OrderID = 1,
                    OrderDate = DateTime.Now.AddDays(-random.Next(0, 15)),
                    Price = random.Next(1, 12),
                    Product = productName,
                    ShipRegionID = random.Next(1, 4),
                };
                orders.Add(order);
            }
            return orders;
        }

        public static Task<IEnumerable<Order>> Load() {
            return Task.FromResult<IEnumerable<Order>>(GenerateData());
        }

    }
}
