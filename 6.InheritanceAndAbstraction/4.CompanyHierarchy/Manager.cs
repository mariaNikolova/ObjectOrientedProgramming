using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Manager : Employee, IManager
    {
        private List<Employee> employeees;

        public Manager(int id, string firstName, string lastName, double salary, Department depart, List<Employee> employeees) 
            : base(id, firstName, lastName, salary, depart)
        {
            this.Employees = employeees;
        }
        public List<Employee> Employees
        {
            get
            {
                return this.employeees;
            }
            set
            {
                this.employeees = value;
            }
        }

        public override void toString()
        {
            
             base.toString();
             foreach(var item in employeees)
             {
                 item.toString();
             }
        }
    }
}
