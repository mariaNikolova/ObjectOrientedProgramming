using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    class Class
    {
        private string idText;
        List<Teachers> teachers;

        public Class(string idText, List<Teachers> teachers)
        {
            this.IdText = idText;
            this.Teachers = teachers;
        }
        public string IdText
        {
            get
            {
                return this.idText;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The text is empty");
                }
                this.idText = value;
            }
        }
        public List<Teachers> Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("This is:" + this.idText + " class");
            foreach (var item in teachers)
            {
                result.Append(item.ToStringTeachers());
            }
            return result.ToString();
        }
    }
}
