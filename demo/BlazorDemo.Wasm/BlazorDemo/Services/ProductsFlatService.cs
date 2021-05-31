using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    public partial class ProductsFlatService {
        private readonly IProductsFlatProvider _provider;
        private readonly IProductCategoriesProvider _categoriesProvider;

        public ProductsFlatService(IProductsFlatProvider provider, IProductCategoriesProvider categoriesProvider) {
            _provider = provider;
            _categoriesProvider = categoriesProvider;
        }
    }
}
