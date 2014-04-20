using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    //You are given a sequence of positive integer values written into a string, separated by spaces. Write a function that reads these values from given string and calculates their sum. Example:
    //		string = "43 68 9 23 318"  result = 461

    class SplitStrings
    {
        static void Main(string[] args)
        {
            string myString = "43 68,9   , 23 / 318";
            int sum = SumOfStrings(myString);
            Console.WriteLine(sum);
        }
        private static int SumOfStrings(string myString)
        {
            int sum;
            char[] charSeparators = new char[] { ' ', ',', '-', '/' };
            string[] splittedArray = myString.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            sum = CompleteSum(splittedArray);
            return sum;
        }
        private static int CompleteSum(string[] splittedArray)
        {
            int total = 0;
            foreach (string number in splittedArray)
            {
                total += int.Parse(number);
            }
            return total;
        }
    }
}