using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string personName = Console.ReadLine();
            Console.Write("Age: ");
            int personAge = int.Parse(Console.ReadLine());
            Console.Write("Email: ");
            string personEmail = Console.ReadLine();

            Person person = new Person(personName, personAge, personEmail);
            Console.WriteLine(person.ToString());
        }
    }
}
