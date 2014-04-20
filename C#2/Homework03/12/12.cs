using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    //Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
    //	x2 + 5 = 1x2 + 0x + 5  105 Extend the program to support also subtraction and multiplication of polynomials.


    class Program
    {
        static void PrintPolinomial(int[] polinomial)
        {
            
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
            
            int[] sum = new int[Math.Max(first.Length, second.Length)];
            for (int i = first.Length - 1, j = second.Length - 1, k = Math.Max(first.Length, second.Length) - 1; (i >= 0) && (j >= 0); i--, j--, k--)
            {
                sum[k] = first[i] + second[j];
            }
            if (Math.Min(first.Length, second.Length) == first.Length)
            {
                for (int i = second.Length - first.Length - 1; i >= 0; i--)
                {
                    sum[i] = second[i];
                }
            }
            PrintPolinomial(sum);
        }
        static void ProductOfPolinomials(int[] first, int[] second)
        {

            int[] sum = new int[Math.Max(first.Length, second.Length)];
            for (int i = first.Length - 1, j = second.Length - 1, k = Math.Max(first.Length, second.Length) - 1; (i >= 0) && (j >= 0); i--, j--, k--)
            {
                sum[k] = first[i] * second[j];
            }
            if (Math.Min(first.Length, second.Length) == first.Length)
            {
                for (int i = second.Length - first.Length - 1; i >= 0; i--)
                {
                    sum[i] = second[i];
                }
            }
            PrintPolinomial(sum);
        }
        static void SubstractionOfPolinomials(int[] first, int[] second)
        {

            int[] sum = new int[Math.Max(first.Length, second.Length)];
            for (int i = first.Length - 1, j = second.Length - 1, k = Math.Max(first.Length, second.Length) - 1; (i >= 0) && (j >= 0); i--, j--, k--)
            {
                sum[k] = first[i] - second[j];
            }
            if (Math.Min(first.Length, second.Length) == first.Length)
            {
                for (int i = second.Length - first.Length - 1; i >= 0; i--)
                {
                    sum[i] = second[i];
                }
            }
            PrintPolinomial(sum);
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
            Console.WriteLine("The polinomial looks like:");
            PrintPolinomial(firstPolinomial);
            Console.WriteLine();
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
            Console.WriteLine("The polinomial looks like:");
            PrintPolinomial(secondPolinomial);
            Console.WriteLine("\n");
            Console.WriteLine("The sum of the two polinomials looks like:");
            AddPolinomials(firstPolinomial, secondPolinomial);
            Console.WriteLine("\n");
            Console.WriteLine("The product of the two polinomials looks like:");
            ProductOfPolinomials(firstPolinomial, secondPolinomial);
            Console.WriteLine("\n");
            Console.WriteLine("The substraction of the two polinomials looks like:");
            SubstractionOfPolinomials(firstPolinomial, secondPolinomial);
        }
    }
}
