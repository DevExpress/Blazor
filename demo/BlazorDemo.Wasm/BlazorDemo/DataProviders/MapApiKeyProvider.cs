using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    public class MapApiKeyProvider : IMapApiKeyProvider {
        public string GetBingProviderKey() => "AhuxC0dQ1DBTNo8L-H9ToVMQStmizZzBJdraTSgCzDSWPsA1Qd8uIvFSflzxdaLH";
        public string GetAzureProviderKey() => "5cIe6STcXC7Arbbl7B7W4wZVOeLHGhE2HBiA9DTBDQG9Bxm7TpmYJQQJ99BEACYeBjFllM6LAAAgAZMPdufc";
    }
}
