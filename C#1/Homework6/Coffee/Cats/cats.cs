using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats
{
    class cats
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n<1 || n>100000)
            {
                Environment.Exit(0);
            }
            int[] cats = new int[n];
            int score = 0;
            for (int i = 1; i <= n; i++)
            {   
                score = int.Parse(Console.ReadLine());
                if (score < 1 || score > 10)
                {
                    Environment.Exit(0);
                }
                cats[score] = cats[score] + 1;
//                Console.WriteLine("array value {0}",cats[score]);
            }
            int c = cats.Max();
            for (int i = 1; i < n; i++)
            {
                if (c==cats[i])
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
