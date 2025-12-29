using System.ComponentModel;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IOrderDataProvider {
        public BindingList<OrderData> GetData(int count);
    }
}
