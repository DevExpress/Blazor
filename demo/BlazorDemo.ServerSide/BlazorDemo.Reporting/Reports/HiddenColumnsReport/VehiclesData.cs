using BlazorDemo.Reporting;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Blazor.Reports.HiddenColumnsReport
{
    public class VehiclesData
    {
        class Trademark
        {
            public string Name { get; set; }
            public int ID { get; set; }
        }
        public class Vehicle
        {
            public int ID { get; set; }
            public int Trademark { get; set; }
            public string Name { get; set; }
            public string Modification { get; set; }
            [DisplayName("MPG @ City")]
            public int? MPGCity { get; set; }
            [DisplayName("MPG @ Highway")]
            public int? MPGHighway { get; set; }
            public int Doors { get; set; }
            public int Cylinders { get; set; }
            public string Horsepower { get; set; }
            public string Torque { get; set; }
            [DisplayName("Transmission Speeds")]
            public int TransmissionSpeeds { get; set; }
            [DisplayName("Transmission Type")]
            public int TransmissionType { get; set; }
            public string Description { get; set; }
            public Image Photo { get; set; }
            [DisplayName("Trademark Name")]
            public string TrademarkName { get; set; }
        }

        string ConnectionString { get; set; }

        public VehiclesData(string connectionString) {
            ConnectionString = connectionString;
        }

        public List<Vehicle> GetVehicles() {
            return InitMDBData(ConnectionString);
        }
        static List<Vehicle> InitMDBData(string connectionString)
        {
            string Model = "Model";
            string Trademark = "Trademark";

            DataSet ds = new DataSet();
            FillTable(Model, connectionString, ds);
            FillTable(Trademark, connectionString, ds);

            List<Trademark> listTrademarks = new List<Trademark>();
            foreach (DataRow row in ds.Tables[Trademark].Rows)
                listTrademarks.Add(new Trademark()
                {
                    ID = (int)(long)row["ID"],
                    Name = (string)row["Name"],
                });

            var listModels = new List<Vehicle>();
            foreach (DataRow row in ds.Tables[Model].Rows)
                listModels.Add(new Vehicle()
                {
                    ID = (int)(long)row["ID"],
                    Name = (string)row["Name"],
                    Trademark = (int)(long)row["TrademarkID"],
                    Modification = (string)row["Modification"],
                    MPGCity = System.DBNull.Value.Equals(row["MPG City"]) ? null : (int?)(long)row["MPG City"],
                    MPGHighway = System.DBNull.Value.Equals(row["MPG City"]) ? null : (int?)(long)row["MPG Highway"],
                    Doors = (int)(long)row["Doors"],
                    Cylinders = (int)(long)row["Cylinders"],
                    Horsepower = (string)row["Horsepower"],
                    Torque = (string)row["Torque"],
                    TransmissionSpeeds = Convert.ToInt32(row["Transmission Speeds"]),
                    TransmissionType = (int)(long)row["Transmission Type"],
                    Description = string.Format("{0}", row["Description"]),
                    Photo = ByteImageConverter.FromByteArray((byte[])row["Photo"]),
                    TrademarkName = GetTrademarkName(ds.Tables[Trademark], (int)(long)row["TrademarkID"])
                });
            return listModels;
        }
        static string GetTrademarkName(DataTable dataTable, int tradeMarkId)
        {
            List<DataRow> listTrademarks = new List<DataRow>();
            foreach(DataRow row in dataTable.Rows) {
                if((int)(long)row["ID"] == tradeMarkId)
                    listTrademarks.Add(row);
            }
            DataRow trademarkRow = listTrademarks.FirstOrDefault();
            return trademarkRow["Name"].ToString();            
        }
        static void FillTable(string table, string connectionString, DataSet ds)
        {
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(string.Format("SELECT * FROM {0}", table), connectionString);
            dataAdapter.Fill(ds, table);
        }
    }
}
