using System.ComponentModel.DataAnnotations;
using System;

namespace BlazorDemo.Data {
    public partial class VehiclesData {
        public class TrademarkItem {
            public TrademarkItem(int id) {
                ID = id;
            }

            public int ID { get; set; }
            public int TrademarkID { get; set; }
            public string Name { get; set; }
            public DateTime? SalesDate { get; set; }
            public double? Discount { get; set; }
            [DataType(DataType.Currency)]
            public decimal? ModelPrice { get; set; }
            public int Trademark { get; set; }
            public string TrademarkName { get; set; }
            public string Modification { get; set; }
            public int Category { get; set; }
            public int? MPGCity { get; set; }
            public int? MPGHighway { get; set; }
            public int Doors { get; set; }
            [EnumDataType(typeof(BodyStyle))]
            public int? BodyStyle { get; set; }
            public int? Cylinders { get; set; }
            public string Horsepower { get; set; }
            public string Torque { get; set; }
            public int TransmissionSpeeds { get; set; }
            public int TransmissionType { get; set; }

            internal Model Model { get; set; }
        }
    }
}
