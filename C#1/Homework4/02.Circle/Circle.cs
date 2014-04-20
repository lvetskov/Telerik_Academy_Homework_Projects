using System;

namespace _02.Circle
{
    class Circle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter circle's radius:");
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * r * Math.PI;
            Console.WriteLine("The perimeter is: {0:F2}", perimeter);
            double area = r * r * Math.PI;
            Console.WriteLine("The area is: {0:F2}", area);
        }
    }
}
