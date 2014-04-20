using System;

namespace _05.GreaterNumber
{
    //Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

    class greaterNumber
    {
        static void Main()
        {
            Console.Write("Enter the number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(a, b));
        }
    }
}
