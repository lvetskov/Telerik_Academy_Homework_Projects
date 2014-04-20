using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace secret_number
{
    class Program
    {
        static void Main(string[] args)
        {
            char sym;
            BigInteger sum = 0;
            string number = Console.ReadLine();
            number = number.TrimStart(new char[] { '-' });
   //         Console.WriteLine(number);
            int counter = 1;



                      for (int i = 0; i < number.Length; i++)
                     {
                         sym = number[i];
                         if (counter % 2 != 0)
                         {
                             sum += (int)(number[(number.Length - 1) - i] - '0') * counter   *       counter;
                         }
                         else
                         {
                             sum += (int)(number[(number.Length - 1) - i] - '0') * (int)      (number  [(number.Length - 1) - i] - '0') * counter;
                         }
                         counter++;
                     }
                     Console.WriteLine(sum);

                     if (sum % 10 == 0)
                     {
                         Console.WriteLine("{0} has no secret alpha-sequence", number);
                         Environment.Exit(0);
                     }
                     BigInteger R = sum % 26 + 1;
                     //         Console.WriteLine(R);
                     BigInteger sequenceLength = sum % 10;
                     char alphaSec;
                     for (int i = 0; i < sequenceLength; i++)
                     {
                         alphaSec = Convert.ToChar((int)R + 64 + i);
                         if (alphaSec > 90)
                         {
                             Console.Write((char)(alphaSec - 26));
                         }
                         else
                         {
                             Console.Write(alphaSec);
                         }
            }
        }
    }
}