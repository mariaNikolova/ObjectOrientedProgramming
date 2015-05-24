using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private int facultyNumber;
        private string phone;
        private string email;
        private IList<int> marks;
        private int groupNumber;

        public Student(string fName,string lName,int age,int fNumber,string phone,
                       string email, IList<int> marks, int gNumber)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Age = age;
            this.FacultyNumber = fNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = gNumber;
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Enter first name");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Enter last name");
                }
                this.lastName= value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Invalid age");
                }
                this.age = value;
            }
        }
        public int FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid faculty  number");
                }
                this.facultyNumber = value;
            }
        }
        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Enter phone");
                }
                this.phone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Enter email");
                }
                this.email = value;
            }
        }
        public IList<int> Marks
        {
            get
            {
                return this.marks;
            }
            set
            {
                this.marks = value;
            }
        }
        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid group number");
                }
                this.groupNumber = value;
            }
        }

    }
}
