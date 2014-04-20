using System;

namespace _07.nSum
{
    class nSum
    {
        static void Main()
        {
            Console.WriteLine("Enter first n numbers:");
            int n1 = int.Parse(Console.ReadLine());
            int sum = 0;
            int n = 0;
            for (int i = 0; i < n1; i++)
            {
                n = int.Parse(Console.ReadLine());
                sum += n;
            }
            Console.WriteLine("Enter second n numbers:");
            int n2 = int.Parse(Console.ReadLine());
            n = 0;
            for (int i = 0; i < n2; i++)
            {
                n = int.Parse(Console.ReadLine());
                sum += n;
            }
            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
