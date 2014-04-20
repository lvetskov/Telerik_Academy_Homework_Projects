using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_Trolls
{
    class diamondTrolls
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n%2==0)
            {
                Environment.Exit(0);
            }
            int upperRows = 2;
            for (int i = 3; i < n; i+=2)
            {
                upperRows += 1;
            }
            int nUpperRows = upperRows;
            Console.Write(new string('.', nUpperRows));
            Console.Write(new string('*', nUpperRows - 1));
            Console.Write('*');
            Console.Write(new string('*', nUpperRows - 1));
            Console.Write(new string('.', nUpperRows));
            Console.WriteLine();
            int j = upperRows-1;
            for (int i = 0; i < upperRows-1; i++,nUpperRows--)
            {
                Console.Write(new string('.', nUpperRows - 1));
                Console.Write('*');
                Console.Write(new string ('.', j));
                Console.Write('*');
                Console.Write(new string('.', j));
                Console.Write('*');
                Console.Write(new string('.', nUpperRows - 1));
                j++;
                Console.WriteLine();
            }
            Console.WriteLine(new string ('*', 2*n+1));
            j = n - 2;
            for (int i = 1; i <= n-1; i++, j--)
            {
                Console.Write(new string('.', i));
                Console.Write('*');
                Console.Write(new string('.', j));
                Console.Write('*');
                Console.Write(new string('.', j));
                Console.Write('*');
                Console.Write(new string('.', i));
                Console.WriteLine();
            }
            Console.Write(new string('.', n));
            Console.Write('*');
            Console.Write(new string('.', n));
            Console.WriteLine();
        }
    }
}
