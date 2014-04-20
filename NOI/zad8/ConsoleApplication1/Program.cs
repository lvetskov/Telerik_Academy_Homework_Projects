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
            matrix[0, 0] = -1;
            int a = 0;
            int b = 0;
            while (true)
            {
                if (a >= rows - 1)
                {
                    for (int i = b; i <= cols - 1; i++)
                    {
                        matrix[a, i] = -1;
                    }
                    break;
                }
                if (b >= cols - 1)
                {
                    for (int i = a; i <= rows - 1; i++)
                    {
                        matrix[i, b] = -1;
                    }
                    break;
                }
                if (matrixJoro[a, b + 1] >= matrixJoro[a + 1, b])
                {
                    matrix[a, b + 1] = -1;
                    b++;
                }
                else
                {
                    matrix[a + 1, b] = -1;
                    a++;
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

            int[,] matrixGosho = new int[rows, cols];
            matrixGosho[0, 0] = -1;
            if (matrix[1, 0] == -1)
            {
                for (int i = 2; i <= cols - 1; i++)
                {
                    matrix[0, i] = matrix[0, i - 1] + matrix[0, i];
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
            }
            else
            {
                for (int i = 2; i <= rows - 1; i++)
                {
                    matrix[i, 0] = matrix[i - 1, 0] + matrix[i, 0];
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
                            if (matrix[goshoRow - 1, goshoCol] <= matrix[goshoRow, goshoCol - 1])
                            {
                                matrix[goshoRow, goshoCol] = matrix[goshoRow, goshoCol] + matrix[goshoRow, goshoCol - 1];
                            }
                            else
                            {
                                matrix[goshoRow, goshoCol] = matrix[goshoRow, goshoCol] + matrix[goshoRow - 1, goshoCol];
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
            Console.WriteLine(totalSum);
        }
    }
}
