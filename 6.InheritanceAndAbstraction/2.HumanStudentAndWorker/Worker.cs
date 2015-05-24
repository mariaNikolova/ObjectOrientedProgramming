using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HumanStudentAndWorker
{
    class Worker: Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string fName, string lName, double weekSalary, double workHoursPerDay)
            :base(fName,lName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
       
        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The week salary can not be negativ");
                }
                this.weekSalary = value;
            }
        }
        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The work hours per day can not be negativ");
                }
                this.workHoursPerDay = value;
            }
        }
        public double MoneyPerHour()
        {
            return this.weekSalary/(this.workHoursPerDay*5);
        }
        public override string ToString()
        {
           return string.Format("Firs name: {0} , Last name: {1} ,Week salary: {2} , WorkHoursPerDay: {3}",
               this.FirstName, this.LastName, this.weekSalary, this.workHoursPerDay) ;
        }
    }
}
