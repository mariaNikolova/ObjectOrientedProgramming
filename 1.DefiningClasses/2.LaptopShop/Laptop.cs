using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int RAM;
        private string graphicsCard;
        private int HDD;
        private string screen ;
        private Battery battery;
        private double price;

        public Laptop(string model, double price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model,double price,string manufacturer,string processor,int RAM,string graphicsCard,
            int HDD, string screen, Battery battery)
            :this(model,price)
        {   
            this.Processor = processor;
            this.Ram = RAM;
            this.Manufacturer = manufacturer;
            this.GraphicsCard = graphicsCard;
            this.Hdd = HDD;
            this.Screen = screen;
            this.Battery= battery;
            this.price = price;
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid model") ;
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid manufacturer");
                }
                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid processor");
                }
                this.processor = value;
            }
        }
        public int Ram
        {
            get
            {
                return this.RAM;
            }
            set
            {
                if (value <= 0 )
                {
                    throw new ArgumentException("Invalid RAM");
                }
                this.RAM = value;
            }
        }
        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid graphicsCard");
                }
                this.graphicsCard = value;
            }
        }
        public int Hdd
        {
            get
            {
                return this.HDD;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid HDD");
                }
                this.HDD = value;
            }
        }
        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid screen");
                }
                this.screen= value;
            }
        }
        public Battery Battery
        {
            get{
                return this.battery ;
            }
            set{
                this.battery = value ;
            }
        }
        
        
        public double Price
        {
            get{
                return this.price ;
            }
            set{
                if(value <=0 ){
                    throw new ArgumentException("Invalid price") ;
                }
                this.price = value;
            }

        }
        public override string ToString()
        {
            string str;
            if (this.battery == null)
            {
                str = "";
            }
            else
            {
                str = this.battery.ToString();
            }

            return string.Format("Model: {0} \nPrice: {1} lv \nManufacturer: {2} \nProcessor: {3} \nRAM: {4} GB \nGraphics card: {5} \nHDD: {6} GB SSD \nScreen: {7} \nBattery: {8}",
                this.model, this.price, this.manufacturer, this.processor, this.RAM, 
                this.graphicsCard, this.HDD, this.screen, str);
        }
    }
}
    

