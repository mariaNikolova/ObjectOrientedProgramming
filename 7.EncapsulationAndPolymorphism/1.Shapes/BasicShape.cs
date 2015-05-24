using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
   abstract class BasicShape: IShape
   {
       public BasicShape()
       {
           // TODO: Complete member initialization
       }
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        
    }
}
