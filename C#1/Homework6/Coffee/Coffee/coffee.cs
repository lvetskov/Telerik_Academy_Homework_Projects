using System;

namespace Coffee
{
    class coffee
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            if (n1<0 && n1>10000)
            {
                Environment.Exit(0);
            }
            int n2 = int.Parse(Console.ReadLine());
            if (n2 < 0 && n2 > 10000)
            {
                Environment.Exit(0);
            }
            int n3 = int.Parse(Console.ReadLine());
            if (n3 < 0 && n3 > 10000)
            {
                Environment.Exit(0);
            }
            int n4 = int.Parse(Console.ReadLine());
            if (n4 < 0 && n4 > 10000)
            {
                Environment.Exit(0);
            }
            int n5 = int.Parse(Console.ReadLine());
            if (n5 < 0 && n5 > 10000)
            {
                Environment.Exit(0);
            }
            double money = double.Parse(Console.ReadLine());
            if (money < 0.5 && money > 10000)
            {
                Environment.Exit(0);
            }
            double price = double.Parse(Console.ReadLine());
            if (price < 0.5 && price > 10000)
            {
                Environment.Exit(0);
            }
            //case 2
            double sum = (double)n1*0.05+(double)n2*0.1+(double)n3*0.20+(double)n4*0.5+(double)n5*1;
        //    Console.WriteLine(sum);
            if (price>money)
            {
                Console.WriteLine("More {0:F2}", price-money);
                Environment.Exit(0);
            }
            //case 1
            if (money>=price && (sum-(money-price)>=0))
             {
                Console.WriteLine("Yes {0:F2}", sum-(money-price));
                Environment.Exit(0);
             }
            //case3
            if (money >= price && (sum - (money - price) < 0))
            {
                Console.WriteLine("No {0:F2}", Math.Abs(sum - (money - price)));
                Environment.Exit(0);
            }
        }
    }
}
