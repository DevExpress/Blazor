using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.Wasm.Server.DataProviders;

namespace BlazorDemo.DataProviders.Implementation {
    public class UsdJpyDataProvider : ICurrencyExchangeDataProvider {
        List<DatePricePoint> cachedList = null;
        readonly IUsdJpyCsvFileContentProvider fileContentProvider;

        public UsdJpyDataProvider(IUsdJpyCsvFileContentProvider fileContentProvider) {
            this.fileContentProvider = fileContentProvider;
        }

        public async Task<IEnumerable<DatePricePoint>> GetDataAsync() {
            if(cachedList == null) {
                string fileContent = await fileContentProvider.GetFileContentAsync();
                cachedList = CurrencyExchangeCsvParser.Parse(fileContent);
            }
            return cachedList;
        }
    }
}
