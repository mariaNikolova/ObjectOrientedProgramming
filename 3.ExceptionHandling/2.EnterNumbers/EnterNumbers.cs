using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            int number;
            for (int i = 0; i < 10; i++)
            {
                number = ReadNumber(start, end);
            }
        }
        static int ReadNumber(int start, int end)
        {
            int number=0;
            try
            {
                Console.WriteLine("Number: ");
                number = int.Parse(Console.ReadLine());
                if (number < start || number > end)
                {
                    while (number < start || number > end)
                    {
                        Console.WriteLine("Number should be in the range of {0} - {1}",
                            start, end);
                        Console.WriteLine("Enter number again: ");
                        number = int.Parse(Console.ReadLine());
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            return number;
            
        }

    }
}
