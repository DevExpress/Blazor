using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    public class HistogramDataProvider : IHistogramDataProvider {
        const int HistogramPointCount = 1000;
        const int DistributionPointCount = 11;
        const double Mean = 0.5;
        const double StdDev = 0.15;
        const double Max = 10;
        Random random = new Random(1);
        List<DataPoint> normalDistribution;
        List<DataPoint> generatedData;

        IEnumerable<DataPoint> GenerateNormalDistribution() {
            if(normalDistribution == null) {
                normalDistribution = new List<DataPoint>();
                for(int i = 0; i < DistributionPointCount; i++) {
                    double x = i * (Max + 1) / DistributionPointCount;
                    normalDistribution.Add(new DataPoint(x, GetNormalDistributionValue(x, Mean * Max, StdDev * Max)));
                }
            }
            return normalDistribution;
        }
        IEnumerable<DataPoint> GenerateRandomData() {
            if(generatedData == null) {
                generatedData = new List<DataPoint>();
                for(int x = 0; x < HistogramPointCount; x++) {
                    double point = GenerateRandomPoint(Mean * Max, StdDev * Max);
                    generatedData.Add(new DataPoint(point, point));
                }
            }
            return generatedData;
        }
        double GetNormalDistributionValue(double x, double mean, double stdDev) {
            double tmp = 1 / (Math.Sqrt(2 * Math.PI) * stdDev);
            return Math.Exp(-Math.Pow(x - mean, 2) / (2 * Math.Pow(stdDev, 2))) * tmp;
        }
        double GenerateRandomPoint(double mean, double stdDev) {
            return Math.Sqrt(-2 * Math.Log(random.NextDouble())) * Math.Cos(2 * Math.PI * random.NextDouble()) * stdDev + mean;
        }
        public Task<IEnumerable<DataPoint>> GetNormalDistribution() {
            return Task.Run(GenerateNormalDistribution);
        }
        public Task<IEnumerable<DataPoint>> GenerateData() {
            return Task.Run(GenerateRandomData);
        }
    }
}
