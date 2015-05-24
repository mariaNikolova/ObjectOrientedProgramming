using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Rectangle rectangle = new Rectangle(2, 3);
            
            Circle circle = new Circle(3);
           
            List<BasicShape> shapes = new List<BasicShape>();
            shapes.Add(rectangle);
            shapes.Add(triangle);
            shapes.Add(circle);

            foreach (var item in shapes)
            {
                Console.WriteLine(item.CalculateArea());
                Console.WriteLine(item.CalculatePerimeter());
            }

        }
    }
}
