using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    class Teachers:People
    {
        private List<Disciplines> disciplines;

        public Teachers(string name, List<Disciplines> disciplines)
            :base(name)
        {
            this.Disciplines = disciplines;
        }
        public List<Disciplines> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                this.disciplines = value;
            }
        }
        public string ToStringTeachers()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\nTeacher: " + this.Name);
            foreach (var item in disciplines)
            {
                result.Append(item.ToStringDiscipline());
            }
            return result.ToString();
        }
    }
}
