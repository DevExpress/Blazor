namespace BlazorDemo.Data {
    public interface IRandomWrapper {
        int Next(int maxValue);
        int Next(int minValue, int maxValue);
        double NextDouble();
    }
}