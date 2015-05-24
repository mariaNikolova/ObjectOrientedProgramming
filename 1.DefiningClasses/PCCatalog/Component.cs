using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalog
{
    class Component
    {
       private string name;
       private string details;
       private double price;

       public Component(string name, double price)
       {
           this.Name = name;
           this.ComponentPrice = price;
       }
       public Component(string name,string details,double price):this(name,price)
        {
            this.Details = details ;
            
        }
        public string Name{
            get{
                return this.name ;
            }
            set{
                if(string.IsNullOrEmpty(value)){
                    throw new ArgumentException("Invalid name") ;
                }
                this.name = value ;
            }
        }
        public string Details{
            get{
                return this.details;
            }
            set{
                if(string.IsNullOrEmpty(value)){
                    throw new ArgumentException("Invalid details") ;
                }
                this.details = value ;
            }
        }
        public double ComponentPrice{
            get{
                return this.price ;
            }
            set{
                if(value<=0 ){
                    throw new ArgumentException("Invalid price") ;
                }
                this.price = value ;
            }
        }
        public override string ToString()
        {
            return string.Format("Name: {0},Details: {1},Price: {2}",
                this.name, this.details, this.price);
        }

    }
}
