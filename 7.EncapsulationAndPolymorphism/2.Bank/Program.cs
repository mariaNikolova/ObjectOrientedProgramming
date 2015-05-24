using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customerInviduals = Customer.Individuals;
            Customer customerCompanies = Customer.Companies;
            
            DepositAccount deposit = new DepositAccount(customerInviduals, 1100, 4);
            Console.WriteLine("Deposit calsulate interest: --->");
            Console.WriteLine(deposit.CalculateInterest(4));
            
            Mortgage mortgage = new Mortgage(customerInviduals, 100, 2);
            Console.WriteLine("Mortage calculate interest: --->");
            Console.WriteLine(mortgage.CalculateInterest(7));

            LoanAccounts loanAccounts = new LoanAccounts(customerCompanies, 200, 3);
            Console.WriteLine("Loan account interest: --->");
            Console.WriteLine(loanAccounts.CalculateInterest(2));
        }
    }
}
