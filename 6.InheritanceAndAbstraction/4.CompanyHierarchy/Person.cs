using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        public Person(int id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid first name!");
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
               if(string.IsNullOrEmpty(value))
               {
                   throw new ArgumentException("Invalid last name!");
               }
               this.lastName = value;
            }
        }

        public virtual void toString()
        {
            Console.WriteLine("Id: {0},\nFirst name: {1},\nLast name: {2}", this.id, this.firstName, this.lastName);
        }
    }
}
