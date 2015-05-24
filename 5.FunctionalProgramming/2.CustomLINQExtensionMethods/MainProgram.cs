using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CustomLINQExtensionMethods
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            Console.WriteLine("Where not: ---->");
            Console.WriteLine(string.Join(", ", list.WhereNot<int>(a => a % 2 == 0)));
            Console.WriteLine("Repeat: ---->");
            Console.WriteLine(string.Join(", ", list.Repeat<int>(2)));
            Console.WriteLine("WhereEndsWith: ---->");
            IEnumerable<string> stringItems = new List<string>() { "ala", "bala", "nica", "turska", "panica" };
            IEnumerable<string> suffixes = new List<string>() { "ala", "ka" };
            Console.WriteLine(string.Join(", ", stringItems.WhereEndsWith(suffixes)));
        }
    }
}
