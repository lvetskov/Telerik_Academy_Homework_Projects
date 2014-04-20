using System;
//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
    class PrintNumberSequence
    {
        static void Main()
        {
            int value = 2;
            int alternator = -1;
            for (int i = 1; i <= 10; i++)
			{
			    System.Console.Write(value);
                System.Console.Write(" ");
                value = Math.Abs(value);
                value = value + 1;
                value = value * alternator;
                alternator = alternator * (-1);
			}
            
        }
    }

