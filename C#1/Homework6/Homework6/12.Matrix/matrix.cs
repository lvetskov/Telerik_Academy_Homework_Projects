using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Matrix
{
    class matrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N<20:");         
            int n = int.Parse(Console.ReadLine());
            if (n >= 20)
            {
                Console.WriteLine("N has to be lesser than 20!");
                Environment.Exit(0);
            }
            for (int i = 1; i <= n; i++)
            {
                for (int k = i; k < n+i; k++)
                {
                    Console.Write(Convert.ToString(k).PadLeft(3,' '));
                }
                Console.WriteLine();
                
            }
        }
    }
}
