using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalog
{
    class PCCatalog
    {
        static void Main(string[] args)
        {

            string name = "Lenovo";
            Component motherboard = new Component("motherboard", "several details", 20);
            Component mouse = new Component("mouse", "several details", 100);
            Component keyboard = new Component("keyboard", "several details", 100);
            List<Component> components = new List<Component> { motherboard, mouse, keyboard };
            Computer computerOne = new Computer(name, components);

            string nameTwo = "Acer";
            Component processor = new Component("processor", "several details", 20);
            Component graphicsCard = new Component("graphics card", "several details", 10);
            Component hdd = new Component("HDD", "several details", 10);
            List<Component> componentsTwo = new List<Component> { processor, graphicsCard, hdd};
            Computer computerTwo = new Computer(nameTwo, componentsTwo);


            string nameThree = "HP";
            Component battery = new Component("battery", "several details", 20000);
            Component ram = new Component("RAM", "several details", 1000);
            Component batteryLife = new Component("battery life", "several details", 10000);
            List<Component> componentsThree = new List<Component> {battery, ram, batteryLife };
            Computer computerThree = new Computer(nameThree, componentsThree);


            StringBuilder builder = new StringBuilder();
            builder.Append(computerOne.ToString());
            builder.Append(computerTwo.ToString());
            builder.Append(computerThree.ToString());

        
            List<Computer> computers = new List<Computer>() { computerThree, computerOne, computerTwo, computerThree };

            computers = computers.OrderBy(computer => computer.Price).ToList();

            for (int i = 0; i < computers.Count; i++)
            {
                Console.WriteLine(computers[i].ToString());
            }
            
        }
    }
}
