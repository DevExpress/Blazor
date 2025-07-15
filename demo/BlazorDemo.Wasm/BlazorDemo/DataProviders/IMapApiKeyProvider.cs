namespace BlazorDemo.DataProviders {
    public interface IMapApiKeyProvider {
        public string GetBingProviderKey();
        public string GetAzureProviderKey();
    }
}
