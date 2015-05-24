using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Customer
{
    class Payment : ICloneable
    {
        private string productName;
        private double price;

        public Payment(string productName, double price)
        {
            this.ProductName = productName;
            this.Price = price;
        }
        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The product name can not be empty! ");
                }
                this.productName = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.price = value;
            }
        }
        public override bool Equals(object param)
        {
            Payment payment = param as Payment;
            if (payment == null)
            {
                return false;
            }
            if (!Object.Equals(this.ProductName, payment.ProductName))
            {
                return false;
            }
            if (this.Price != payment.Price)
            {
                return false;
            }
            return true;
        }
        public override int GetHashCode()
        {
            return ProductName.GetHashCode() ^ Price.GetHashCode();
        }
        public override string ToString()
        {
            return string.Format("\nProduct name: {0} ,Price: {1}", this.productName, this.price);
        }
        public static bool operator ==(Payment payment1, Payment payment2)
        {
            return Payment.Equals(payment1, payment2);
        }

        public static bool operator !=(Payment payment1, Payment payment2)
        {
            return !(Payment.Equals(payment1, payment2));
        }

        object ICloneable.Clone() 
        {
            return this.Clone();
        }
        public Payment Clone()
        {
            string newProductName = this.productName;
            double newPrice = this.price;

            Payment payment = new Payment(newProductName, newPrice);
            return payment;
        }
    }
}
