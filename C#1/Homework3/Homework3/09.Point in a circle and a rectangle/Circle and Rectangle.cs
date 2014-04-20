using System;

namespace _09.Point_in_a_circle_and_a_rectangle
{
    //Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

    class CircleandRectangle
    {
        static void Main()
        {
            Console.Write("Enter the X coordinate to be checked:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter the Y coordinate to be checked:");
            double y = double.Parse(Console.ReadLine());
            //Pitagor
            if ((Math.Pow((x-1),2)+Math.Pow((y-1),2))<=9)
            {
                Console.WriteLine("The point is in the circle!");
            }
            else
            {
                Console.WriteLine("The point is outside the circle!");
            }
            if (((x>=-1)&&(x<=5)) && ((y<=1)&&(y>=-1)))
            {
                Console.WriteLine("The point is inside the rectangle!"); 
            }
            else
            {
                Console.WriteLine("The point is outside the rectangle!");
            }
       }
   }
}
