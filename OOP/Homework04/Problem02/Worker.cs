using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    public class Worker : Human
    {
        public const int workingDaysInWeek = 5;
        //Field
        private double weekSalary;
        private double workHourPerDay;

        //Constructor
        public Worker(string firstName, string lastName, double workSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = workSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        //Properties

        public double WeekSalary
        {
            get
            {
                return weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The salary must be a non-zero value");
                }
                else
                {
                    weekSalary = value;
                }
            }
        }
        public double WorkHoursPerDay
        {
            get
            {
                return workHourPerDay;
            }
            set
            {
                if (value < 0 || value > 9)
                {
                    throw new ArgumentOutOfRangeException("The worktime should be between 0 and 8 hours");
                }
                else
                {
                    workHourPerDay = value;
                }
            }
        }


        //Method
        public double MoneyPerHour()
        {
            return this.weekSalary / (double)(this.workHourPerDay * workingDaysInWeek);
        }
        public string GetFirstName()
        {
            return this.FirstName;
        }

        public string GetLastName()
        {
            return this.LastName;
        }
        public override string ToString()
        {
            return string.Format("I am {0} {1}. My salary per hour is {2:F2}.",
                GetFirstName(), GetLastName(), MoneyPerHour());
        }

    }
}
