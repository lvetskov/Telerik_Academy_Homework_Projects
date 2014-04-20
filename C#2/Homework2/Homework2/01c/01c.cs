using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01c
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
            
            
            if (columns > rows)    //1st main condition out of 3
            {
                int counter = 2;
                matrix[rows - 1, 0] = 1;
                for (int step = 1; step <= rows - 1; step++)                             
                {                                                                        
                    int column = 0;                                                      
                    int row = rows - 1 - step;                                           
                    for (int subStep = 0; subStep <= step; subStep++)                    
                    {                                                                    
                        matrix[row, column] = counter;                                   
                        row++;                                                           
                        column++;                                                        
                        counter++;                                                       
                        if (row == rows)                                                 
                        {                                                                
                            break;                                                       
                        }                                                                
                    }                                                                    
                }                                                                        
                for (int blankColumns = 1; blankColumns < columns - rows; blankColumns++)
                {
                    for (int row = 0; row <= rows - 1; row++)
                    {
                        matrix[row, blankColumns + row] = counter;
                        counter++;
                    }
                }
                for (int blankColumns = columns - rows, counter2 = 0; blankColumns < columns; blankColumns++, counter2++)
                {
                    int columnsRight = blankColumns;
                    for (int row = 0; row <= rows - 1 - counter2; row++)
                    {
                        matrix[row, columnsRight] = counter;
                        if (columnsRight < columns - 1)
                        {
                            columnsRight++;
                        }
                            counter++;
                    }
                }
            }
            if (columns < rows)    //2nd main condition out of 3
            {
                int counter = 2;
                matrix[rows - 1, 0] = 1;
                for (int step = 1; step <= columns - 1; step++)
                {
                    int column = 0;
                    int row = rows - 1 - step;
                    for (int subStep = 0; subStep <= step; subStep++)
                    {
                        matrix[row, column] = counter;
                        row++;
                        column++;
                        counter++;
                        if (row == rows)
                        {
                            break;
                        }
                    }
                }
                for (int blankRows = rows - columns - 1; blankRows >= 0; blankRows--)
                {
                    for (int column = 0; column < columns; column++)
                    {
                        matrix[blankRows + column, column] = counter;
                        counter++;
                    }
                }
                for (int blankColumns = 1, counter2 = 0; blankColumns <= columns - 1; blankColumns++, counter2++)
                {
                    int columnsRight = blankColumns;
                    for (int row = 0; row < columns - 1; row++)
                    {
                        matrix[row, columnsRight + row] = counter;
                        counter++;
                        if (columnsRight + row == columns - 1)
                        {
                            break;
                        } 
                    }
                }
            }
            if (columns == rows)    //3rd main condition out of 3
            {
                int counter = 2;
                matrix[rows - 1, 0] = 1;
                for (int step = 1; step <= columns - 1; step++)
                {
                    int column = 0;
                    int row = rows - 1 - step;
                    for (int subStep = 0; subStep <= step; subStep++)
                    {
                        matrix[row, column] = counter;
                        row++;
                        column++;
                        counter++;
                        if (row == rows)
                        {
                            break;
                        }
                    }
                }
                for (int blankColumns = 1, counter2 = 0; blankColumns <= columns - 1; blankColumns++, counter2++)
                {
                    int columnsRight = blankColumns;
                    for (int row = 0; row < columns - 1; row++)
                    {
                        matrix[row, columnsRight + row] = counter;
                        counter++;
                        if (columnsRight + row == columns - 1)
                        {
                            break;
                        }
                    }
                }
            }
            //printing sequence
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(Convert.ToString(matrix[i, j]).PadLeft(3) + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            
        }
    }
}


