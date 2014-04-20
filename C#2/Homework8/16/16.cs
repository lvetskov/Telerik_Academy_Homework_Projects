using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _16
{
    //Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. Example:

    class TimeInterval
    {
        static void Main()
        {
            string start = "27.02.2014";
            string end = "3.03.2014";

            DateTime startDate = DateTime.ParseExact(start, "d.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(end, "d.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine((endDate - startDate).TotalDays);
        }
    }
}
