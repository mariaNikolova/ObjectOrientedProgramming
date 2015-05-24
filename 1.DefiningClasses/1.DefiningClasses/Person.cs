using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DefiningClasses
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        
        public Person(string name="", int age=0 , string email="")
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
                else
                {
                    this.name = value;
                }
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
                    this.email = value;
                    
                }
                else
                {
                    
                    bool isEqual = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (value[i].Equals('@'))
                        {
                            isEqual = true;
                        }
                        
                    }
                    if (isEqual)
                    {
                        this.email = value;
                    }
                    else
                    {
                        throw new ArgumentException("Invalid email");
                    }
                }
               
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
                if (value < 0 || value >= 100)
                {
                    throw new AccessViolationException("Invalid age! It should be in the range [1...100].");
                }
                else
                {
                    this.age = value;
                }
            }
        }
        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Email: {2}", 
                this.name, this.age, this.email);
        }

    }
   
}
