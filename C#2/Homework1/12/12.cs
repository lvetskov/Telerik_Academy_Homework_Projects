using System;
//Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.

public class Test
{
    public static void Main()
	{
		char[] alphabet = new char[26];
		int letter = 65;
		for (int i=0; i<alphabet.Length; i++)                 //
		{                                                     //
			alphabet[i] = Convert.ToChar(letter);             //assigning capital letters to the array
			letter++;                                         //
		}                                                     //
        Console.WriteLine("Enter a word :");
		string word = Console.ReadLine();
		for	(int i = 0; i<word.Length; i++)
		{
			for (int j = 0; j< alphabet.Length; j++)
			{
				if(word[i]==alphabet[j])
				{
					Console.WriteLine("{0} = {1}", word[i] , (int)alphabet[j]);
				}
			}
			
		}
	}
}