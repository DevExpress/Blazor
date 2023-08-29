using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;
using DevExpress.Data.Utils;

namespace BlazorDemo.DataProviders.Implementation {
    public class ScatterRandomDataProvider : IScatterRandomDataProvider {
        public Task<IEnumerable<DataPoint>> GenerateCluster(int xPlus, int xMinus, int yPlus, int yMinus, int count, int randomSeek) {
            NonCryptographicRandom random = new NonCryptographicRandom(randomSeek);
            List<DataPoint> points = new();
            int deltaX = xMinus - xPlus;
            int deltaY = yMinus - yPlus;
            int centerX = xMinus / 2 + xPlus / 2;
            int centerY = yMinus / 2 + yPlus / 2;
            for(int i = 0; i < count; i++) {
                int half = i / 2 + 1;
                double ratio = Math.Max(2.1, (double)count / half);
                int xOffset = (int)(deltaX / ratio);
                int yOffset = (int)(deltaY / ratio);
                int delta = xMinus - xOffset - centerX;
                int rx, ry;
                do {
                    rx = random.Next(xPlus + xOffset, xMinus - xOffset);
                    ry = random.Next(yPlus + yOffset, yMinus - yOffset);
                }
                while(delta * delta < Math.Pow((centerX - rx), 2) + Math.Pow((centerY - ry), 2));
                points.Add(new DataPoint(rx, ry));
            }
            return Task.FromResult((IEnumerable<DataPoint>)points);
        }
    }
}
