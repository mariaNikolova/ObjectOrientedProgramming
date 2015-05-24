using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{       
        public enum Department
        {
            Production, Accounting, Sales, Marketing
        }
    class Employee : Person , IEmployee
    {
        private double salary;
        private Department departament;
       
        public Employee(int id, string firstName, string lastName, double salary, Department depart) : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.departament = depart;
        }
        

        public double Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.salary = value;
            }
        }

        public override void toString()
        {
            base.toString();
            Console.WriteLine("Salary:{0},\nDepartament: {1}", this.salary, this.departament);
        }
    }
}
