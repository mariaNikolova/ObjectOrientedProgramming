using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Square_Root
{
    class IntegerNumber
    {
        private int number;

        public IntegerNumber(int number)
        {
            this.Number = number;
        }
        public int Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }
        public double SquareRoot()
        {
            return Math.Sqrt(this.number);
        }
    }
}
