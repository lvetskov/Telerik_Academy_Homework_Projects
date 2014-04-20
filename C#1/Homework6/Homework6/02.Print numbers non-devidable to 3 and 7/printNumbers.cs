using System;


namespace _02.Print_numbers_non_devidable_to_3_and_7
{
    //Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

    class printNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if ((i%3)==0 && (i%7)==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
