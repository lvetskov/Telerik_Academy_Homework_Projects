using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char i = '2';
            int a = i - '0';

            Console.WriteLine(a+1);
            string b = int.Parse(Console.ReadLine());
            Console.WriteLine(b);
        }
    }
}
