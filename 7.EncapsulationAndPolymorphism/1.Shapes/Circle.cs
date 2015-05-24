using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class Circle: BasicShape,IShape
    {
        private double r;
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double Radius 
        {
            get
            {
                return this.r;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.r = value;
            }
        }
        public override double CalculateArea()
        {
            double area = Math.PI * (r * r);
            Console.Write("Circle area: ---> ");
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * r;
            Console.Write("Cirle perimeter: ---> ");
            return perimeter;
        }
    }
}
