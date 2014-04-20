using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class StrangeLandNumbers
    {
        static string numberInString;
        static int counter = 0;


        static void Main(string[] args)
        {
            ulong result = 0;
            numberInString = Console.ReadLine();
            while (!String.IsNullOrEmpty(numberInString))
            {
                bool step = false;
                StringBuilder subWord = new StringBuilder();
                for (int i = numberInString.Length - 1; i >= 0; i--)
                {
                    subWord.Clear();
                    subWord.Append(numberInString.Substring(i, numberInString.Length - i));
                    switch (subWord.ToString())
                    {
                        case "f": result += 0 * (ulong)Math.Pow(7, counter); numberInString = numberInString.Remove(i); counter++; step = true; break;
                        case "bIN": result += 1 * (ulong)Math.Pow(7, counter); numberInString = numberInString.Remove(i); counter++; step = true; break;
                        case "oBJEC": result += 2 * (ulong)Math.Pow(7, counter); numberInString = numberInString.Remove(i); counter++; step = true; break;
                        case "mNTRAVL": result += 3 * (ulong)Math.Pow(7, counter); numberInString = numberInString.Remove(i); counter++; step = true; break;
                        case "lPVKNQ": result += 4 * (ulong)Math.Pow(7, counter); numberInString = numberInString.Remove(i); counter++; step = true; break;
                        case "pNWE": result += 5 * (ulong)Math.Pow(7, counter); numberInString = numberInString.Remove(i); counter++; step = true; break;
                        case "hT": result += 6 * (ulong)Math.Pow(7, counter); numberInString = numberInString.Remove(i); counter++; step = true; break;
                        default: break;
                    }
                    if (step)
                    {
                        break;
                    }
                }

            }
            Console.WriteLine(result);
        }
    }
}
