using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    public abstract class Animal:ISound
    {
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        protected string Name { get; set; }
        protected int Age { get; set; }
        protected string Gender { get; set; }
        public abstract int GetAge();
        public abstract void ProduceSound();
    }
}
