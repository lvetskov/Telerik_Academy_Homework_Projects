using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestRoad
{
    class ForestRoad
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < 2*n-1; i++)
            {
                if (counter == n)
                {
                    break;
                }
                for (int j = 0; j < n; j++)
                {
                    if (j == counter)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();

                counter++;
            }
            counter = 2;
            for (int i = 2 * n - 1; i>0; i--)
            {
                if (counter == n+1)
                {
                    break;
                }
                for (int j = n; j > 0; j--)
                {
                    if (j == counter)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                counter++;
                Console.WriteLine();
            }

        }
    }
}
