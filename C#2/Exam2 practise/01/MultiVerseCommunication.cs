using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class MultiVerseCommunication
    {
       
        static long result = 0;
        static void Translator(string subWord, int counter)
        {

            switch (subWord)
            {
                case "CHU": result += 0 * (long)Math.Pow(13, counter); break;
                case "TEL": result += 1 * (long)Math.Pow(13, counter); break;
                case "OFT": result += 2 * (long)Math.Pow(13, counter); break;
                case "IVA": result += 3 * (long)Math.Pow(13, counter); break;
                case "EMY": result += 4 * (long)Math.Pow(13, counter); break;
                case "VNB": result += 5 * (long)Math.Pow(13, counter); break;
                case "POQ": result += 6 * (long)Math.Pow(13, counter); break;
                case "ERI": result += 7 * (long)Math.Pow(13, counter); break;
                case "CAD": result += 8 * (long)Math.Pow(13, counter); break;
                case "K-A": result += 9 * (long)Math.Pow(13, counter); break;
                case "IIA": result += 10 * (long)Math.Pow(13, counter); break;
                case "YLO": result += 11 * (long)Math.Pow(13, counter); break;
                case "PLA": result += 12 * (long)Math.Pow(13, counter); break;
                default: break;
            }
        }
        static void Main(string[] args)
        {
            int counter = 0;
            string subWord;
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length ; i += 3)
            {
                subWord = word.Substring(word.Length - 1 - i - 2, 3);
                Translator(subWord, counter);
                counter++;
            }
            Console.WriteLine(result);
        }

    }
}
