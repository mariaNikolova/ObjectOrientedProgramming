using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    interface IAccount
    {
        double Deposit(double money);
        double CalculateInterest(int months);

    }
}
