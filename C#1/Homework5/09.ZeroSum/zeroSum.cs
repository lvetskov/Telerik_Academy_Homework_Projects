using System;

namespace _09.ZeroSum
{
    class zeroSum
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number:");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fourth number:");
            int fourth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sixth number:");
            int fifth = int.Parse(Console.ReadLine());
          


            if (first + second + third + fourth + fifth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1}, {2}, {3}, {4}", first, second, third, fourth, fifth);
            }

            if (second + third + fourth + fifth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1}, {2}, {3} ", second, third, fourth, fifth);
            }
            if (first + third + fourth + fifth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1}, {2}, {3} ", first, third, fourth, fifth);
            }
            if (first + second + fourth + fifth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1}, {2}, {3} ", first, second, fourth, fifth);
            }
            if (first + second + third + fifth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1}, {2}, {3} ", first, second, third, fifth);
            }
            if (first + second + third + fourth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1}, {2}, {3} ", first, second, third, fourth);
            }


            if (third + fourth + fifth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1}, {2} ", third, fourth, fifth);
            }
            if (second + fourth + fifth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1}, {2} ", second, fourth, fifth);
            }
            if (first + fourth + fifth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1}, {2} ", first, fourth, fifth);
            }
            if (second + third + fifth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1}, {2} ", second, third, fifth);
            }
            if (first + third + fifth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1}, {2} ", first, third, fifth);
            }
            if (first + second + fifth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1}, {2} ", first, second, fifth);
            }
            if (second + third + fourth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1}, {2} ", second, third, fourth);
            }
            if (first + third + fourth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1}, {2} ", first, third, fourth);
            }
            if (first + second + fourth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1}, {2} ", first, second, fourth);
            }
            if (first + second + third == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1}, {2} ", first, second, third);
            }


            if (fourth + fifth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1} ", fourth, fifth);
            }
            if (third + fifth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1} ", third, fifth);
            }
            if (second + fifth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1} ", second, fifth);
            }
            if (first + fifth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1} ", first, fifth);
            }
            if (third + fourth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1} ", third, fourth);
            }
            if (second + fourth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1} ", second, fourth);
            }
            if (first + fourth == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1} ", first, fourth);
            }
            if (second + third == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1} ", second, third);
            }
            if (first + third == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1} ", first, third);
            }
            if (first + second == 0)
            {
                Console.WriteLine("The subset whos sum is zero is: {0}, {1} ", first, second);
            }
        }
    }
}