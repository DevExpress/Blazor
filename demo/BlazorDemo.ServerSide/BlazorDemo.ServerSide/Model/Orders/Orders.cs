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
            int startOrderId = 123;

            foreach (var productName in productNames) {
                var OrderDate = DateTime.Now.AddDays(-random.Next(0, 15));
                var order = new Order() {
                    OrderID = startOrderId++,
                    Product = productName,
                    OrderDate = OrderDate,
                    ShippedDate = OrderDate.AddHours(random.Next(5, 55)),
                    UnitPrice = random.Next(1, 12),
                    ShipRegionID = random.Next(1, 4),
                    UnitsInOrder = random.Next(1, 43),
                    OrderStatus = random.Next(1, 100) < 70 ? OrderStatus.Processing : (random.Next(1, 100) < 50 ? OrderStatus.InTransit : OrderStatus.Delivered)
                };
                orders.Add(order);
            }
            return orders;
        }

        public static Task<IEnumerable<Order>> Load() {
            return Task.FromResult<IEnumerable<Order>>(GenerateData());
        }
        static Lazy<List<Order>> DataPreset1 = new Lazy<List<Order>>(() => {
            var dateTimeNow = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            var Orders = new List<Order>() {
            new Order() { OrderID=125, OrderDate = dateTimeNow.AddDays(-5), ShippedDate = dateTimeNow.AddDays(-0), UnitPrice = 5, UnitsInOrder=122 , Product="Guaraná Fantástica"},
            new Order() { OrderID=124, OrderDate = dateTimeNow.AddDays(-4), ShippedDate = dateTimeNow.AddDays(-1), UnitPrice = 18, UnitsInOrder=21 , Product="Chai"},
            new Order() { OrderID=133, OrderDate = dateTimeNow.AddDays(-3), ShippedDate = dateTimeNow.AddDays(-1), UnitPrice = 19, UnitsInOrder=33 , Product="Chang"},
            new Order() { OrderID=123, OrderDate = dateTimeNow.AddDays(-3), ShippedDate = dateTimeNow.AddDays(-0), UnitPrice = 14, UnitsInOrder=24 , Product="Sasquatch Ale"},
            new Order() { OrderID=126, OrderDate = dateTimeNow.AddDays(-3), ShippedDate = dateTimeNow.AddDays(-1), UnitPrice = 12, UnitsInOrder=39 , Product="Chartreuse verte"},
            new Order() { OrderID=127, OrderDate = dateTimeNow.AddDays(-4), ShippedDate = dateTimeNow.AddDays(-2), UnitPrice = 46, UnitsInOrder=158 , Product="Ipoh Coffee"},
            new Order() { OrderID=131, OrderDate = dateTimeNow.AddDays(-4), ShippedDate = dateTimeNow.AddDays(-0), UnitPrice = 18, UnitsInOrder=206 , Product="Lakkalikööri"},
            new Order() { OrderID=128, OrderDate = dateTimeNow.AddDays(-5), ShippedDate = dateTimeNow.AddDays(-0), UnitPrice = 15, UnitsInOrder= 6 , Product="Outback Lager"},
            new Order() { OrderID=129, OrderDate = dateTimeNow.AddDays(-2), ShippedDate = dateTimeNow.AddDays(-1), UnitPrice = 18, UnitsInOrder=30 , Product="Steeleye Stout"},
            new Order() { OrderID=120, OrderDate = dateTimeNow.AddDays(-3), ShippedDate = dateTimeNow.AddDays(-2), UnitPrice = 263, UnitsInOrder=26 , Product="Côte de Blaye"},
            };
            return Orders;
        });
        public static Task<IEnumerable<Order>> LoadDataPreset() {
            return Task.FromResult<IEnumerable<Order>>(DataPreset1.Value);
        }
    }
}
