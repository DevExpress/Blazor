namespace BlazorDemo.Data {
    public class CarouselImageData {
        public string Src { get; set; }
        public string Alt { get; set; }

        public CarouselImageData(string src, string alt) {
            Src = src;
            Alt = alt;
        }
    }
}
