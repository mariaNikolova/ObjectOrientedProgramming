using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HumanStudentAndWorker
{
    public abstract class Human
    {
        private string fName;
        private string lName;

        public Human(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }
        public string FirstName 
        {
            get
            {
                return this.fName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The first name can not be empty");
                }
                this.fName = value;
            }
        }
        public string LastName 
        {
            get
            {
                return this.lName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The first name can not be empty");
                }
                this.lName = value;
            }
        }
    }
}
