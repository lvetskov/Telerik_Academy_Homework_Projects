using System;
//* Write a program to read your age from the console and print how old you will be after 10 years.

    class ReadAge
    {
        static void Main()
        {

            System.Console.Write("Enter your age:");
            float Age = float.Parse(Console.ReadLine());
            Age = Age + 10;
            System.Console.Write("In ten years you will be at age ");
            System.Console.WriteLine(Age);

        }
    }

