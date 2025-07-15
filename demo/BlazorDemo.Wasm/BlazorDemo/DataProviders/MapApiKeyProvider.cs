using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    public class MapApiKeyProvider : IMapApiKeyProvider {
        public string GetBingProviderKey() => "AhuxC0dQ1DBTNo8L-H9ToVMQStmizZzBJdraTSgCzDSWPsA1Qd8uIvFSflzxdaLH";
        public string GetAzureProviderKey() => "3nG4PFmJoIk4YOARjQCx9Fdl5l4uK7LVCKiO2b8rkkPvSNtnrbHpJQQJ99AIACYeBjFllM6LAAAgAZMPkYmg";
    }
}
