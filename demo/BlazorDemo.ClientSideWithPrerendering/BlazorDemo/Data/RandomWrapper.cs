using System;

namespace BlazorDemo.Data {
    public static class RandomWrapperFactory {
#if VISUALTESTS
        public static IRandomWrapper Create() => new StaticRandomWrapper();
        public static IRandomWrapper Create(int seed) => new StaticRandomWrapper(seed);
#else
        public static IRandomWrapper Create() => new RandomWrapper();
        public static IRandomWrapper Create(int seed) => new RandomWrapper(seed);
#endif
    }

    public class RandomWrapper : IRandomWrapper {
        readonly Random random;

        public RandomWrapper() {
            random = new Random();
        }
        public RandomWrapper(int seed) {
            random = new Random(seed);
        }

        public int Next(int maxValue) => random.Next(maxValue);
        public int Next(int minValue, int maxValue) => random.Next(minValue, maxValue);
        public double NextDouble() => random.NextDouble();
    }

    public class StaticRandomWrapper : IRandomWrapper {
        readonly double[] values = new double[] {
            0.00,  0.20,  0.10,  0.40,  0.30,  0.60,  0.50,  0.80,  0.70,  0.90,
            0.02,  0.22,  0.12,  0.42,  0.32,  0.62,  0.52,  0.82,  0.72,  0.92,
            0.01,  0.21,  0.11,  0.41,  0.31,  0.61,  0.51,  0.81,  0.71,  0.91,
            0.04,  0.24,  0.14,  0.44,  0.34,  0.64,  0.54,  0.84,  0.74,  0.94,
            0.03,  0.23,  0.13,  0.43,  0.33,  0.63,  0.53,  0.83,  0.73,  0.93,
            0.06,  0.26,  0.16,  0.46,  0.36,  0.66,  0.56,  0.86,  0.76,  0.96,
            0.05,  0.25,  0.15,  0.45,  0.35,  0.65,  0.55,  0.85,  0.75,  0.95,
            0.08,  0.28,  0.18,  0.48,  0.38,  0.68,  0.58,  0.88,  0.78,  0.98,
            0.07,  0.27,  0.17,  0.47,  0.37,  0.67,  0.57,  0.87,  0.77,  0.97,
            0.09,  0.29,  0.19,  0.49,  0.39,  0.69,  0.59,  0.89,  0.79,  0.99
        };
        int index = 0;

        public StaticRandomWrapper() { }
        public StaticRandomWrapper(int seed) { }

        public int Next(int maxValue) => Next(0, maxValue);
        public int Next(int minValue, int maxValue) {
            var range = maxValue - minValue - 1;
            return minValue + (int)Math.Floor(range * NextDouble());
        }
        public double NextDouble() {
            if(index >= values.Length)
                index = 0;
            return values[index++];
        }
    }
}
