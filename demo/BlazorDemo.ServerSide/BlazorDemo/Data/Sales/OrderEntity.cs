using BlazorDemo.DataProviders;
using System.Collections.Generic;
using System;

namespace BlazorDemo.Data.Sales {
    public class OrderEntity {
        SalesPersonEntity _salesPerson;
        CustomerEntity _customer;
        DateTime _date;
        public OrderEntity(SalesPersonEntity salesPerson, CustomerEntity customer, DateTime date) {
            SalesPerson = salesPerson;
            Customer = customer;
            Date = date;
            salesPerson.Orders.Add(this);
            customer.Orders.Add(this);
        }
        public SalesPersonEntity SalesPerson {
            get { return _salesPerson; }
            set { _salesPerson = value; }
        }
        public CustomerEntity Customer {
            get { return _customer; }
            set { _customer = value; }
        }
        public List<SaleEntity> Sales { get; } = new List<SaleEntity>();
        public DateTime Date {
            get { return _date; }
            set { _date = value; }
        }
    }
}
