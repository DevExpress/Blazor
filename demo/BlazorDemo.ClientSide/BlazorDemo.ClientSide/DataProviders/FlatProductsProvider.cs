using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    class FlatProductsProvider : DataProviderBase, IFlatProductsProvider {
        readonly IProductCategoriesProvider _productCategoriesProvider;
        readonly SemaphoreSlim _lock = new SemaphoreSlim(1);
        DataWrapper<ProductFlat> wrapper;

        public FlatProductsProvider(IProductCategoriesProvider productCategoriesProvider) {
            _productCategoriesProvider = productCategoriesProvider;
        }

        public async Task<IEnumerable<ProductFlat>> LoadAsync(CancellationToken ct = default) {
            await _lock.WaitAsync();
            if (wrapper == null) {
                var categories = await _productCategoriesProvider.GetProductCategoriesAsync(ct);
                IEnumerable<ProductFlat> _productFlats = LoadInternal(categories);
                wrapper = new DataWrapper<ProductFlat>(_productFlats.ToList(), UpdateItem);
            }

            _lock.Release();
            return wrapper.Data;
        }
        public Task Add(ProductFlat product) {
            return wrapper.Add(product);
        }

        public Task Remove(ProductFlat item) {
            return wrapper.Remove(item);
        }

        static void UpdateItem(ProductFlat item, string name, object value) {
            switch (name) {
                case "Id":
                    item.Id = (string)value; return;
                case "ProductName":
                    item.ProductName = (string)value; return;
                case "Availability":
                    item.Availability = (bool)value; return;
                case "ProductCategoryId":
                    item.ProductCategoryId = (int)value; return;
                case "Category":
                    if (item.CategoryItem == null) item.CategoryItem = new ProductCategory();
                    item.CategoryItem.Category = value is ProductCategoryMain ? (ProductCategoryMain)value: Enum.Parse<ProductCategoryMain>((string)value);
                    return;
                case "Subcategory":
                    if (item.CategoryItem == null) item.CategoryItem = new ProductCategory();
                    item.CategoryItem.Subcategory = (string)value; return;
            }
        }

        static IEnumerable<ProductFlat> WithCategoryItemSet(IEnumerable<ProductCategory> categories, params ProductFlat[] products) {
            foreach (var product in products) {
                product.CategoryItem = categories.FirstOrDefault(x => product.ProductCategoryId == x.SubcategoryID);
            }
            return products;
        }

        static IEnumerable<ProductFlat> LoadInternal(IEnumerable<ProductCategory> categories) {
            return WithCategoryItemSet(categories, 
                new ProductFlat() {
                    Id = "680", Availability = false, ProductCategoryId = 14, ProductName = "HL Road Frame - Black, 58"
                },
                new ProductFlat()
                    {Id = "706", Availability = true, ProductCategoryId = 14, ProductName = "HL Road Frame - Red, 58"},
                new ProductFlat()
                    {Id = "707", Availability = false, ProductCategoryId = 31, ProductName = "Sport-100 Helmet, Red"},
                new ProductFlat()
                    {Id = "708", Availability = true, ProductCategoryId = 31, ProductName = "Sport-100 Helmet, Black"},
                new ProductFlat()
                    {Id = "709", Availability = false, ProductCategoryId = 23, ProductName = "Mountain Bike Socks, M"},
                new ProductFlat()
                    {Id = "710", Availability = true, ProductCategoryId = 23, ProductName = "Mountain Bike Socks, L"},
                new ProductFlat()
                    {Id = "711", Availability = false, ProductCategoryId = 31, ProductName = "Sport-100 Helmet, Blue"},
                new ProductFlat()
                    {Id = "712", Availability = true, ProductCategoryId = 19, ProductName = "AWC Logo Cap"},
                new ProductFlat() {
                    Id = "713", Availability = false, ProductCategoryId = 21, ProductName = "Long-Sleeve Logo Jersey, S"
                },
                new ProductFlat() {
                    Id = "714", Availability = true, ProductCategoryId = 21, ProductName = "Long-Sleeve Logo Jersey, M"
                },
                new ProductFlat() {
                    Id = "715", Availability = false, ProductCategoryId = 21, ProductName = "Long-Sleeve Logo Jersey, L"
                },
                new ProductFlat() {
                    Id = "716", Availability = true, ProductCategoryId = 21, ProductName = "Long-Sleeve Logo Jersey, XL"
                },
                new ProductFlat()
                    {Id = "717", Availability = false, ProductCategoryId = 14, ProductName = "HL Road Frame - Red, 62"},
                new ProductFlat()
                    {Id = "718", Availability = true, ProductCategoryId = 14, ProductName = "HL Road Frame - Red, 44"},
                new ProductFlat()
                    {Id = "719", Availability = false, ProductCategoryId = 14, ProductName = "HL Road Frame - Red, 48"},
                new ProductFlat()
                    {Id = "720", Availability = true, ProductCategoryId = 14, ProductName = "HL Road Frame - Red, 52"},
                new ProductFlat()
                    {Id = "721", Availability = false, ProductCategoryId = 14, ProductName = "HL Road Frame - Red, 56"},
                new ProductFlat() {
                    Id = "722", Availability = true, ProductCategoryId = 14, ProductName = "LL Road Frame - Black, 58"
                },
                new ProductFlat() {
                    Id = "723", Availability = false, ProductCategoryId = 14, ProductName = "LL Road Frame - Black, 60"
                },
                new ProductFlat() {
                    Id = "724", Availability = true, ProductCategoryId = 14, ProductName = "LL Road Frame - Black, 62"
                },
                new ProductFlat()
                    {Id = "725", Availability = false, ProductCategoryId = 14, ProductName = "LL Road Frame - Red, 44"},
                new ProductFlat()
                    {Id = "726", Availability = true, ProductCategoryId = 14, ProductName = "LL Road Frame - Red, 48"},
                new ProductFlat()
                    {Id = "727", Availability = false, ProductCategoryId = 14, ProductName = "LL Road Frame - Red, 52"},
                new ProductFlat()
                    {Id = "728", Availability = true, ProductCategoryId = 14, ProductName = "LL Road Frame - Red, 58"},
                new ProductFlat()
                    {Id = "729", Availability = false, ProductCategoryId = 14, ProductName = "LL Road Frame - Red, 60"},
                new ProductFlat()
                    {Id = "730", Availability = true, ProductCategoryId = 14, ProductName = "LL Road Frame - Red, 62"},
                new ProductFlat()
                    {Id = "731", Availability = false, ProductCategoryId = 14, ProductName = "ML Road Frame - Red, 44"},
                new ProductFlat()
                    {Id = "732", Availability = true, ProductCategoryId = 14, ProductName = "ML Road Frame - Red, 48"},
                new ProductFlat()
                    {Id = "733", Availability = false, ProductCategoryId = 14, ProductName = "ML Road Frame - Red, 52"},
                new ProductFlat()
                    {Id = "734", Availability = true, ProductCategoryId = 14, ProductName = "ML Road Frame - Red, 58"},
                new ProductFlat()
                    {Id = "735", Availability = false, ProductCategoryId = 14, ProductName = "ML Road Frame - Red, 60"},
                new ProductFlat() {
                    Id = "736", Availability = true, ProductCategoryId = 14, ProductName = "LL Road Frame - Black, 44"
                },
                new ProductFlat() {
                    Id = "737", Availability = false, ProductCategoryId = 14, ProductName = "LL Road Frame - Black, 48"
                },
                new ProductFlat() {
                    Id = "738", Availability = true, ProductCategoryId = 14, ProductName = "LL Road Frame - Black, 52"
                },
                new ProductFlat() {
                    Id = "739", Availability = false, ProductCategoryId = 12,
                    ProductName = "HL Mountain Frame - Silver, 42"
                },
                new ProductFlat() {
                    Id = "740", Availability = true, ProductCategoryId = 12,
                    ProductName = "HL Mountain Frame - Silver, 44"
                },
                new ProductFlat() {
                    Id = "741", Availability = false, ProductCategoryId = 12,
                    ProductName = "HL Mountain Frame - Silver, 48"
                },
                new ProductFlat() {
                    Id = "742", Availability = true, ProductCategoryId = 12,
                    ProductName = "HL Mountain Frame - Silver, 46"
                },
                new ProductFlat() {
                    Id = "743", Availability = false, ProductCategoryId = 12,
                    ProductName = "HL Mountain Frame - Black, 42"
                },
                new ProductFlat() {
                    Id = "744", Availability = true, ProductCategoryId = 12,
                    ProductName = "HL Mountain Frame - Black, 44"
                },
                new ProductFlat() {
                    Id = "745", Availability = false, ProductCategoryId = 12,
                    ProductName = "HL Mountain Frame - Black, 48"
                },
                new ProductFlat() {
                    Id = "746", Availability = true, ProductCategoryId = 12,
                    ProductName = "HL Mountain Frame - Black, 46"
                },
                new ProductFlat() {
                    Id = "747", Availability = false, ProductCategoryId = 12,
                    ProductName = "HL Mountain Frame - Black, 38"
                },
                new ProductFlat() {
                    Id = "748", Availability = true, ProductCategoryId = 12,
                    ProductName = "HL Mountain Frame - Silver, 38"
                },
                new ProductFlat()
                    {Id = "749", Availability = false, ProductCategoryId = 2, ProductName = "Road-150 Red, 62"},
                new ProductFlat()
                    {Id = "750", Availability = true, ProductCategoryId = 2, ProductName = "Road-150 Red, 44"},
                new ProductFlat()
                    {Id = "751", Availability = false, ProductCategoryId = 2, ProductName = "Road-150 Red, 48"},
                new ProductFlat()
                    {Id = "752", Availability = true, ProductCategoryId = 2, ProductName = "Road-150 Red, 52"},
                new ProductFlat()
                    {Id = "753", Availability = false, ProductCategoryId = 2, ProductName = "Road-150 Red, 56"},
                new ProductFlat()
                    {Id = "754", Availability = true, ProductCategoryId = 2, ProductName = "Road-450 Red, 58"},
                new ProductFlat()
                    {Id = "755", Availability = false, ProductCategoryId = 2, ProductName = "Road-450 Red, 60"},
                new ProductFlat()
                    {Id = "756", Availability = true, ProductCategoryId = 2, ProductName = "Road-450 Red, 44"},
                new ProductFlat()
                    {Id = "757", Availability = false, ProductCategoryId = 2, ProductName = "Road-450 Red, 48"},
                new ProductFlat()
                    {Id = "758", Availability = true, ProductCategoryId = 2, ProductName = "Road-450 Red, 52"},
                new ProductFlat()
                    {Id = "759", Availability = false, ProductCategoryId = 2, ProductName = "Road-650 Red, 58"},
                new ProductFlat()
                    {Id = "760", Availability = true, ProductCategoryId = 2, ProductName = "Road-650 Red, 60"},
                new ProductFlat()
                    {Id = "761", Availability = false, ProductCategoryId = 2, ProductName = "Road-650 Red, 62"},
                new ProductFlat()
                    {Id = "762", Availability = true, ProductCategoryId = 2, ProductName = "Road-650 Red, 44"},
                new ProductFlat()
                    {Id = "763", Availability = false, ProductCategoryId = 2, ProductName = "Road-650 Red, 48"},
                new ProductFlat()
                    {Id = "764", Availability = true, ProductCategoryId = 2, ProductName = "Road-650 Red, 52"},
                new ProductFlat()
                    {Id = "765", Availability = false, ProductCategoryId = 2, ProductName = "Road-650 Black, 58"},
                new ProductFlat()
                    {Id = "766", Availability = true, ProductCategoryId = 2, ProductName = "Road-650 Black, 60"},
                new ProductFlat()
                    {Id = "767", Availability = false, ProductCategoryId = 2, ProductName = "Road-650 Black, 62"},
                new ProductFlat()
                    {Id = "768", Availability = true, ProductCategoryId = 2, ProductName = "Road-650 Black, 44"},
                new ProductFlat()
                    {Id = "769", Availability = false, ProductCategoryId = 2, ProductName = "Road-650 Black, 48"},
                new ProductFlat()
                    {Id = "770", Availability = true, ProductCategoryId = 2, ProductName = "Road-650 Black, 52"},
                new ProductFlat()
                    {Id = "771", Availability = false, ProductCategoryId = 1, ProductName = "Mountain-100 Silver, 38"},
                new ProductFlat()
                    {Id = "772", Availability = true, ProductCategoryId = 1, ProductName = "Mountain-100 Silver, 42"},
                new ProductFlat()
                    {Id = "773", Availability = false, ProductCategoryId = 1, ProductName = "Mountain-100 Silver, 44"},
                new ProductFlat()
                    {Id = "774", Availability = true, ProductCategoryId = 1, ProductName = "Mountain-100 Silver, 48"},
                new ProductFlat()
                    {Id = "775", Availability = false, ProductCategoryId = 1, ProductName = "Mountain-100 Black, 38"},
                new ProductFlat()
                    {Id = "776", Availability = true, ProductCategoryId = 1, ProductName = "Mountain-100 Black, 42"},
                new ProductFlat()
                    {Id = "777", Availability = false, ProductCategoryId = 1, ProductName = "Mountain-100 Black, 44"},
                new ProductFlat()
                    {Id = "778", Availability = true, ProductCategoryId = 1, ProductName = "Mountain-100 Black, 48"},
                new ProductFlat()
                    {Id = "779", Availability = false, ProductCategoryId = 1, ProductName = "Mountain-200 Silver, 38"},
                new ProductFlat()
                    {Id = "780", Availability = true, ProductCategoryId = 1, ProductName = "Mountain-200 Silver, 42"},
                new ProductFlat()
                    {Id = "781", Availability = false, ProductCategoryId = 1, ProductName = "Mountain-200 Silver, 46"},
                new ProductFlat()
                    {Id = "782", Availability = true, ProductCategoryId = 1, ProductName = "Mountain-200 Black, 38"},
                new ProductFlat()
                    {Id = "783", Availability = false, ProductCategoryId = 1, ProductName = "Mountain-200 Black, 42"},
                new ProductFlat()
                    {Id = "784", Availability = true, ProductCategoryId = 1, ProductName = "Mountain-200 Black, 46"},
                new ProductFlat()
                    {Id = "785", Availability = false, ProductCategoryId = 1, ProductName = "Mountain-300 Black, 38"},
                new ProductFlat()
                    {Id = "786", Availability = true, ProductCategoryId = 1, ProductName = "Mountain-300 Black, 40"},
                new ProductFlat()
                    {Id = "787", Availability = false, ProductCategoryId = 1, ProductName = "Mountain-300 Black, 44"},
                new ProductFlat()
                    {Id = "788", Availability = true, ProductCategoryId = 1, ProductName = "Mountain-300 Black, 48"},
                new ProductFlat()
                    {Id = "789", Availability = false, ProductCategoryId = 2, ProductName = "Road-250 Red, 44"},
                new ProductFlat()
                    {Id = "790", Availability = true, ProductCategoryId = 2, ProductName = "Road-250 Red, 48"},
                new ProductFlat()
                    {Id = "791", Availability = false, ProductCategoryId = 2, ProductName = "Road-250 Red, 52"},
                new ProductFlat()
                    {Id = "792", Availability = true, ProductCategoryId = 2, ProductName = "Road-250 Red, 58"},
                new ProductFlat()
                    {Id = "793", Availability = false, ProductCategoryId = 2, ProductName = "Road-250 Black, 44"},
                new ProductFlat()
                    {Id = "794", Availability = true, ProductCategoryId = 2, ProductName = "Road-250 Black, 48"},
                new ProductFlat()
                    {Id = "795", Availability = false, ProductCategoryId = 2, ProductName = "Road-250 Black, 52"},
                new ProductFlat()
                    {Id = "796", Availability = true, ProductCategoryId = 2, ProductName = "Road-250 Black, 58"},
                new ProductFlat()
                    {Id = "797", Availability = false, ProductCategoryId = 2, ProductName = "Road-550-W Yellow, 38"},
                new ProductFlat()
                    {Id = "798", Availability = true, ProductCategoryId = 2, ProductName = "Road-550-W Yellow, 40"},
                new ProductFlat()
                    {Id = "799", Availability = false, ProductCategoryId = 2, ProductName = "Road-550-W Yellow, 42"},
                new ProductFlat()
                    {Id = "800", Availability = true, ProductCategoryId = 2, ProductName = "Road-550-W Yellow, 44"},
                new ProductFlat()
                    {Id = "801", Availability = false, ProductCategoryId = 2, ProductName = "Road-550-W Yellow, 48"},
                new ProductFlat() {Id = "802", Availability = true, ProductCategoryId = 10, ProductName = "LL Fork"},
                new ProductFlat() {Id = "803", Availability = false, ProductCategoryId = 10, ProductName = "ML Fork"},
                new ProductFlat() {Id = "804", Availability = true, ProductCategoryId = 10, ProductName = "HL Fork"},
                new ProductFlat()
                    {Id = "805", Availability = false, ProductCategoryId = 11, ProductName = "LL Headset"},
                new ProductFlat() {Id = "806", Availability = true, ProductCategoryId = 11, ProductName = "ML Headset"},
                new ProductFlat()
                    {Id = "807", Availability = false, ProductCategoryId = 11, ProductName = "HL Headset"},
                new ProductFlat()
                    {Id = "808", Availability = true, ProductCategoryId = 4, ProductName = "LL Mountain Handlebars"},
                new ProductFlat()
                    {Id = "809", Availability = false, ProductCategoryId = 4, ProductName = "ML Mountain Handlebars"},
                new ProductFlat()
                    {Id = "810", Availability = true, ProductCategoryId = 4, ProductName = "HL Mountain Handlebars"},
                new ProductFlat()
                    {Id = "811", Availability = false, ProductCategoryId = 4, ProductName = "LL Road Handlebars"},
                new ProductFlat()
                    {Id = "812", Availability = true, ProductCategoryId = 4, ProductName = "ML Road Handlebars"},
                new ProductFlat()
                    {Id = "813", Availability = false, ProductCategoryId = 4, ProductName = "HL Road Handlebars"},
                new ProductFlat() {
                    Id = "814", Availability = true, ProductCategoryId = 12,
                    ProductName = "ML Mountain Frame - Black, 38"
                },
                new ProductFlat()
                    {Id = "815", Availability = false, ProductCategoryId = 17, ProductName = "LL Mountain Front Wheel"},
                new ProductFlat()
                    {Id = "816", Availability = true, ProductCategoryId = 17, ProductName = "ML Mountain Front Wheel"},
                new ProductFlat()
                    {Id = "817", Availability = false, ProductCategoryId = 17, ProductName = "HL Mountain Front Wheel"},
                new ProductFlat()
                    {Id = "818", Availability = true, ProductCategoryId = 17, ProductName = "LL Road Front Wheel"},
                new ProductFlat()
                    {Id = "819", Availability = false, ProductCategoryId = 17, ProductName = "ML Road Front Wheel"},
                new ProductFlat()
                    {Id = "820", Availability = true, ProductCategoryId = 17, ProductName = "HL Road Front Wheel"},
                new ProductFlat()
                    {Id = "821", Availability = false, ProductCategoryId = 17, ProductName = "Touring Front Wheel"},
                new ProductFlat() {
                    Id = "822", Availability = true, ProductCategoryId = 14,
                    ProductName = "ML Road Frame-W - Yellow, 38"
                },
                new ProductFlat()
                    {Id = "823", Availability = false, ProductCategoryId = 17, ProductName = "LL Mountain Rear Wheel"},
                new ProductFlat()
                    {Id = "824", Availability = true, ProductCategoryId = 17, ProductName = "ML Mountain Rear Wheel"},
                new ProductFlat()
                    {Id = "825", Availability = false, ProductCategoryId = 17, ProductName = "HL Mountain Rear Wheel"},
                new ProductFlat()
                    {Id = "826", Availability = true, ProductCategoryId = 17, ProductName = "LL Road Rear Wheel"},
                new ProductFlat()
                    {Id = "827", Availability = false, ProductCategoryId = 17, ProductName = "ML Road Rear Wheel"},
                new ProductFlat()
                    {Id = "828", Availability = true, ProductCategoryId = 17, ProductName = "HL Road Rear Wheel"},
                new ProductFlat()
                    {Id = "829", Availability = false, ProductCategoryId = 17, ProductName = "Touring Rear Wheel"},
                new ProductFlat() {
                    Id = "830", Availability = true, ProductCategoryId = 12,
                    ProductName = "ML Mountain Frame - Black, 40"
                },
                new ProductFlat() {
                    Id = "831", Availability = false, ProductCategoryId = 12,
                    ProductName = "ML Mountain Frame - Black, 44"
                },
                new ProductFlat() {
                    Id = "832", Availability = true, ProductCategoryId = 12,
                    ProductName = "ML Mountain Frame - Black, 48"
                },
                new ProductFlat() {
                    Id = "833", Availability = false, ProductCategoryId = 14,
                    ProductName = "ML Road Frame-W - Yellow, 40"
                },
                new ProductFlat() {
                    Id = "834", Availability = true, ProductCategoryId = 14,
                    ProductName = "ML Road Frame-W - Yellow, 42"
                },
                new ProductFlat() {
                    Id = "835", Availability = false, ProductCategoryId = 14,
                    ProductName = "ML Road Frame-W - Yellow, 44"
                },
                new ProductFlat() {
                    Id = "836", Availability = true, ProductCategoryId = 14,
                    ProductName = "ML Road Frame-W - Yellow, 48"
                },
                new ProductFlat() {
                    Id = "837", Availability = false, ProductCategoryId = 14, ProductName = "HL Road Frame - Black, 62"
                },
                new ProductFlat() {
                    Id = "838", Availability = true, ProductCategoryId = 14, ProductName = "HL Road Frame - Black, 44"
                },
                new ProductFlat() {
                    Id = "839", Availability = false, ProductCategoryId = 14, ProductName = "HL Road Frame - Black, 48"
                },
                new ProductFlat() {
                    Id = "840", Availability = true, ProductCategoryId = 14, ProductName = "HL Road Frame - Black, 52"
                },
                new ProductFlat()
                    {Id = "841", Availability = false, ProductCategoryId = 22, ProductName = "Men's Sports Shorts, S"},
                new ProductFlat()
                    {Id = "842", Availability = true, ProductCategoryId = 35, ProductName = "Touring-Panniers, Large"},
                new ProductFlat()
                    {Id = "843", Availability = false, ProductCategoryId = 34, ProductName = "Cable Lock"},
                new ProductFlat() {Id = "844", Availability = true, ProductCategoryId = 36, ProductName = "Minipump"},
                new ProductFlat()
                    {Id = "845", Availability = false, ProductCategoryId = 36, ProductName = "Mountain Pump"},
                new ProductFlat() {
                    Id = "846", Availability = true, ProductCategoryId = 33,
                    ProductName = "Taillights - Battery-Powered"
                },
                new ProductFlat()
                    {Id = "847", Availability = false, ProductCategoryId = 33, ProductName = "Headlights - Dual-Beam"},
                new ProductFlat() {
                    Id = "848", Availability = true, ProductCategoryId = 33, ProductName = "Headlights - Weatherproof"
                },
                new ProductFlat()
                    {Id = "849", Availability = false, ProductCategoryId = 22, ProductName = "Men's Sports Shorts, M"},
                new ProductFlat()
                    {Id = "850", Availability = true, ProductCategoryId = 22, ProductName = "Men's Sports Shorts, L"},
                new ProductFlat()
                    {Id = "851", Availability = false, ProductCategoryId = 22, ProductName = "Men's Sports Shorts, XL"},
                new ProductFlat()
                    {Id = "852", Availability = true, ProductCategoryId = 24, ProductName = "Women's Tights, S"},
                new ProductFlat()
                    {Id = "853", Availability = false, ProductCategoryId = 24, ProductName = "Women's Tights, M"},
                new ProductFlat()
                    {Id = "854", Availability = true, ProductCategoryId = 24, ProductName = "Women's Tights, L"},
                new ProductFlat()
                    {Id = "855", Availability = false, ProductCategoryId = 18, ProductName = "Men's Bib-Shorts, S"},
                new ProductFlat()
                    {Id = "856", Availability = true, ProductCategoryId = 18, ProductName = "Men's Bib-Shorts, M"},
                new ProductFlat()
                    {Id = "857", Availability = false, ProductCategoryId = 18, ProductName = "Men's Bib-Shorts, L"},
                new ProductFlat()
                    {Id = "858", Availability = true, ProductCategoryId = 20, ProductName = "Half-Finger Gloves, S"},
                new ProductFlat()
                    {Id = "859", Availability = false, ProductCategoryId = 20, ProductName = "Half-Finger Gloves, M"},
                new ProductFlat()
                    {Id = "860", Availability = true, ProductCategoryId = 20, ProductName = "Half-Finger Gloves, L"},
                new ProductFlat()
                    {Id = "861", Availability = false, ProductCategoryId = 20, ProductName = "Full-Finger Gloves, S"},
                new ProductFlat()
                    {Id = "862", Availability = true, ProductCategoryId = 20, ProductName = "Full-Finger Gloves, M"},
                new ProductFlat()
                    {Id = "863", Availability = false, ProductCategoryId = 20, ProductName = "Full-Finger Gloves, L"},
                new ProductFlat()
                    {Id = "864", Availability = true, ProductCategoryId = 25, ProductName = "Classic Vest, S"},
                new ProductFlat()
                    {Id = "865", Availability = false, ProductCategoryId = 25, ProductName = "Classic Vest, M"},
                new ProductFlat()
                    {Id = "866", Availability = true, ProductCategoryId = 25, ProductName = "Classic Vest, L"},
                new ProductFlat() {
                    Id = "867", Availability = false, ProductCategoryId = 22, ProductName = "Women's Mountain Shorts, S"
                },
                new ProductFlat() {
                    Id = "868", Availability = true, ProductCategoryId = 22, ProductName = "Women's Mountain Shorts, M"
                },
                new ProductFlat() {
                    Id = "869", Availability = false, ProductCategoryId = 22, ProductName = "Women's Mountain Shorts, L"
                },
                new ProductFlat()
                    {Id = "870", Availability = true, ProductCategoryId = 28, ProductName = "Water Bottle - 30 oz."},
                new ProductFlat()
                    {Id = "871", Availability = false, ProductCategoryId = 28, ProductName = "Mountain Bottle Cage"},
                new ProductFlat()
                    {Id = "872", Availability = true, ProductCategoryId = 28, ProductName = "Road Bottle Cage"},
                new ProductFlat()
                    {Id = "873", Availability = false, ProductCategoryId = 37, ProductName = "Patch Kit/8 Patches"},
                new ProductFlat()
                    {Id = "874", Availability = true, ProductCategoryId = 23, ProductName = "Racing Socks, M"},
                new ProductFlat()
                    {Id = "875", Availability = false, ProductCategoryId = 23, ProductName = "Racing Socks, L"},
                new ProductFlat()
                    {Id = "876", Availability = true, ProductCategoryId = 26, ProductName = "Hitch Rack - 4-Bike"},
                new ProductFlat()
                    {Id = "877", Availability = false, ProductCategoryId = 29, ProductName = "Bike Wash - Dissolver"},
                new ProductFlat()
                    {Id = "878", Availability = true, ProductCategoryId = 30, ProductName = "Fender Set - Mountain"},
                new ProductFlat()
                    {Id = "879", Availability = false, ProductCategoryId = 27, ProductName = "All-Purpose Bike Stand"},
                new ProductFlat()
                    {Id = "880", Availability = true, ProductCategoryId = 32, ProductName = "Hydration Pack - 70 oz."},
                new ProductFlat() {
                    Id = "881", Availability = false, ProductCategoryId = 21,
                    ProductName = "Short-Sleeve Classic Jersey, S"
                },
                new ProductFlat() {
                    Id = "882", Availability = true, ProductCategoryId = 21,
                    ProductName = "Short-Sleeve Classic Jersey, M"
                },
                new ProductFlat() {
                    Id = "883", Availability = false, ProductCategoryId = 21,
                    ProductName = "Short-Sleeve Classic Jersey, L"
                },
                new ProductFlat() {
                    Id = "884", Availability = true, ProductCategoryId = 21,
                    ProductName = "Short-Sleeve Classic Jersey, XL"
                },
                new ProductFlat() {
                    Id = "885", Availability = false, ProductCategoryId = 16,
                    ProductName = "HL Touring Frame - Yellow, 60"
                },
                new ProductFlat() {
                    Id = "886", Availability = true, ProductCategoryId = 16,
                    ProductName = "LL Touring Frame - Yellow, 62"
                },
                new ProductFlat() {
                    Id = "887", Availability = false, ProductCategoryId = 16,
                    ProductName = "HL Touring Frame - Yellow, 46"
                },
                new ProductFlat() {
                    Id = "888", Availability = true, ProductCategoryId = 16,
                    ProductName = "HL Touring Frame - Yellow, 50"
                },
                new ProductFlat() {
                    Id = "889", Availability = false, ProductCategoryId = 16,
                    ProductName = "HL Touring Frame - Yellow, 54"
                },
                new ProductFlat() {
                    Id = "890", Availability = true, ProductCategoryId = 16, ProductName = "HL Touring Frame - Blue, 46"
                },
                new ProductFlat() {
                    Id = "891", Availability = false, ProductCategoryId = 16,
                    ProductName = "HL Touring Frame - Blue, 50"
                },
                new ProductFlat() {
                    Id = "892", Availability = true, ProductCategoryId = 16, ProductName = "HL Touring Frame - Blue, 54"
                },
                new ProductFlat() {
                    Id = "893", Availability = false, ProductCategoryId = 16,
                    ProductName = "HL Touring Frame - Blue, 60"
                },
                new ProductFlat()
                    {Id = "894", Availability = true, ProductCategoryId = 9, ProductName = "Rear Derailleur"},
                new ProductFlat() {
                    Id = "895", Availability = false, ProductCategoryId = 16,
                    ProductName = "LL Touring Frame - Blue, 50"
                },
                new ProductFlat() {
                    Id = "896", Availability = true, ProductCategoryId = 16, ProductName = "LL Touring Frame - Blue, 54"
                },
                new ProductFlat() {
                    Id = "897", Availability = false, ProductCategoryId = 16,
                    ProductName = "LL Touring Frame - Blue, 58"
                },
                new ProductFlat() {
                    Id = "898", Availability = true, ProductCategoryId = 16, ProductName = "LL Touring Frame - Blue, 62"
                },
                new ProductFlat() {
                    Id = "899", Availability = false, ProductCategoryId = 16,
                    ProductName = "LL Touring Frame - Yellow, 44"
                },
                new ProductFlat() {
                    Id = "900", Availability = true, ProductCategoryId = 16,
                    ProductName = "LL Touring Frame - Yellow, 50"
                },
                new ProductFlat() {
                    Id = "901", Availability = false, ProductCategoryId = 16,
                    ProductName = "LL Touring Frame - Yellow, 54"
                },
                new ProductFlat() {
                    Id = "902", Availability = true, ProductCategoryId = 16,
                    ProductName = "LL Touring Frame - Yellow, 58"
                },
                new ProductFlat() {
                    Id = "903", Availability = false, ProductCategoryId = 16,
                    ProductName = "LL Touring Frame - Blue, 44"
                },
                new ProductFlat() {
                    Id = "904", Availability = true, ProductCategoryId = 12,
                    ProductName = "ML Mountain Frame-W - Silver, 40"
                },
                new ProductFlat() {
                    Id = "905", Availability = false, ProductCategoryId = 12,
                    ProductName = "ML Mountain Frame-W - Silver, 42"
                },
                new ProductFlat() {
                    Id = "906", Availability = true, ProductCategoryId = 12,
                    ProductName = "ML Mountain Frame-W - Silver, 46"
                },
                new ProductFlat()
                    {Id = "907", Availability = false, ProductCategoryId = 6, ProductName = "Rear Brakes"},
                new ProductFlat()
                    {Id = "908", Availability = true, ProductCategoryId = 15, ProductName = "LL Mountain Seat/Saddle"},
                new ProductFlat()
                    {Id = "909", Availability = false, ProductCategoryId = 15, ProductName = "ML Mountain Seat/Saddle"},
                new ProductFlat()
                    {Id = "910", Availability = true, ProductCategoryId = 15, ProductName = "HL Mountain Seat/Saddle"},
                new ProductFlat()
                    {Id = "911", Availability = false, ProductCategoryId = 15, ProductName = "LL Road Seat/Saddle"},
                new ProductFlat()
                    {Id = "912", Availability = true, ProductCategoryId = 15, ProductName = "ML Road Seat/Saddle"},
                new ProductFlat()
                    {Id = "913", Availability = false, ProductCategoryId = 15, ProductName = "HL Road Seat/Saddle"},
                new ProductFlat()
                    {Id = "914", Availability = true, ProductCategoryId = 15, ProductName = "LL Touring Seat/Saddle"},
                new ProductFlat()
                    {Id = "915", Availability = false, ProductCategoryId = 15, ProductName = "ML Touring Seat/Saddle"},
                new ProductFlat()
                    {Id = "916", Availability = true, ProductCategoryId = 15, ProductName = "HL Touring Seat/Saddle"},
                new ProductFlat() {
                    Id = "917", Availability = false, ProductCategoryId = 12,
                    ProductName = "LL Mountain Frame - Silver, 42"
                },
                new ProductFlat() {
                    Id = "918", Availability = true, ProductCategoryId = 12,
                    ProductName = "LL Mountain Frame - Silver, 44"
                },
                new ProductFlat() {
                    Id = "919", Availability = false, ProductCategoryId = 12,
                    ProductName = "LL Mountain Frame - Silver, 48"
                },
                new ProductFlat() {
                    Id = "920", Availability = true, ProductCategoryId = 12,
                    ProductName = "LL Mountain Frame - Silver, 52"
                },
                new ProductFlat()
                    {Id = "921", Availability = false, ProductCategoryId = 37, ProductName = "Mountain Tire Tube"},
                new ProductFlat()
                    {Id = "922", Availability = true, ProductCategoryId = 37, ProductName = "Road Tire Tube"},
                new ProductFlat()
                    {Id = "923", Availability = false, ProductCategoryId = 37, ProductName = "Touring Tire Tube"},
                new ProductFlat() {
                    Id = "924", Availability = true, ProductCategoryId = 12,
                    ProductName = "LL Mountain Frame - Black, 42"
                },
                new ProductFlat() {
                    Id = "925", Availability = false, ProductCategoryId = 12,
                    ProductName = "LL Mountain Frame - Black, 44"
                },
                new ProductFlat() {
                    Id = "926", Availability = true, ProductCategoryId = 12,
                    ProductName = "LL Mountain Frame - Black, 48"
                },
                new ProductFlat() {
                    Id = "927", Availability = false, ProductCategoryId = 12,
                    ProductName = "LL Mountain Frame - Black, 52"
                },
                new ProductFlat()
                    {Id = "928", Availability = true, ProductCategoryId = 37, ProductName = "LL Mountain Tire"},
                new ProductFlat()
                    {Id = "929", Availability = false, ProductCategoryId = 37, ProductName = "ML Mountain Tire"},
                new ProductFlat()
                    {Id = "930", Availability = true, ProductCategoryId = 37, ProductName = "HL Mountain Tire"},
                new ProductFlat()
                    {Id = "931", Availability = false, ProductCategoryId = 37, ProductName = "LL Road Tire"},
                new ProductFlat()
                    {Id = "932", Availability = true, ProductCategoryId = 37, ProductName = "ML Road Tire"},
                new ProductFlat()
                    {Id = "933", Availability = false, ProductCategoryId = 37, ProductName = "HL Road Tire"},
                new ProductFlat()
                    {Id = "934", Availability = true, ProductCategoryId = 37, ProductName = "Touring Tire"},
                new ProductFlat()
                    {Id = "935", Availability = false, ProductCategoryId = 13, ProductName = "LL Mountain Pedal"},
                new ProductFlat()
                    {Id = "936", Availability = true, ProductCategoryId = 13, ProductName = "ML Mountain Pedal"},
                new ProductFlat()
                    {Id = "937", Availability = false, ProductCategoryId = 13, ProductName = "HL Mountain Pedal"},
                new ProductFlat()
                    {Id = "938", Availability = true, ProductCategoryId = 13, ProductName = "LL Road Pedal"},
                new ProductFlat()
                    {Id = "939", Availability = false, ProductCategoryId = 13, ProductName = "ML Road Pedal"},
                new ProductFlat()
                    {Id = "940", Availability = true, ProductCategoryId = 13, ProductName = "HL Road Pedal"},
                new ProductFlat()
                    {Id = "941", Availability = false, ProductCategoryId = 13, ProductName = "Touring Pedal"},
                new ProductFlat() {
                    Id = "942", Availability = true, ProductCategoryId = 12,
                    ProductName = "ML Mountain Frame-W - Silver, 38"
                },
                new ProductFlat() {
                    Id = "943", Availability = false, ProductCategoryId = 12,
                    ProductName = "LL Mountain Frame - Black, 40"
                },
                new ProductFlat() {
                    Id = "944", Availability = true, ProductCategoryId = 12,
                    ProductName = "LL Mountain Frame - Silver, 40"
                },
                new ProductFlat()
                    {Id = "945", Availability = false, ProductCategoryId = 9, ProductName = "Front Derailleur"},
                new ProductFlat()
                    {Id = "946", Availability = true, ProductCategoryId = 4, ProductName = "LL Touring Handlebars"},
                new ProductFlat()
                    {Id = "947", Availability = false, ProductCategoryId = 4, ProductName = "HL Touring Handlebars"},
                new ProductFlat()
                    {Id = "948", Availability = true, ProductCategoryId = 6, ProductName = "Front Brakes"},
                new ProductFlat()
                    {Id = "949", Availability = false, ProductCategoryId = 8, ProductName = "LL Crankset"},
                new ProductFlat() {Id = "950", Availability = true, ProductCategoryId = 8, ProductName = "ML Crankset"},
                new ProductFlat()
                    {Id = "951", Availability = false, ProductCategoryId = 8, ProductName = "HL Crankset"},
                new ProductFlat() {Id = "952", Availability = true, ProductCategoryId = 7, ProductName = "Chain"},
                new ProductFlat()
                    {Id = "953", Availability = false, ProductCategoryId = 3, ProductName = "Touring-2000 Blue, 60"},
                new ProductFlat()
                    {Id = "954", Availability = true, ProductCategoryId = 3, ProductName = "Touring-1000 Yellow, 46"},
                new ProductFlat()
                    {Id = "955", Availability = false, ProductCategoryId = 3, ProductName = "Touring-1000 Yellow, 50"},
                new ProductFlat()
                    {Id = "956", Availability = true, ProductCategoryId = 3, ProductName = "Touring-1000 Yellow, 54"},
                new ProductFlat()
                    {Id = "957", Availability = false, ProductCategoryId = 3, ProductName = "Touring-1000 Yellow, 60"},
                new ProductFlat()
                    {Id = "958", Availability = true, ProductCategoryId = 3, ProductName = "Touring-3000 Blue, 54"},
                new ProductFlat()
                    {Id = "959", Availability = false, ProductCategoryId = 3, ProductName = "Touring-3000 Blue, 58"},
                new ProductFlat()
                    {Id = "960", Availability = true, ProductCategoryId = 3, ProductName = "Touring-3000 Blue, 62"},
                new ProductFlat()
                    {Id = "961", Availability = false, ProductCategoryId = 3, ProductName = "Touring-3000 Yellow, 44"},
                new ProductFlat()
                    {Id = "962", Availability = true, ProductCategoryId = 3, ProductName = "Touring-3000 Yellow, 50"},
                new ProductFlat()
                    {Id = "963", Availability = false, ProductCategoryId = 3, ProductName = "Touring-3000 Yellow, 54"},
                new ProductFlat()
                    {Id = "964", Availability = true, ProductCategoryId = 3, ProductName = "Touring-3000 Yellow, 58"},
                new ProductFlat()
                    {Id = "965", Availability = false, ProductCategoryId = 3, ProductName = "Touring-3000 Yellow, 62"},
                new ProductFlat()
                    {Id = "966", Availability = true, ProductCategoryId = 3, ProductName = "Touring-1000 Blue, 46"},
                new ProductFlat()
                    {Id = "967", Availability = false, ProductCategoryId = 3, ProductName = "Touring-1000 Blue, 50"},
                new ProductFlat()
                    {Id = "968", Availability = true, ProductCategoryId = 3, ProductName = "Touring-1000 Blue, 54"},
                new ProductFlat()
                    {Id = "969", Availability = false, ProductCategoryId = 3, ProductName = "Touring-1000 Blue, 60"},
                new ProductFlat()
                    {Id = "970", Availability = true, ProductCategoryId = 3, ProductName = "Touring-2000 Blue, 46"},
                new ProductFlat()
                    {Id = "971", Availability = false, ProductCategoryId = 3, ProductName = "Touring-2000 Blue, 50"},
                new ProductFlat()
                    {Id = "972", Availability = true, ProductCategoryId = 3, ProductName = "Touring-2000 Blue, 54"},
                new ProductFlat()
                    {Id = "973", Availability = false, ProductCategoryId = 2, ProductName = "Road-350-W Yellow, 40"},
                new ProductFlat()
                    {Id = "974", Availability = true, ProductCategoryId = 2, ProductName = "Road-350-W Yellow, 42"},
                new ProductFlat()
                    {Id = "975", Availability = false, ProductCategoryId = 2, ProductName = "Road-350-W Yellow, 44"},
                new ProductFlat()
                    {Id = "976", Availability = true, ProductCategoryId = 2, ProductName = "Road-350-W Yellow, 48"},
                new ProductFlat()
                    {Id = "977", Availability = false, ProductCategoryId = 2, ProductName = "Road-750 Black, 58"},
                new ProductFlat()
                    {Id = "978", Availability = true, ProductCategoryId = 3, ProductName = "Touring-3000 Blue, 44"},
                new ProductFlat()
                    {Id = "979", Availability = false, ProductCategoryId = 3, ProductName = "Touring-3000 Blue, 50"},
                new ProductFlat()
                    {Id = "980", Availability = true, ProductCategoryId = 1, ProductName = "Mountain-400-W Silver, 38"},
                new ProductFlat() {
                    Id = "981", Availability = false, ProductCategoryId = 1, ProductName = "Mountain-400-W Silver, 40"
                },
                new ProductFlat()
                    {Id = "982", Availability = true, ProductCategoryId = 1, ProductName = "Mountain-400-W Silver, 42"},
                new ProductFlat() {
                    Id = "983", Availability = false, ProductCategoryId = 1, ProductName = "Mountain-400-W Silver, 46"
                },
                new ProductFlat()
                    {Id = "984", Availability = true, ProductCategoryId = 1, ProductName = "Mountain-500 Silver, 40"},
                new ProductFlat()
                    {Id = "985", Availability = false, ProductCategoryId = 1, ProductName = "Mountain-500 Silver, 42"},
                new ProductFlat()
                    {Id = "986", Availability = true, ProductCategoryId = 1, ProductName = "Mountain-500 Silver, 44"},
                new ProductFlat()
                    {Id = "987", Availability = false, ProductCategoryId = 1, ProductName = "Mountain-500 Silver, 48"},
                new ProductFlat()
                    {Id = "988", Availability = true, ProductCategoryId = 1, ProductName = "Mountain-500 Silver, 52"},
                new ProductFlat()
                    {Id = "989", Availability = false, ProductCategoryId = 1, ProductName = "Mountain-500 Black, 40"},
                new ProductFlat()
                    {Id = "990", Availability = true, ProductCategoryId = 1, ProductName = "Mountain-500 Black, 42"},
                new ProductFlat()
                    {Id = "991", Availability = false, ProductCategoryId = 1, ProductName = "Mountain-500 Black, 44"},
                new ProductFlat()
                    {Id = "992", Availability = true, ProductCategoryId = 1, ProductName = "Mountain-500 Black, 48"},
                new ProductFlat()
                    {Id = "993", Availability = false, ProductCategoryId = 1, ProductName = "Mountain-500 Black, 52"},
                new ProductFlat()
                    {Id = "994", Availability = true, ProductCategoryId = 5, ProductName = "LL Bottom Bracket"},
                new ProductFlat()
                    {Id = "995", Availability = false, ProductCategoryId = 5, ProductName = "ML Bottom Bracket"},
                new ProductFlat()
                    {Id = "996", Availability = true, ProductCategoryId = 5, ProductName = "HL Bottom Bracket"},
                new ProductFlat()
                    {Id = "997", Availability = false, ProductCategoryId = 2, ProductName = "Road-750 Black, 44"},
                new ProductFlat()
                    {Id = "998", Availability = true, ProductCategoryId = 2, ProductName = "Road-750 Black, 48"},
                new ProductFlat()
                    {Id = "999", Availability = false, ProductCategoryId = 2, ProductName = "Road-750 Black, 52"}
            );
        }
    }
}