using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GenericList
{
    [Version(0, 1)]
    class MainProgram
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>(7);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);

            Type type = typeof(MainProgram);
            VersionAttribute allAttributes = new VersionAttribute(0, 1);
            Console.WriteLine(allAttributes.ToString());
           
            Console.WriteLine("List : ---->");
            Console.WriteLine(list.ToString());

            Console.WriteLine("Accessing element by index: ---->");
            Console.WriteLine(list.Accessing(4));

            Console.WriteLine("Removing element by index: ---->");
            list.RemoveAt(4);
            Console.WriteLine(list.ToString());

            Console.WriteLine("Inserting element at given position: ---->");
            list.Insert(3, 8);
            Console.WriteLine(list.ToString());

            Console.WriteLine("Finding element index by given value: ---->");
            Console.WriteLine(list.FindingIndex(3)) ;

            Console.WriteLine("Checking if the list contains a value ---->");
            Console.WriteLine(list.Contains(4));

            Console.WriteLine("Min number in array: ---->");
            Console.WriteLine("{0}", list.Min());

            Console.WriteLine("Max number in array: ---->");
            Console.WriteLine("{0}",list.Max());

            Console.WriteLine("Clearing the list: ---->");
            list.Clear();
            Console.WriteLine(list.ToString());
        }
    }
}
