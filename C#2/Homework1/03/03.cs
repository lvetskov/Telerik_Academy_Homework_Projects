using System;
//Write a program that compares two char arrays lexicographically (letter by letter).

public class Test
{
    public static void Main()
	{
		char[] arrayOne = new char[100];
		char[] arrayTwo = new char[100];
		Console.WriteLine("Enter number of elements for the arrays:");
		bool invalid = true;
		int n = 0;
		invalid = int.TryParse(Console.ReadLine(), out n);
		arrayOne = new char[n];
		arrayTwo = new char[n];
		Console.WriteLine("Enter elements of array one:");
		for (int i=0; i<n; i++)
		{
			Console.Write("ArrayOne N{0}=", i);
			arrayOne[i] = char.Parse(Console.ReadLine());
		}
		Console.WriteLine("Enter elements of array two:");
		for (int i=0; i<n; i++)
		{
			Console.Write("ArrayTwo N{0}=", i);
			arrayTwo[i] = char.Parse(Console.ReadLine());
		}
		Console.WriteLine();
		Console.WriteLine("Ar1 vs Ar2");
		bool comparison = false;
		for (int i=0; i<n; i++)
		{
            comparison = false;
            if (arrayOne[i] == arrayTwo[i])
            {
                comparison = true;
            }
            Console.Write(" {0}  ?=  {1}   {2}", arrayOne[i], arrayTwo[i], comparison);
            Console.WriteLine();		
		}

		
	}
}