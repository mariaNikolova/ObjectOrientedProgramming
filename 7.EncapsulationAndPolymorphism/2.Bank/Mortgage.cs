using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    class Mortgage:Account,IAccount
    {
        public Mortgage(Customer customer, double balance, double interest) 
            : base(customer, balance, interest) 
        { 
        }
        public override double Deposit(double money)
        {
            Balance = Balance + money;
            return Balance;
        }

        public override double CalculateInterest(int months)
        {
            double result = 0.0;
            int monthsWithInterest;
            if (Customer == Customer.Companies)
            {
                if (months <= 12)
                {
                    Interest = Interest / 2;
                    result = Balance * (1 + Interest * months);
                }
                else
                {
                    monthsWithInterest = months - 12;
                    result = Balance * (1 + Interest * monthsWithInterest);
                }
            }
            else if (Customer == Customer.Individuals)
            {
                if (months <= 6)
                {
                    result = Balance;
                }
                else
                {
                    monthsWithInterest = months - 6;
                    result = Balance * (1 + Interest * monthsWithInterest);
                }
                
            }
            return result;
        }
    }
}
