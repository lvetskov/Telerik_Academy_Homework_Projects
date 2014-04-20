using System;

namespace _04.Third_digit_check
{
    //Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

    class thirdDigitCheck
    {
        static void Main()
        {
            Console.Write("Enter the number to be checked:");
            int number = int.Parse(Console.ReadLine());
            int a = number / 100;
            int b = a % 10;
            if (b == 7)
            {
                Console.WriteLine("The third digit is 7");
            }
            else
            {
                Console.WriteLine("The third digit is not 7");
            }
        }
    }
}
