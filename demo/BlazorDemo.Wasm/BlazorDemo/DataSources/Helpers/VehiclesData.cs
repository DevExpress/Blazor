using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using DevExpress.Blazor.Internal;
using DevExpress.Data.Utils;
using DevExpress.Drawing;
using DevExpress.Drawing.Internal;

namespace BlazorDemo.Data {
    public partial class VehiclesData {
        public enum Category {
            Car = 1,
            [Display(Name = "Crossover & SUV")]
            CrossoverAndSUV = 2,
            Truck = 3,
            Minivan = 4
        }
        public enum BodyStyle {
            Convertible = 1,
            Coupe = 2,
            Hatchback = 3,
            [Display(Name = "Passenger Van")]
            PassengerVan = 4,
            Pickup = 5,
            Sedan = 6,
            [Display(Name = "Sport Utility Vehicle")]
            SportUtilityVehicle = 7,
            Wagon = 8
        }
        public class Trademark {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        public class TrademarkBody : TrademarkItem {
            public TrademarkBody(OrderItem item, int id)
                : base(id) {
                Model = item.Model;

                ModelPrice = item.Model.Price;
                Name = item.Model.Name;
                Modification = item.Model.Modification;
                Category = item.Model.Category;
                MPGCity = item.Model.MPGCity;
                MPGHighway = item.Model.MPGHighway;
                Doors = item.Model.Doors;
                BodyStyle = item.Model.BodyStyle;
                Cylinders = item.Model.Cylinders;
                Horsepower = item.Model.Horsepower;
                Torque = item.Model.Torque;
                TransmissionSpeeds = item.Model.TransmissionSpeeds;
                TransmissionType = item.Model.TransmissionType;
                Trademark = item.Model.Trademark;
                TrademarkID = item.Model.Trademark - 1;
                TrademarkName = item.Model.TrademarkName;

                SalesDate = item.SalesDate;
                Discount = item.Discount;
            }
        }

        public class OrderItem {
            internal Model Model;
            public OrderItem(Model model, int days, NonCryptographicRandom rnd, int id) {
                Model = model;
                ModelPrice = model.Price;
                Trademark = model.Trademark;
                Name = model.Name;
                Modification = model.Modification;
                Category = model.Category;
                MPGCity = model.MPGCity;
                MPGHighway = model.MPGHighway;
                Doors = model.Doors;
                BodyStyle = model.BodyStyle;
                Cylinders = model.Cylinders;
                Horsepower = model.Horsepower;
                Torque = model.Torque;
                TransmissionSpeeds = model.TransmissionSpeeds;
                TransmissionType = model.TransmissionType;

                SalesDate = DateTime.Now.AddDays(-rnd.Next(days));
                Discount = Math.Round(0.05 * rnd.Next(4), 2);
                OrderID = id;
            }
            public int OrderID { get; set; }
            public DateTime SalesDate { get; set; }
            public double Discount { get; set; }
            [DataType(DataType.Currency)]
            public decimal? ModelPrice { get; set; }
            public int Trademark { get; set; }
            public string Name { get; set; }
            public string Modification { get; set; }
            public int Category { get; set; }
            public int? MPGCity { get; set; }
            public int? MPGHighway { get; set; }
            public int Doors { get; set; }
            public int BodyStyle { get; set; }
            public int Cylinders { get; set; }
            public string Horsepower { get; set; }
            public string Torque { get; set; }
            public int TransmissionSpeeds { get; set; }
            public int TransmissionType { get; set; }
        }

        public class Model {
            public int ID { get; set; }
            public int Trademark { get; set; }
            public string Name { get; set; }
            public string Modification { get; set; }
            public int Category { get; set; }
            public decimal? Price { get; set; }
            public int? MPGCity { get; set; }
            public int? MPGHighway { get; set; }
            public int Doors { get; set; }
            public int BodyStyle { get; set; }
            public int Cylinders { get; set; }
            public string Horsepower { get; set; }
            public string Torque { get; set; }
            public int TransmissionSpeeds { get; set; }
            public int TransmissionType { get; set; }
            public string Description { get; set; }
            public DateTime DeliveryDate { get; set; }
            public bool InStock { get; set; }

            public string TrademarkName => Trademarks?[Trademark - 1].Name ?? string.Empty;

            public List<Trademark> Trademarks { get; set; } = null;
        }

        public class OrdersData {
            public OrdersData(DataSet ds, List<Trademark> trademarks, List<Model> models, int itemCount, int days) {
                var rnd = NonCryptographicRandom.Default;
                DataSet = ds;
                Trademarks = trademarks;
                TrademarkItems = new List<TrademarkItem>();
                var orders = new List<OrderItem>();
                for(var i = 0; i < itemCount; i++)
                    orders.Add(new OrderItem(models[rnd.Next(0, models.Count - 1)], days, rnd, i + 1));
                var id = 0;
                foreach(var item in orders) {
                    TrademarkItems.Add(new TrademarkBody(item, id));
                    id++;
                }
            }

            public DataSet DataSet { get; private set; }
            public List<Trademark> Trademarks { get; private set; }
            public List<TrademarkItem> TrademarkItems { get; private set; }
        }

        public static Task<OrdersData> InitOrdersData(string dbFileContents, int itemCount, int dateInterval) {
            return Task.Factory.StartNew(() => {
                var models = InitMDBDataCore(dbFileContents, out var ds, out var trademarks, 1);
                return new OrdersData(ds, trademarks, models, itemCount, dateInterval);
            });
        }

        static List<Model> InitMDBDataCore(string dbFileContents, out DataSet ds, out List<Trademark> listTrademarks, int dataInterval) {
            const string model = "Model";
            const string trademark = "Trademark";
            ds = new DataSet();
            ds.ReadXml(new StringReader(dbFileContents));
            listTrademarks = new List<Trademark>();
            foreach(DataRow row in ds.Tables[trademark].Rows)
                listTrademarks.Add(new Trademark {
                    ID = (int)row["ID"],
                    Name = (string)row["Name"],
                });

            var listModels = new List<Model>();
            var rnd = NonCryptographicRandom.Default;
            foreach(DataRow row in ds.Tables[model].Rows)
                listModels.Add(new Model() {
                    ID = (int)row["ID"],
                    Name = (string)row["Name"],
                    Trademark = (int)row["TrademarkID"],
                    Modification = (string)row["Modification"],
                    Category = (int)row["CategoryID"],
                    Price = (decimal)row["Price"],
                    MPGCity = DBNull.Value.Equals(row["MPG City"]) ? null : (int?)row["MPG City"],
                    MPGHighway = DBNull.Value.Equals(row["MPG City"]) ? null : (int?)row["MPG Highway"],
                    Doors = (int)row["Doors"],
                    BodyStyle = (int)row["BodyStyleID"],
                    Cylinders = (int)row["Cylinders"],
                    Horsepower = (string)row["Horsepower"],
                    Torque = (string)row["Torque"],
                    TransmissionSpeeds = Convert.ToInt32(row["Transmission Speeds"]),
                    TransmissionType = (int)row["Transmission Type"],
                    Description = $"{row["Description"]}",
                    DeliveryDate = DateTime.Now.AddDays(rnd.Next(dataInterval)),
                    InStock = rnd.Next(100) < 95,
                    Trademarks = listTrademarks
                });
            return listModels;
        }
    }
}
