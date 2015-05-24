using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalog
{
    class Computer
    {
        private string name;
        private double price;
        private IList<Component> components;

        public Computer(string name)
        {
            this.Name = name;
            this.Components = new List<Component>();
        }

        public Computer(string name, IList<Component> components)
            : this(name)
        {
            this.Components = components;
        }
      
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name");
                }
                this.name = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid price");
                }
                this.price = value;
            }
        }

        public IList<Component> Components
        {
            get { return this.components; }
            set
            {
                if (null == value) throw new ArgumentNullException("Computer components can not be null!");
                this.components = value;
            }

        }
        public double sum(IList<Component> components)
        {
            double totalSum = 0;
            for (int i = 0; i < components.Count; i++)
            {
                totalSum = totalSum + components[i].ComponentPrice;
            }
            this.price = totalSum;
            return this.price;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sum(this.components);
            sb.AppendFormat("Name: {0}\nPrice: {1:C}\nComponents:\n", this.name, this.price);

            foreach (Component component in this.Components)
            {
                sb.AppendLine(component.ToString());
            }

            return sb.ToString();
        }
    }
}
