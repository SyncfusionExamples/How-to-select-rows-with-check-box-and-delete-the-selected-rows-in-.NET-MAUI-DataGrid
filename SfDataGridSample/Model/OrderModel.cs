using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridSample
{
    public class OrderModel
    {
        private string? orderID;
        private string? customerID;
        private string? customer;
        private string? shipCity;
        private string? shipCountry;
        private bool isChecked;

        public string? OrderID
        {
            get { return orderID; }
            set
            {
                if (orderID != value)
                {
                    orderID = value;
                    OnPropertyChanged();
                }
            }
        }

        public string? CustomerID
        {
            get { return customerID; }
            set
            {
                if (customerID != value)
                {
                    customerID = value;
                    OnPropertyChanged();
                }
            }
        }

        public string? ShipCountry
        {
            get { return shipCountry; }
            set
            {
                if (shipCountry != value)
                {
                    shipCountry = value;
                    OnPropertyChanged();
                }
            }
        }

        public string? Customer
        {
            get { return customer; }
            set
            {
                if (customer != value)
                {
                    customer = value;
                    OnPropertyChanged();
                }
            }
        }

        public string? ShipCity
        {
            get { return shipCity; }
            set
            {
                if (shipCity != value)
                {
                    shipCity = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsChecked
        {
            get { return isChecked; }
            set
            {
                if (isChecked != value)
                {
                    isChecked = value;
                    OnPropertyChanged();
                }
            }
        }

        public OrderModel(string orderId, string customerId, string country, string customer, string shipCity, bool isChecked)
        {
            this.OrderID = orderId;
            this.CustomerID = customerId;
            this.Customer = customer;
            this.ShipCountry = country;
            this.ShipCity = shipCity;
            this.IsChecked = isChecked;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null!)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
