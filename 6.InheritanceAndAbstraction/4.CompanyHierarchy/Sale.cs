using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Sale
    {
        private string productName;
        private DateTime date;
        private double price;

        public Sale(string productName, DateTime date, double price)
        {
            this.ProductName = productName;
            this.Date = date;
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
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid product name!");
                }
                this.productName = value;
            }
        }

        public DateTime Date 
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
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
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.price = value;
            }
        }

        public void toString()
        {
            Console.WriteLine("Product name: {0},\nDate: {1},\nPrice: {2}",this.productName, this.date, this.price);
        }
    }
}
