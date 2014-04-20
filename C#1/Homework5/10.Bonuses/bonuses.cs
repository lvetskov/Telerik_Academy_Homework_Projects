using System;

namespace _10.Bonuses
{
    class bonuses
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number=-1;
            bool check = Int32.TryParse(Console.ReadLine(), out number);
            Console.WriteLine(check);
            if (check && (number!=0))
            {
                Console.WriteLine("The input is a digit");
            }
            else if (check && (number==0))
            {
                Console.WriteLine("The input is zero!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("The input is not a digit!");
                Environment.Exit(0);
            }

            switch (number)
            {
                case 1: number *= 10; break;
                case 2: number *= 10; break;
                case 3: number *= 10; break;
                case 4: number *= 100; break;
                case 5: number *= 100; break;
                case 6: number *= 100; break;
                case 7: number *= 1000; break;
                case 8: number *= 1000; break;
                case 9: number *= 1000; break;
                default:
                    {
                        Console.WriteLine("Enter a digit between 1 and 9");
                        Environment.Exit(0);
                        break;
                    }
            }
            Console.WriteLine(number);

        }

    }
}
