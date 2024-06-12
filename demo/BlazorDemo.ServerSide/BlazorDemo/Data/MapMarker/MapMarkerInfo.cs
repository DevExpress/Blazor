using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Data.MapMarker {
    public class MapMarkerInfo {

        public string Text { get; set; }

        public string GeoPosition { get; set; }

        public MapMarkerInfo() { }

        public MapMarkerInfo(string text, double latitude, double longitude) {
            GeoPosition = GetGeoPositionFrommCoords(latitude, longitude);
            Text = text;
        }

        public MapMarkerInfo(MapMarkerInfo markerInfo) {
            Assign(markerInfo);
        }

        public void Assign(MapMarkerInfo markerInfo) {
            Text = markerInfo.Text;
            GeoPosition = markerInfo.GeoPosition;
        }

        public static string GetGeoPositionFrommCoords(double latitude, double longitude) {
            return latitude.ToString("0.####") + ", " + longitude.ToString("0.####");
        }
    }
}
