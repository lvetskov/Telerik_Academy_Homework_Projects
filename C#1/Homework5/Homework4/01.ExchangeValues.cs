using System;


namespace _01_ExchangeValues
{
    class Program
    {
        //Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value:");
            int firstValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second value:");
            int secondValue = int.Parse(Console.ReadLine());
            if (firstValue > secondValue)
            {
                firstValue += secondValue;
                secondValue = firstValue - secondValue;
                firstValue = firstValue - secondValue;
                Console.WriteLine("First value is: {0}", firstValue);
                Console.WriteLine("Second value is: {0}", secondValue);
                
            }

        }
    }
}
