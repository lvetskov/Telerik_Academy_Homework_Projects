using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    //Write a method that calculates the number of workdays between today and given date, passed as parameter. Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
    class WorkingDays
    {
        static void Main(string[] args)
        {
            var holidays = new List<DateTime>();

            holidays.Add(new DateTime(2014, 03, 03));
            holidays.Add(new DateTime(2014, 05, 01));
            holidays.Add(new DateTime(2014, 09, 22));
            holidays.Add(new DateTime(2014, 01, 11));

            DateTime now = DateTime.Today;
            Console.Write("Enter final date<YYYY-MM-DD>: ");
            DateTime final = DateTime.Parse(Console.ReadLine());
            CheckWorkingDates(now, final, holidays);

        }
        private static void CheckWorkingDates(DateTime now, DateTime final, List<DateTime> holidays)
        {
            //got the length between without weekends or holidays
            int lengthDays = (final - now).Days;
            int length = lengthDays;
            DateTime currentDate = new DateTime();
            //check which dates of the period are weekends or holidays
            //and decrease the length
            //we pass through the whole period
            for (int i = 0; i <= length; i++)
            {
                //increase date
                currentDate = now.AddDays(i);
                //we compare the currentDate with every single holiday
                for (int days = 0; days < holidays.Count; days++)
                {
                    int comparison = currentDate.CompareTo(holidays[days]); //if match return 0
                    if (comparison == 0)
                    {
                        //decrease the length of period
                        lengthDays--;
                    }
                }
                //check is the current day in weekend
                if (currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    //decrease the length ot period
                    lengthDays--;
                }
            }

            PrintResult(now, final, lengthDays);

        }

        private static void PrintResult(DateTime now, DateTime final, int lengthDays)
        {
            Console.WriteLine("Today is: {0:D}", now);
            Console.WriteLine("Final Date is: {0:D}", final);
            Console.WriteLine();
            Console.WriteLine("Working days: {0}\n", lengthDays);
        }



    }
}
