using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface ICarouselImageDataProvider {
        public List<CarouselImageData> GetData();
    }
}
