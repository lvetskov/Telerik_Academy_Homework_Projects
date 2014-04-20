using System;
using System.Text;

public class ReverseString
{
    //Write a program that reads a string, reverses it and prints the result at the console.Example: "sample"  "elpmas".

    public static string Reverse(string s)
    {
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            stringBuilder.Append(s[i]);
        }
        return stringBuilder.ToString();
    }
    public static void Main()
    {
        Console.WriteLine("Enter a string to reverse:");
        string s = Console.ReadLine();
        Console.WriteLine(Reverse(s));
    }
}