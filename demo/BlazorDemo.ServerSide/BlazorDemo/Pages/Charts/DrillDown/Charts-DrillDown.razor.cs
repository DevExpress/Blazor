using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BlazorDemo.Data;
using DevExpress.Blazor;

namespace BlazorDemo.Pages.Charts.DrillDown {
    public partial class Charts_DrillDown {
        List<SaleItem> data;
        DrillDownState currentState;
        List<DrillDownState> StateList = new List<DrillDownState>();
        string preName;
        Dictionary<string, Color> mainPalette = new() {
            { "Cameras", Color.FromArgb(255, 253, 204, 109) },
            { "Cell Phones", Color.FromArgb(255, 246, 153, 73) },
            { "Computers", Color.FromArgb(255, 233, 71, 84) },
            { "TV, Audio", Color.FromArgb(255, 148, 11, 63) },
            { "Vehicle Electronics", Color.FromArgb(255, 101, 22, 52) },
            { "Multipurpose Batteries", Color.FromArgb(255, 20, 54, 85) },

            { "Tripod", Color.FromArgb(255, 253, 224, 109) },
            { "Flash", Color.FromArgb(255, 253, 153, 109) },
            { "Camera", Color.FromArgb(255, 253, 206, 109) },
            { "Binoculars", Color.FromArgb(255, 253, 171, 109) },
            { "Camcorder", Color.FromArgb(255, 253, 189, 109) },

            { "Mobile Phone", Color.FromArgb(255, 251, 213, 110) },
            { "Smart Watch", Color.FromArgb(255, 246, 153, 73) },
            { "Smartphone", Color.FromArgb(255, 242, 110, 44) },
            { "Sim Card", Color.FromArgb(255, 249, 185, 90) },

            { "Laptop", Color.FromArgb(255, 245, 111, 106) },
            { "Tablet", Color.FromArgb(255, 217, 50, 73) },
            { "Desktop", Color.FromArgb(255, 233, 71, 84) },
            { "Printer", Color.FromArgb(255, 191, 32, 64) },

            { "Home Audio", Color.FromArgb(255, 221, 74, 102) },
            { "Headphone", Color.FromArgb(255, 165, 25, 80) },
            { "Television", Color.FromArgb(255, 201, 53, 93) },
            { "DVD Player", Color.FromArgb(255, 136, 9, 63) },

            { "Radar", Color.FromArgb(255, 199, 57, 88) },
            { "Car Alarm", Color.FromArgb(255, 143, 33, 69) },
            { "GPS Unit", Color.FromArgb(255, 101, 22, 58) },
            { "Car Accessories", Color.FromArgb(255, 178, 46, 83) },

            { "AC/DC Adapter", Color.FromArgb(255, 49, 150, 172) },
            { "Tester", Color.FromArgb(255, 31, 100, 125) },
            { "Battery", Color.FromArgb(255, 20, 54, 85) },
            { "Converter", Color.FromArgb(255, 39, 124, 148) },
            { "Charger", Color.FromArgb(255, 24, 75, 100) },
        };

        protected override void OnInitialized() {
            data = dataProvider.Generate();
            currentState = new DrillDownState("Total Sales",
                                              data,
                                              si => si.Category,
                                              si => si.Company,
                                              true,
                                              ChartAxisZoomAndPanMode.None,
                                              ChartSeriesType.StackedBar,
                                              ChartAxisDataType.String);
            StateList.Add(currentState);
        }

        void OnSeriesClick(ChartSeriesClickEventArgs e) {
            IEnumerable<SaleItem> newData;
            string name;
            if(e.Point != null) {
                var pointData = (IEnumerable<SaleItem>)e.Point.DataItems;
                var list = pointData.ToList();
                list.Sort(); //to make aggregation work correctly
                newData = list;
                name = $"{e.Series.Name} ({e.Point.Argument})";
            } else {
                name = e.Series.Name;
                if(name == preName)
                    return;
                newData = (IEnumerable<SaleItem>)e.Series.Data;
            }

            currentState = new DrillDownState(name,
                                             newData,
                                             si => si.Product,
                                             si => si.OrderDate.Date,
                                             false,
                                             ChartAxisZoomAndPanMode.Both,
                                             ChartSeriesType.StackedArea,
                                             ChartAxisDataType.DateTime);
            StateList.Add(currentState);
            preName = name;
        }

        void OnBreadcrumbItemClick(DrillDownState state) {
            currentState = state;
            while(StateList.Last() != currentState)
                StateList.Remove(StateList.Last());
            preName = state.Name;
        }
    }


    class DrillDownState {
        public string Name { get; }
        public IEnumerable<SaleItem> Data { get; }
        public Expression<Func<SaleItem, string>> GetSeriesExpression { get; }
        public Expression<Func<SaleItem, object>> GetArgumentExpression { get; }
        public ChartAxisZoomAndPanMode ZoomAndPanMode { get; }
        public bool Rotated { get; }
        public ChartSeriesType SeriesType { get; }
        public ChartAxisDataType AxisDataType { get; }

        public DrillDownState(string name,
                     IEnumerable<SaleItem> data,
                     Expression<Func<SaleItem, string>> getSeriesExpression,
                     Expression<Func<SaleItem, object>> getArgumentExpression,
                     bool rotated,
                     ChartAxisZoomAndPanMode zoomAndPanMode,
                     ChartSeriesType seriesType,
                      ChartAxisDataType axisDataType) {
            (Name, Data, GetSeriesExpression, GetArgumentExpression, Rotated, ZoomAndPanMode, SeriesType, AxisDataType) =
            (name, data, getSeriesExpression, getArgumentExpression, rotated, zoomAndPanMode, seriesType, axisDataType);
        }
    }
}
