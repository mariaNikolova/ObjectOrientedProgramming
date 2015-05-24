using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Customer
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Payment paymentOne = new Payment("EVN", 100) ;
            Payment paymentTwo = new Payment("SY",300);
            List<Payment> listOfPayment = new List<Payment>() ;
            listOfPayment.Add(paymentOne) ;
            listOfPayment.Add(paymentTwo) ;

            CustomerType customerType = CustomerType.Diamond ;

            Customer customerOne = new Customer("Georgi", "Ivanov", "Petrov", 23, "ul:Georgi Izmirliev",
                "+3598774576**", "georgi@abv.bg", listOfPayment, customerType);
            Customer customerTwo = customerOne;

            Console.WriteLine("customerOne = customerTwo ---->");
            Console.WriteLine(customerOne.Equals(customerTwo));

            Customer customerThree = new Customer("Pesho", "Ivanov", "Petrov", 23, "ul:Georgi Izmirliev",
                "+3598774576**", "georgi@abv.bg", listOfPayment, customerType);

            Console.WriteLine("customerOne != customerThree ---->");
            Console.WriteLine(customerOne.Equals(customerThree));

            Console.WriteLine("customerOne.ToString() --->");
            Console.WriteLine(customerOne.ToString());

            Console.WriteLine("customerTwo getHashCode --->");
            Console.WriteLine(customerTwo.GetHashCode());

            Customer customerFour = customerOne.Clone();
            Console.WriteLine("customerFour Clone() ---->");
            Console.WriteLine(customerFour.ToString());

            Customer[] customers = { customerOne, customerTwo, customerThree };
            Array.Sort(customers);
            Console.WriteLine("Sorted customer --->");
            foreach (var item in customers)
            {
                Console.WriteLine(item.FirstName + " " + item.MiddleName + " " + item.LastName + " " + item.Id);
            }
        }
    }
}
