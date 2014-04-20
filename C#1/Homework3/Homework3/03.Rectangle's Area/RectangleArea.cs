using System;

namespace _03.Rectangle_s_Area
{
    //Write an expression that calculates rectangle’s area by given width and height.

    class RectangleArea
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rectangle's height:");
            int h = int.Parse(Console.ReadLine());
            if (h <= 0)
            {
                Console.WriteLine("The number has to be positive");
                Environment.Exit(0); ;
            }
            Console.Write("Enter rectangle's widht:");
            int b = int.Parse(Console.ReadLine());
            if (b <= 0)
            {
                Console.WriteLine("The number has to be positive");
                Environment.Exit(0); ;
            }
            double area = h * b;
            Console.WriteLine("The rectangles area is {0}", area);
        }
    }         
}
