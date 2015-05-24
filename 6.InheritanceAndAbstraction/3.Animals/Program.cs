using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dogOne = new Dog("Sharo", 2, "nemka ovcharka");
            dogOne.ProduceSound();
            Dog dogTwo = new Dog("Rex", 5, "dalmatinec");
            dogTwo.ProduceSound();

            Frog frog = new Frog("Penka", 4, "jalta jaba");
            frog.ProduceSound();

            Kittens kitten = new Kittens("Roshko", 2, "siamka");
            kitten.ProduceSound();

            Tomcats tomcat = new Tomcats("Toshko", 1, "siamka");
            tomcat.ProduceSound();

            Animal[] animals = new Animal[]
            {
                dogOne,dogTwo,frog,kitten,tomcat
            };

            double average = 0.0;
            foreach (var animal in animals)
            {
                average += animal.GetAge();
            }
            average = average / animals.Length;
            Console.WriteLine("Average age: {0}", average);
        }
    }
}
