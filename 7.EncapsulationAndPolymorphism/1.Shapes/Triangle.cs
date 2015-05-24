using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class Triangle: BasicShape, IShape
    {
        private double sideA ;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }
        public double SideA 
        {
            get
            {
                return this.sideA;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
               // if ((sideA < (sideB + sideC)) && (sideB < (sideA + sideC)) && (sideC < (sideA + sideB)))
               // {
                    this.sideA = value;
               // }
               // throw new ArgumentException("This is not validate triagle");
            }
        }

        public double SideB
        {
            get
            {
                return this.sideB;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                //if ((sideA < (sideB + sideC)) && (sideB < (sideA + sideC)) && (sideC < (sideA + sideB)))
                //{
                    this.sideB = value;
                //}
                //throw new ArgumentException("This is not validate triagle");  
            }
        }
        public double SideC
        {
            get
            {
                return this.sideC;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                //if ((sideA < (sideB + sideC)) && (sideB < (sideA + sideC)) && (sideC < (sideA + sideB)))
               // {
                    this.sideC = value;
               // }
               // throw new ArgumentException("This is not validate triagle");  
            }
        }
        public override double CalculateArea()
        {
            double p = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            Console.Write("Triangle area: ---> ");
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = sideA + sideB + sideC;
            Console.Write("Triangle perimeter: ---> ");
            return perimeter;
        }
    }
}
