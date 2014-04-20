using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    //Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns: ");
            int columns = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, columns];
            Console.WriteLine("The matrix is: \n");
            //generating randon matrix from the previous problem
            if (columns > rows)    //1st main condition out of 3                                                                ///
            {                                                                                                                   ///
                int counter = 2;                                                                                                ///
                matrix[rows - 1, 0] = 1;                                                                                        ///
                for (int step = 1; step <= rows - 1; step++)                                                                    ///
                {                                                                                                               ///
                    int column = 0;                                                                                             ///
                    int row = rows - 1 - step;                                                                                  ///
                    for (int subStep = 0; subStep <= step; subStep++)                                                           ///
                    {                                                                                                           ///
                        matrix[row, column] = counter;                                                                          ///
                        row++;                                                                                                  ///
                        column++;                                                                                               ///
                        counter++;                                                                                              ///
                        if (row == rows)                                                                                        ///
                        {                                                                                                       ///
                            break;                                                                                              ///
                        }                                                                                                       ///
                    }                                                                                                           ///
                }                                                                                                               ///
                for (int blankColumns = 1; blankColumns < columns - rows; blankColumns++)                                       ///
                {                                                                                                               ///
                    for (int row = 0; row <= rows - 1; row++)                                                                   ///
                    {                                                                                                           ///
                        matrix[row, blankColumns + row] = counter;                                                              ///
                        counter++;                                                                                              ///
                    }                                                                                                           ///
                }                                                                                                               ///
                for (int blankColumns = columns - rows, counter2 = 0; blankColumns < columns; blankColumns++, counter2++)       ///
                {                                                                                                               ///
                    int columnsRight = blankColumns;                                                                            ///
                    for (int row = 0; row <= rows - 1 - counter2; row++)                                                        ///
                    {                                                                                                           ///
                        matrix[row, columnsRight] = counter;                                                                    ///
                        if (columnsRight < columns - 1)                                                                         ///
                        {                                                                                                       ///
                            columnsRight++;                                                                                     ///
                        }                                                                                                       ///
                        counter++;                                                                                              ///
                    }                                                                                                           ///
                }                                                                                                               ///
            }                                                                                                                   ///
            if (columns < rows)    //2nd main condition out of 3                                                                ///
            {                                                                                                                   ///
                int counter = 2;                                                                                                ///
                matrix[rows - 1, 0] = 1;                                                                                        ///
                for (int step = 1; step <= columns - 1; step++)                                                                 ///
                {                                                                                                               ///
                    int column = 0;                                                                                             ///
                    int row = rows - 1 - step;                                                                                  ///
                    for (int subStep = 0; subStep <= step; subStep++)                                                           ///
                    {                                                                                                           ///
                        matrix[row, column] = counter;                                                                          ///
                        row++;                                                                                                  ///
                        column++;                                                                                               ///
                        counter++;                                                                                              ///
                        if (row == rows)                                                                                        ///
                        {                                                                                                       ///
                            break;                                                                                              ///
                        }                                                                                                       ///
                    }                                                                                                           ///
                }                                                                                                               ///
                for (int blankRows = rows - columns - 1; blankRows >= 0; blankRows--)                                           ///
                {                                                                                                               ///
                    for (int column = 0; column < columns; column++)                                                            ///
                    {                                                                                                           ///
                        matrix[blankRows + column, column] = counter;                                                           ///
                        counter++;                                                                                              ///
                    }                                                                                                           ///
                }                                                                                                               ///
                for (int blankColumns = 1, counter2 = 0; blankColumns <= columns - 1; blankColumns++, counter2++)               ///
                {                                                                                                               ///
                    int columnsRight = blankColumns;                                                                            ///
                    for (int row = 0; row < columns - 1; row++)                                                                 ///
                    {                                                                                                           ///
                        matrix[row, columnsRight + row] = counter;                                                              ///
                        counter++;                                                                                              ///
                        if (columnsRight + row == columns - 1)                                                                  ///
                        {                                                                                                       ///
                            break;                                                                                              ///
                        }                                                                                                       ///
                    }                                                                                                           ///
                }                                                                                                               ///
            }                                                                                                                   ///
            if (columns == rows)    //3rd main condition out of 3                                                               ///
            {                                                                                                                   ///
                int counter = 2;                                                                                                ///
                matrix[rows - 1, 0] = 1;                                                                                        ///
                for (int step = 1; step <= columns - 1; step++)                                                                 ///
                {                                                                                                               ///
                    int column = 0;                                                                                             ///
                    int row = rows - 1 - step;                                                                                  ///
                    for (int subStep = 0; subStep <= step; subStep++)                                                           ///
                    {                                                                                                           ///
                        matrix[row, column] = counter;                                                                          ///
                        row++;                                                                                                  ///
                        column++;                                                                                               ///
                        counter++;                                                                                              ///
                        if (row == rows)                                                                                        ///
                        {                                                                                                       ///
                            break;                                                                                              ///
                        }                                                                                                       ///
                    }                                                                                                           ///
                }                                                                                                               ///
                for (int blankColumns = 1, counter2 = 0; blankColumns <= columns - 1; blankColumns++, counter2++)               ///
                {                                                                                                               ///
                    int columnsRight = blankColumns;                                                                            ///
                    for (int row = 0; row < columns - 1; row++)                                                                 ///
                    {                                                                                                           ///
                        matrix[row, columnsRight + row] = counter;                                                              ///
                        counter++;                                                                                              ///
                        if (columnsRight + row == columns - 1)                                                                  ///
                        {                                                                                                       ///
                            break;                                                                                              ///
                        }                                                                                                       ///
                    }                                                                                                           ///
                }                                                                                                               ///
            }                                                                                                                   ///
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(Convert.ToString(matrix[i, j]).PadLeft(3) + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            ///
            ///end of generation
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///start of current solution
            int[,] indexMatrix = new int[rows - 2, columns - 2];
            int maxSum = 0;
            int maxSumRow = 0;
            int maxSumColumn = 0;
            for (int row = 0; row < rows - 2; row++)
            {
                for (int column = 0; column < columns - 2; column++)
                {
                    int sum = 0;
                    for (int summingRow = row; summingRow < row + 3; summingRow++)
                    {
                        for (int summingColumn = column; summingColumn < column + 3; summingColumn++)
                        {
                            sum += matrix[summingRow, summingColumn];
                            if (sum > maxSum)
                            {
                                maxSum = sum;
                                maxSumRow = summingRow;
                                maxSumColumn = summingColumn;
                            }
                        }
                    }
                    indexMatrix[row, column] = sum;
                }
            }
            Console.WriteLine("The matrix of the sums is:\n");
            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < columns - 2; j++)
                {
                    Console.Write(Convert.ToString(indexMatrix[i, j]).PadLeft(3) + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("\nThe maximum sum is: {0}", maxSum);
            Console.WriteLine("The sub-matrix with maximum sum is:");
            for (int summingRow = maxSumRow - 2; summingRow <= maxSumRow; summingRow++)
            {
                for (int summingColumn = maxSumColumn - 2; summingColumn <= maxSumColumn; summingColumn++)
                {
                    Console.Write(Convert.ToString(matrix[summingRow, summingColumn]).PadLeft(3) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
