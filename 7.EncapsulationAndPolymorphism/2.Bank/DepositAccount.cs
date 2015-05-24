using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    class DepositAccount:Account,IAccount
    {
        public DepositAccount(Customer customer, double balance, double interest)
            : base(customer, balance, interest)
        {
        }
        public override double Deposit(double money)
        {
            Balance = Balance + money;
            return Balance;
        }
        public override double Withdrow(double money)
        {
            Balance = Balance - money;
            return Balance;
        }

        public override double CalculateInterest(int months)
        {
            double result = 0.0 ;
            if (Balance > 0 && Balance < 1000)
            {
                Interest = 0.0;
                result = Balance * (1 + Interest * months);
            }
            result = Balance * (1 + Interest * months);
            return result;
        }
    }
}
