using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    class Student : People
    {
        private int idNumber;

        public Student(string name, int idNumber)
            : base(name)
        {
            this.IdNumber = idNumber;
        }
        public int IdNumber
        {
            get
            {
                return this.idNumber;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The id number can't negativ");
                }
                this.idNumber = value;
            }
        }
        public string toStringStudent()
        {
            return string.Format("I am: {0} whit id number: {1}",
                this.Name, this.IdNumber);
        }
    }
}
