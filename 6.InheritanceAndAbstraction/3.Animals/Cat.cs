using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    public abstract class Cat:Animal
    {
        public Cat(string name, int age, string gender)
            : base(name, age, gender)
        {

        }
        public override int GetAge()
        {
            return this.Age;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("I am cat");
        }
    }
}
