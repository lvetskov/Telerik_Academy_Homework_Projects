using System;

namespace _06.QuadraticEquation
{
    class quadraticEquation
    {
        static void Main()
        {
            Console.Write("Enter a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter c:");
            int c = int.Parse(Console.ReadLine());
            double det = b * b - 4 * a * c;
            det = Math.Sqrt(det);
            double rootOne = (-(double)b + det) / 2;
            Console.WriteLine("First root: {0}", rootOne);
            double rootTwo = (-(double)b - det) / 2;
            Console.WriteLine("Second root: {0}", rootTwo);
        }
    }
}
