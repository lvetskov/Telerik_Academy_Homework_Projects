using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire
{
    class fire
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if ((n%4 !=0) || (n<4) || (n>76))
            {
                Environment.Exit(0);
            }
            int rowsUp = n / 2;
            int dot = 0;

                for (int j = rowsUp*2; j > 0; j--)
                {
                    Console.Write(new string('.', (j-2)/2));
                    Console.Write('#');
                    Console.Write(new string('.',dot));
                    dot+=2;
                    Console.Write('#');
                    Console.Write(new string('.', (j - 2) / 2));
                    Console.WriteLine();
                    if (dot > n-2)
                    {
                        Console.Write(new string('.', (j - 2) / 2));
                        Console.Write('#');
                        dot-=2;
                        Console.Write(new string('.', dot));
                        Console.Write('#');
                        Console.Write(new string('.', (j - 2) / 2));
                        Console.WriteLine();
                        break;
                    }
                    j--; 
                }
                int rowsDown = n / 4 - 1;
                int downInnerDots = n - 4;
                for (int i = 1; i <= rowsDown; i++)
                {
                    Console.Write(new string('.', (i)));
                    Console.Write('#');
                    Console.Write(new string('.', (downInnerDots)));
                    Console.Write('#');
                    Console.Write(new string('.', (i)));
                    downInnerDots -= 2;
                    Console.WriteLine();
                }
                Console.WriteLine(new string('-',n));
                int torch = n / 2;
                int slash = torch;
                int nule = 0;
                for (int i = torch; i > 0; i--)
                {
                    Console.Write(new string('.', nule));
                    Console.Write(new string('\\', slash));
                    Console.Write(new string('/', slash));
                    Console.Write(new string('.', nule));
                    Console.WriteLine();
                    nule++;
                    slash--;
                }
        }
    }
}
