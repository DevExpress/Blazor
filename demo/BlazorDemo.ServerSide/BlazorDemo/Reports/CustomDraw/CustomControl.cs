using System;
using System.Linq;
using DevExpress.XtraReports.UI;
using System.Drawing;
using DevExpress.XtraPrinting;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Sql.DataApi;
using System.Collections.Generic;
using System.Drawing.Printing;

namespace BlazorDemo.Reports.CustomDraw {
    public class CustomControl : XRControl {
        List<Tuple<string, double>> controlData = new List<Tuple<string, double>>();

        void UpdateData() {
            controlData.Clear();
            if(DesignMode) {
                controlData.Add(Tuple.Create("", 1.0));
                return;
            }

            if(RootReport == null) return;
            SqlDataSource dataSource = RootReport.DataSource as SqlDataSource;
            if(dataSource == null) return;
            ITable regions = dataSource.Result["AboutRegions"];
            if(regions == null) return;

            int count = Math.Min(regions.Count(), 10);
            for(int i = 0; i < count; i++) {
                IRow region = regions[i];
                double population = (double)region["PopulationPortion"];
                string country = string.Format("{0}, {1:p}", region["Country"], population);
                controlData.Add(Tuple.Create(country, population));
            }
        }
        protected override VisualBrick CreateBrick(VisualBrick[] childrenBricks) {
            return new PanelBrick(this);
        }
        bool? isCompatible = null;
        protected override void PutStateToBrick(VisualBrick brick, PrintingSystemBase ps) {
            base.PutStateToBrick(brick, ps);
            UpdateData();
            if(!isCompatible.HasValue)
                isCompatible = CheckCompatibility();
            if(controlData.Count == 0 || !isCompatible.Value) return;
            float itemHeight = GetItemHeight(brick.Rect);
            RectangleF r = GetGraphicsRect(brick.Rect, itemHeight);
            double scale = GetScale();
            for (int i = 0; i < controlData.Count; i++) {
                DrawPopulationInfo((PanelBrick)brick, r, controlData[i].Item1, controlData[i].Item2, scale);
                r.Offset(0, itemHeight);
            }
        }
        static bool CheckCompatibility() {
            try {
                object ignore = typeof(RectangleF);
            } catch {
                return false;
            }
            return true;
        }
        float GetItemHeight(RectangleF bounds) {
            return bounds.Height / Math.Max(controlData.Count, 10);
        }
        double GetScale() {
            double value = controlData.Count > 0 ? controlData[0].Item2 : 1;
            return 1 / value;
        }
        static RectangleF GetGraphicsRect(RectangleF bounds, float itemHeight) {
            const int indent = 10;
            RectangleF r = new RectangleF(0, 0, bounds.Width, itemHeight);
            r.Inflate(-2 * indent, -2 * indent);
            return r;
        }
        static void DrawPopulationInfo(PanelBrick panel, RectangleF r, string text, double portion, double scale) {
            RectangleF barRect = GetBarRect(r, portion, scale);
            r.Height = barRect.Top - r.Top;

           BrickStyle textStyle = new BrickStyle() {
                ForeColor = panel.Style.ForeColor,
                BackColor = Color.Transparent,
                Font = panel.Style.Font
            };
            textStyle.ChangeAlignment(TextAlignment.BottomLeft);
            TextBrick textBrick = new TextBrick(textStyle);
            textBrick.Rect = r;
            textBrick.Text = text;
            panel.Bricks.Add(textBrick);

            BrickStyle barStyle = new BrickStyle() {
                Sides = BorderSide.All,
                BorderColor = Color.FromArgb(173, 148, 116),
                BorderStyle = BrickBorderStyle.Inset,
                BorderWidth = 1,
                BackColor = Color.FromArgb(232, 216, 195),
            };
            VisualBrick barBrick = new VisualBrick(barStyle);
            barBrick.Rect = barRect;
            panel.Bricks.Add(barBrick);
        }
        static RectangleF GetBarRect(RectangleF r, double portion, double scale) {
            float barWidth = (float)(r.Width * portion * scale);
            float barHeight = (float)((double)r.Height / 3.0);
            return new RectangleF(r.Left, r.Bottom - barHeight, barWidth, barHeight);
        }
    }
}
