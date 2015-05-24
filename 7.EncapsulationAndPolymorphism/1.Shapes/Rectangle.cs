using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class Rectangle:BasicShape,IShape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public override double Width 
        {
            get
            {
                return this.width;
            }
            set
            {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.width = value;
            }
        }
        public override double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.height = value;
            }
        }
        public override double CalculateArea()
        {
            double area = width * height;
            Console.Write("Rectangle area: ---> ");
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * width + 2 * height;
            Console.Write("Rectangle perimeter: ---> ");
            return perimeter;
        }
    }
}
