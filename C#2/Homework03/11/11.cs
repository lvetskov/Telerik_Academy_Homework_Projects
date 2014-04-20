using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    //Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
    //	x2 + 5 = 1x2 + 0x + 5  105

    class Program
    {
        static void PrintPolinomial(int[] polinomial)
        {
            Console.WriteLine("The polinomial looks like:");
            bool sign = false;
            for (int combo = 0; combo < polinomial.Length; combo++)
            {
                if (sign)                                    //
                {                                            //
                    if (polinomial[combo] >= 0)              //determine the sign
                    {                                        //
                        Console.Write("+");                  //
                    }                                        //
                }
                Console.Write(polinomial[combo] + "x^" + (polinomial.Length - combo - 1) + " ");
                sign = true;
            }
        }
        static void AddPolinomials(int[] first, int[] second)
        {
            Console.WriteLine("The sum of the two polinomials looks like:");
            int[] sum = new int[Math.Max(first.Length, second.Length)];
            for (int i = first.Length - 1, j = second.Length - 1, k = Math.Max(first.Length, second.Length) - 1; (i >= 0) && (j >= 0); i--, j--, k--)
            {
                sum[k] = first[i] + second[j];
            }
            if (Math.Min(first.Length, second.Length) == first.Length)
            {
                for (int i = second.Length - first.Length - 1; i >=0 ; i--)
                {
                    sum[i] = second[i];
                }
            }
            bool sign = false;
            for (int i = 0; i < sum.Length; i++)
            {
                if (sign)                                    //
                {                                            //
                    if (sum[i] >= 0)                         //determine the sign
                    {                                        //
                        Console.Write("+");                  //
                    }                                        //
                }
                Console.Write(sum[i] + "x^" + (sum.Length - i - 1) + " ");
                sign = true;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coefficients for the first polinomial. To exit the sequence press Enter");
            List<int> firstPolinomialList = new List<int>();
            bool sequence = true;
            int value = 0;
            while (true)
            {
                sequence = int.TryParse(Console.ReadLine(), out value);
                if (sequence)
                {
                    firstPolinomialList.Add(value);
                }
                else
                {
                    break;
                }
            }
            int[] firstPolinomial = firstPolinomialList.ToArray();
            PrintPolinomial(firstPolinomial);

            Console.WriteLine("Enter the coefficients for the second polinomial. To exit the sequence press Enter");
            List<int> secondPolinomialList = new List<int>();
            sequence = true;
            value = 0;
            while (true)
            {
                sequence = int.TryParse(Console.ReadLine(), out value);
                if (sequence)
                {
                    secondPolinomialList.Add(value);
                }
                else
                {
                    break;
                }
            }
            int[] secondPolinomial = secondPolinomialList.ToArray();
            PrintPolinomial(secondPolinomial);
            Console.WriteLine();
            AddPolinomials(firstPolinomial, secondPolinomial);
        }
    }
}
