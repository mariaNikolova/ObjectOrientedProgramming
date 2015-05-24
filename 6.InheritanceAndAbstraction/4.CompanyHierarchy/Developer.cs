using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Developer : RegularEmployee
    {
        private List<Project> projects;

        public Developer(int id, string firstName, string lastName, double salary, Department depart, List<Project> projects)
            : base(id, firstName, lastName, salary, depart)
        {
            this.Projects = projects;
        }
        public List<Project> Projects 
        {
            get
            {
                return this.projects;
            }
            set
            {
                this.projects = value;
            }
        }

        public override void toString()
        {
            base.toString();
            foreach(var item in projects)
            {
                item.toString();
            }
        }


    }
}
