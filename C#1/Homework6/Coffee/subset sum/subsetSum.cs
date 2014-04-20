using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subset_sum
{
    class subsetSum
    {
        static void Main(string[] args)
        {
            long s = long.Parse(Console.ReadLine());
            if (s < -21392000000000 || s > 21392000000000)
            {
                Environment.Exit(0);
            }
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 16)
            {
                Environment.Exit(0);
            }
            long[] numbers = new long[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
                if (numbers[i] < -1337000000000 || numbers[i] > 1337000000000)
                {
                    Environment.Exit(0);
                }
            }
// ---------------------------------------------------------------
            int combos = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i!=j)
                    {
                          if (numbers[i] == numbers[j])
                          {
                             combos++;
                          }
                    }
                  
                }
                
            }
            Console.WriteLine(combos);

        }
    }
}
