using System;
class CopyrightSymbol
{   //Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.


    static void Main()
    {
        int a = 169;
        Console.WriteLine(a);
        char symbol = Convert.ToChar(a);
        char space = ' ';
        int b = 0;
        int c = 0;
        int f = 0;
        int d = 1;
        for (int i = 4; i > 0; i--)// i - number of rows
        {
            f = 0;
            c = 0;
            b = 0;
            while (b < i)
	        {
	            Console.Write(space); 
                b++;
	        }
            for (f = 0; f < d; f++)
            {
                Console.Write(symbol + " ");
            }
            d++;
            while (c < i)
            {
                Console.Write(space); 
                c++;
            }
            Console.WriteLine();
           
        }
    }
}

