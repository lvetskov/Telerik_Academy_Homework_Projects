﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns: ");
            int columns = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, columns];
            int counter = 1;
            for (int column = 0; column < columns; column++)
            {
                for (int row = 0; row < rows; row++)
                {
                    matrix[row, column] = counter;
                    counter++;
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    Console.Write(Convert.ToString(matrix[row, column]).PadLeft(3) + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
