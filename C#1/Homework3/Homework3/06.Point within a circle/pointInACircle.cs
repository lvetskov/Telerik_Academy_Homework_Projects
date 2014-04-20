using System;

namespace _06.Point_within_a_circle
{
    class pointInACircle
    {
        static void Main()
        {
            Console.Write("Enter the X coordinate to be checked:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter the Y coordinate to be checked:");
            double y = double.Parse(Console.ReadLine());
            //Pitagor
            double help = Math.Pow(Math.Abs(x),2) + Math.Pow(Math.Abs(y),2);
            double R = Math.Pow(help, 0.5);
            if (R<=5)
            
            {
                Console.WriteLine("The point is within the circle");
            }
            else
            {
                Console.WriteLine("The point is outside the circle");
            }
        }
    }
}
