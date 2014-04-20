using System;

namespace alternatingNumbers
{
    class alternatingNumbers
    {
        //Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            decimal charge = 1;
            for (decimal i = 1; i <= n; i++)
            {
                sum = sum + charge / i;
                if (i >= 2)
                {
                    charge *= -1; 
                }
                Console.WriteLine("{0:F3}",sum);

            }
            
        }
    }
}
