using System;
//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

public class Test
{
    public static void Main()
    {
        int[] myArray = new int[20];
        for (int i = 0; i < 20; i++)
        {
            myArray[i] = i * 5;
            Console.WriteLine("Element {0} = {1}", i, myArray[i]);
        }
    }
}