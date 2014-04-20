using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    //Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

    class SubStringCounter
    {
        static int SubStringCounterMethod(string text, string subString)
        {
            int counter = 0;
            for (int i = 0; i < text.Length - subString.Length; i++)
            {
                string subStringForCount = text.Substring(i, subString.Length);
                if (subStringForCount.ToLower() == subString.ToLower())
                {
                    counter++;
                }
                subStringForCount = String.Empty;
            }
            return counter;
        }
        static void Main(string[] args)
        {
            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            Console.WriteLine("The text is: \n{0}\n", text);
            Console.Write("Enter a substring to count its occurence in the text: ");
            string subString = Console.ReadLine();
            Console.WriteLine("The substring {0} is met {1} times!", subString, SubStringCounterMethod(text, subString)); 
        }
    }
}
