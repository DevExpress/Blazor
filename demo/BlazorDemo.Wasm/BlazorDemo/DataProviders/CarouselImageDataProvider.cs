using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    public class CarouselImageDataProvider : ICarouselImageDataProvider {
        public List<CarouselImageData> GetData() {
            List<CarouselImageData> result = new List<CarouselImageData>();
            result.Add(new CarouselImageData(StaticAssetUtils.GetImagePath("homes/1.jpg"), "image 1"));
            result.Add(new CarouselImageData(StaticAssetUtils.GetImagePath("homes/2.jpg"), "image 2"));
            result.Add(new CarouselImageData(StaticAssetUtils.GetImagePath("homes/3.jpg"), "image 3"));
            result.Add(new CarouselImageData(StaticAssetUtils.GetImagePath("homes/4.jpg"), "image 4"));
            result.Add(new CarouselImageData(StaticAssetUtils.GetImagePath("homes/5.jpg"), "image 5"));
            result.Add(new CarouselImageData(StaticAssetUtils.GetImagePath("homes/6.jpg"), "image 6"));
            result.Add(new CarouselImageData(StaticAssetUtils.GetImagePath("homes/7.jpg"), "image 7"));
            result.Add(new CarouselImageData(StaticAssetUtils.GetImagePath("homes/8.jpg"), "image 8"));
            result.Add(new CarouselImageData(StaticAssetUtils.GetImagePath("homes/9.jpg"), "image 9"));

            return result;
        }
    }
}
