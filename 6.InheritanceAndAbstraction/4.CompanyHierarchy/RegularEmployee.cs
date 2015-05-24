using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class RegularEmployee : Employee
    {
        public RegularEmployee(int id, string firstName, string lastName, double salary, Department depart)
            : base(id, firstName, lastName, salary, depart)
        {

        }
    }
}
