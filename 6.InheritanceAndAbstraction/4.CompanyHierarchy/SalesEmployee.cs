using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class SalesEmployee : RegularEmployee
    {
        private List<Sale> sales;

        public SalesEmployee(int id, string firstName, string lastName, double salary, Department depart,List<Sale> sales)
            : base(id, firstName, lastName, salary, depart)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales 
        {
            get
            {
                return this.sales;
            }
            set
            {
                this.sales = value;
            }
        }

        public override void toString()
        {
            base.toString();
            foreach(var item in sales)
            {
                item.toString();
            }
        }

    }
}
