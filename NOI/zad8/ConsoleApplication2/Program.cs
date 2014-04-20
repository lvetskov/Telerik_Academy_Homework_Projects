using System;

namespace ConsoleApplication1
{
    class Program
    {
        static int totalSum = 0;

        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string[] input = inputString.Split(' ');
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row <= rows - 1; row++)
            {
                string colAsString = Console.ReadLine();
                string[] colAsStringArray = colAsString.Split(' ');
                for (int col = 0; col <= cols - 1; col++)
                {
                    matrix[row, col] = int.Parse(colAsStringArray[col]);
                }
            }
            //Console.WriteLine();

            //for (int i = 0; i <= rows - 1; i++)
            //{
            //    for (int j = 0; j <= cols - 1; j++)
            //    {
            //        Console.Write(matrix[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            totalSum = matrix[0, 0];
            int[,] matrixJoro = new int[rows, cols];
            matrixJoro[0, 0] = matrix[0, 0];

            for (int i = 1; i <= cols - 1; i++)                              //
            {                                                                //
                matrixJoro[0, i] = matrixJoro[0, i - 1] + matrix[0, i];      //
            }                                                                //row 0 and col 0 done!
            for (int i = 1; i <= rows - 1; i++)                              //
            {                                                                //
                matrixJoro[i, 0] = matrixJoro[i - 1, 0] + matrix[i, 0];      //
            }                                                                //
            int joroMaxValue = 0;
            for (int i = 1; i <= rows - 1; i++)
            {
                for (int j = 1; j <= cols - 1; j++)
                {
                    if (matrixJoro[i, j - 1] >= matrixJoro[i - 1, j])
                    {
                        matrixJoro[i, j] = matrixJoro[i, j - 1] + matrix[i, j];
                    }
                    else
                    {
                        matrixJoro[i, j] = matrixJoro[i - 1, j] + matrix[i, j];
                    }
                    if (matrixJoro[i, j] > joroMaxValue)
                    {
                        joroMaxValue = matrixJoro[i, j];
                    }
                }
            }
            totalSum = joroMaxValue;
            Console.WriteLine(totalSum);


            Console.WriteLine();
            for (int i = 0; i <= rows - 1; i++)
            {
                for (int j = 0; j <= cols - 1; j++)
                {
                    Console.Write(matrixJoro[i, j] + "  ");
                }
                Console.WriteLine();
            }
            //--------------------------------------------------------------------------------
            
            int a = rows - 1;
            int b = cols - 1;
            matrix[a, b] = -1;
            while (true)
            {
                if (matrix[a - 1, b] > matrix[a, b - 1])
                {
                    matrix[a - 1, b] = -1;
                    a--;
                }
                else
                {
                    matrix[a, b - 1] = -1;
                    b--;
                }
                if (a==0)
                {
                    for (int i = b; i >= 0; i--)
                    {
                        matrix[a, i] = -1;
                    }
                    break;
                }
                if (b==0)
                {
                    for (int i = a; i >=0 ; i--)
                    {
                        matrix[i, b] = -1;
                    }
                    break;
                }
            }


            Console.WriteLine();
            for (int i = 0; i <= rows - 1; i++)
            {
                for (int j = 0; j <= cols - 1; j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }


            for (int i = 1; i <= cols - 1; i++)
            {
                if (matrix[0, i] == -1)
                {
                    continue;
                }
                else
                {
                    if (matrix[0, i - 1] == -1)
                    {
                        continue;
                    }
                    else
                    {
                        matrix[0, i] += matrix[0, i - 1];
                    }
                }
            }
            for (int i = 1; i <= rows - 1; i++)
            {
                if (matrix[i, 0] == -1)
                {
                    continue;
                }
                else
                {
                    if (matrix[i - 1, 0] == -1)
                    {
                        continue;
                    }
                    else
                    {
                        matrix[i, 0] += matrix[i - 1, 0];
                    }
                }
            }
            int goshoRow = 1;
            int goshoCol = 1;
            int goshoMaxValue = 0;
            while (goshoRow <= rows - 1)
            {
                while (goshoCol <= cols - 1)
                {
                    if (matrix[goshoRow, goshoCol] != -1)
                    {
                        if (matrix[goshoRow, goshoCol - 1] <= matrix[goshoRow - 1, goshoCol])
                        {
                            matrix[goshoRow, goshoCol] = matrix[goshoRow, goshoCol] + matrix[goshoRow - 1, goshoCol];
                        }
                        else
                        {
                            matrix[goshoRow, goshoCol] = matrix[goshoRow, goshoCol] + matrix[goshoRow, goshoCol - 1];
                        }
                        if (matrix[goshoRow, goshoCol] > goshoMaxValue)
                        {
                            goshoMaxValue = matrix[goshoRow, goshoCol];
                        }
                    }
                    goshoCol++;
                }
                goshoCol = 1;
                goshoRow++;
            }
            totalSum += goshoMaxValue;

            Console.WriteLine();
            for (int i = 0; i <= rows - 1; i++)
            {
                for (int j = 0; j <= cols - 1; j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(totalSum);
        }
    }
}
