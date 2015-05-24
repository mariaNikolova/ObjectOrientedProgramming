using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    abstract class Account: IAccount
    {
        private Customer customer;
        private double balance;
        private double interest;
        public Account(Customer customer, double balance, double interest)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.Interest = interest;
        }
        public abstract double Deposit(double money);
        public virtual double Withdrow(double money)
        {
            this.Balance = Balance - money;
            return Balance;
        }
        public abstract double CalculateInterest(int months);
        public double Balance 
        {
            get
            {
                return this.balance;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.balance = value;
            } 
        }
        public double Interest 
        {
            get
            {
                return this.interest;
            }
            set
            {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.interest = value;
            }
        }
        public Customer Customer { get; set; }
    }
}
