using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.StringDisperser
{
    class MainProgram
    {
        static void Main(string[] args)
        {

            StringDisperser stringDisperserOne = new StringDisperser("gosho", "pesho", "sasho", "kiro");
            StringDisperser stringDisperserTwo = new StringDisperser("gosho", "pesho", "sasho", "kiro");

            Console.WriteLine("stringDisperserOne = stringDisperserTwo --->");
            Console.WriteLine(stringDisperserOne.Equals(stringDisperserTwo));

            StringDisperser stringDisperserThree = new StringDisperser("mitko", "Ivan");
            Console.WriteLine("stringDisperserOne != stringDisperserThree --->");
            Console.WriteLine(stringDisperserOne.Equals(stringDisperserThree));

            Console.WriteLine("stringDisperserOne ToString() --->");
            Console.WriteLine(stringDisperserOne.ToString());

            Console.WriteLine("stringDisperserTwo GetHashCode() --->");
            Console.WriteLine(stringDisperserTwo.GetHashCode());

            StringDisperser stringDisperserFour = stringDisperserOne.Clone();
            Console.WriteLine("stringDisperserFour Clone() --->");
            Console.WriteLine(stringDisperserFour.ToString());

            Console.WriteLine("stringDisperserOne.CompareTo(stringDisperserTwo) --->");
            Console.WriteLine(stringDisperserOne.CompareTo(stringDisperserTwo));

            Console.WriteLine("stringDisperserOne --->");

           foreach (var ch in stringDisperserOne)
            {
                   Console.Write(ch + " ");
            }
            Console.WriteLine();
        }
    }
}
