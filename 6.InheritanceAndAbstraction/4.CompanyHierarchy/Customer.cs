using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Customer : Person, ICustomer
    {
        private double netPurchaseAmount;

        public Customer(int id, string firstName, string lastName, double netPurchaseAmount) : base(id, firstName, lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public double NetPurchaseAmount
        {
            get
            {
                return this.netPurchaseAmount;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.netPurchaseAmount = value;
            }
        }

        public override void toString()
        {
            base.toString();
            Console.WriteLine("Net purchase amount: {0}", this.netPurchaseAmount);
        }
    }
}
