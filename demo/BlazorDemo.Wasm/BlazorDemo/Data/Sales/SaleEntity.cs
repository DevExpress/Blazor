namespace BlazorDemo.Data.Sales {
    public class SaleEntity {
        OrderEntity _order;
        ProductEntity _product;
        int _quantity;
        decimal _unitPrice;
        public SaleEntity(OrderEntity order, ProductEntity product, int quantity, decimal unitPrice) {
            Order = order;
            Product = product;
            Quantity = quantity;
            UnitPrice = unitPrice;
            order.Sales.Add(this);
            product.Sales.Add(this);
        }
        public OrderEntity Order {
            get { return _order; }
            set { _order = value; }
        }
        public ProductEntity Product {
            get { return _product; }
            set { _product = value; }
        }
        public int Quantity {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public decimal UnitPrice {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }
    }
}
