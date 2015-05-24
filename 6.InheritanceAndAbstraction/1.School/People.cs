using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    class People
    {
        private string name;
        public People(string name)
        {
            this.Name = name;
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
                    throw new ArgumentException("The name is empty");
                }
                this.name = value;
            }
        }
        public void Talk()
        {
            Console.WriteLine("I am people and I can talk.");
        }
    }
}
