using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Square_Root
{
    class MainProgram
    {
        static void Main(string[] args)
        {

             try
            {
                Console.WriteLine("Number: ");
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                IntegerNumber num = new IntegerNumber(number);
                Console.WriteLine(num.SquareRoot());
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Negative number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }   
    }
}

