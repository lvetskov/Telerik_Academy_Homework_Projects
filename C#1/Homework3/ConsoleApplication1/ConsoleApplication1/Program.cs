using System;

namespace _09.Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Fibonacci end number:");
            int fibonacci = int.Parse(Console.ReadLine());
            ulong[] array = new ulong[102];
            array[0]=0;
            array[1] = 1;
            for (int i = 1; i <= fibonacci; i++)
            {
                Console.WriteLine(array[i]);
                array[i + 1] = array[i] + array[i - 1];
            }
          
         }
        
    }
}
