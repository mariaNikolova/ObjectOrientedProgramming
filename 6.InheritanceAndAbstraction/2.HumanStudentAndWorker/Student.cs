using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HumanStudentAndWorker
{
    public class Student:Human
    {
        private string facNumber;
        public Student(string fName, string lName, string facNumber):base(fName,lName)
        {
            this.FacNumber = facNumber;
        }
        public string FacNumber
        {
            get
            {
                return this.facNumber;
            }
            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.facNumber = value;
            }
        }

        public string ToStringStudents()
        {
            return string.Format("First name: {0}, Last name: {1}, Faulty number: {2}",
                this.FirstName, this.LastName, this.facNumber);
        }
    }
}
