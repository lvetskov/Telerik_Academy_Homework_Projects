using System;

namespace _08.Trapezoid_Area
{
    class TrapezoidArea
    {
        static void Main()
        {
            Console.Write("Enter side a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter height h:");
            double h = double.Parse(Console.ReadLine());
            double area = (a + b) * h / 2;
            Console.WriteLine("The are is {0}", area);
        }
    }
}
