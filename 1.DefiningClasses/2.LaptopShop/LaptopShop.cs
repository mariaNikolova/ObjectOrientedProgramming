using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.LaptopShop
{
    class LaptopShop
    {
        static void Main(string[] args)
        {
            string model = "Lenovo Yoga 2 Pro";
            double price = 2259.00;
            string manufacturer = "Lenovo";
            string processor = "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)";
            int RAM = 8;
            string graphicCard = "Intel HD Graphics 4400";
            int HDD = 128;
            string screen = "(33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display";
            Battery battery = new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5);


            Laptop Lenovo = new Laptop(model, price, manufacturer, processor, RAM, graphicCard, HDD, screen, battery);
            Console.WriteLine(Lenovo.ToString());
        }
    }
}
