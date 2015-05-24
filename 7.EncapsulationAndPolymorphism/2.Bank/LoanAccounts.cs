using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    class LoanAccounts:Account,IAccount
    {
        public LoanAccounts(Customer customer, double balance, double interest)
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
            int monthsWithInterest;
            double result = 0.0 ;
            if (Customer == Customer.Individuals)
            {
                if (months <= 3)
                {
                    result = Balance;
                }
                else
                {
                    monthsWithInterest = months - 3;
                    result = Balance * (1 + Interest * monthsWithInterest);
                }
                
            }
            else if (Customer == Customer.Companies)
            {
                if (months <= 2)
                {
                    result = Balance;
                }
                else
                {
                    monthsWithInterest = months - 2;
                    result = Balance * (1 + Interest * monthsWithInterest);
                }
                
            }
            return result;
        }
    }
}
