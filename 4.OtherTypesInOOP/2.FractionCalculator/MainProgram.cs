using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.FractionCalculator
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(22, 7);
            Fraction fraction2 = new Fraction(40, 4);
            Fraction resultAddition = fraction1+fraction2;
            Console.WriteLine(resultAddition.Numerator);
            Console.WriteLine(resultAddition.Denominator);
            Console.WriteLine("The addition is: {0}", resultAddition.ToString());

            Fraction fraction3 = new Fraction(22, 7);
            Fraction fraction4 = new Fraction(40, 4);
            Fraction resultSubtraction = fraction3-fraction4;
            Console.WriteLine(resultSubtraction.Numerator);
            Console.WriteLine(resultSubtraction.Denominator);
            Console.WriteLine("The substraction is: {0}", resultSubtraction.ToString());
        }
    }
}
