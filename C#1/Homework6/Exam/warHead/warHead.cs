using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warHead
{
    class warHead
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[18, 18];
            string rowNumber;

            for (int i = 1; i < 17; i++)
            {
                rowNumber = Console.ReadLine();
                int countForText = 0;
                for (int j = 1; j < 17; j++)
                {
                    matrix[i, j] = Convert.ToInt32(rowNumber[countForText] - '0');
                    countForText++;
                }
            }
    //---------------------------------
     //       for (int i = 0; i < 16; i++)
     //       {
     //           for (int j = 0; j < 16; j++)
     //           {
     //               Console.Write(matrix[i, j]);
     //           }
     //           Console.WriteLine();
     //       }
            string[] commands = new string[100];
            int[] row = new int[100];
            int[] column = new int[100];
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 1; i < numberOfCommands; i++)
            {
                commands[i] = Console.ReadLine();
                row[i] = int.Parse(Console.ReadLine());
                column[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < 100; i++)
            {
                if (commands[i-1]=="hover")
                {
                    if (matrix[row[i],column[i]]==1)
                    {
                        Console.WriteLine('*');
                    }
                    else
                    {
                        Console.WriteLine('-');
                    }
                }
                if (commands[i-1]=="operate")
                {
                    if (matrix[row[i], column[i]] == 0)
                    {
                        if (matrix[row[i-1], column[i-1]] == 1 &&
                            matrix[row[i - 1], column[i]] == 1 &&
                            matrix[row[i - 1], column[i+1]] == 1 &&
                            matrix[row[i], column[i-1]] == 1 &&
                            matrix[row[i], column[i+1]] == 1 &&
                            matrix[row[i+1], column[i-1]] == 1 &&
                            matrix[row[i+1], column[i]] == 1 &&
                            matrix[row[i+1], column[i+1]] == 1)
                        {
                            matrix[row[i-1], column[i-1]] = 0;
                            matrix[row[i - 1], column[i]] =0;
                            matrix[row[i - 1], column[i+1]] =0;
                            matrix[row[i], column[i-1]] =0;
                            matrix[row[i], column[i+1]] =0;
                            matrix[row[i+1], column[i-1]] =0;
                            matrix[row[i+1], column[i]] =0;
                            matrix[row[i+1], column[i+1]] =0;
                        }
                    }
                    else
	                {
                        Console.WriteLine("missed");
                        int counter = 0;
                        for (int k = 1; k < 17; k++)
                        {
                            for (int m  = 1; m < 17; m++)
                            {
                                if (matrix[row[k-1], column[m-1]] == 1 &&
                                  matrix[row[k - 1], column[m]] == 1 &&
                                  matrix[row[k - 1], column[m+1]] == 1 &&
                                  matrix[row[k], column[m-1]] == 1 &&
                                  matrix[row[k], column[m+1]] == 1 &&
                                  matrix[row[k+1], column[m-1]] == 1 &&
                                  matrix[row[k+1], column[m]] == 1 &&
                                  matrix[row[k+1], column[m+1]] == 1 &&
                                  matrix[row[k], column[m]]==0)
                                {
                                    counter++;
                                }
                            }
                        }
                        Console.WriteLine(counter);
                        Console.WriteLine("BOOM");
	                }
                }
            }


        }
    }
}


