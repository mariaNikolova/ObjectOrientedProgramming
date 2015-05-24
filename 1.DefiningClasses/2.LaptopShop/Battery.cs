using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.LaptopShop
{
    class Battery
    {
         private string type;
         private double hours;

         public Battery(string type)
         {
             this.type = type;
         }
         public Battery(string type, double hours):this(type)
         {
             this.Hours = hours;
         }
         public string Type
         {
             get
             {
                 return this.type;
             }
             set
             {
                 if (string.IsNullOrEmpty(value))
                 {
                     throw new ArgumentException("Invalid type");
                 }
                 this.type = value;
             }
         }
         public double Hours
         {
             get
             {
                 return this.hours;
             }
             set
             {
                 if (value <= 0)
                 {
                     throw new ArgumentException("Invalid hours");
                 }
                 this.hours = value;
             }
         }
         public override string ToString()
         {
             return string.Format(" {0}  \nBattery life: {1}hours", this.type, this.hours);
         }
    }
}
