using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall_Down
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = new char[8, 8];
            byte[] numbers = new byte[8];
            string numberInHex;
            for (int i = 0; i < 8; i++)
            {
                numbers[i] = byte.Parse(Console.ReadLine());
                numberInHex = Convert.ToString(numbers[i], 2).PadLeft(8, '0');
                //            Console.WriteLine(numberInHex);
                for (int j = 0; j < 8; j++)
                {
                    matrix[i, j] = numberInHex[j];
                }

            }
    //        Console.WriteLine("-------------");
            
            int[,] matrix2 = new int[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    matrix2[i,j] = (int)(matrix[i,j] - '0');
                }
            }
     //       for (int i = 0; i < 8; i++)
     //       {
     //           for (int j = 0; j < 8; j++)
     //           {
     //               Console.Write("{0} ", matrix[i, j]);
     //           }
     //           Console.WriteLine();
     //       }
      //      Console.WriteLine("----------------------");


            for (int k = 0; k < 8; k++)
            {
                for (int i = 7; i > 0; i--)
                {
                    for (int j = 7; j >= 0; j--)
                    {

                        if (matrix2[i, j] == 0 && matrix2[i - 1, j] == 1)
                        {
                            matrix2[i, j] = 1;
                            matrix2[i - 1, j] = 0;
                        }
                    }
                }
            }






    //                for (int i = 0; i < 8; i++)
    //                {
    //                    for (int j = 0; j < 8; j++)
    //                    {
    //                        Console.Write("{0} ", matrix2[i, j]);
    //                    }
    //                    Console.WriteLine();
    //                }
    //        Console.WriteLine("-----------");
            string[] tetrisNumber = new string[8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tetrisNumber[i] += Convert.ToString(matrix2[i, j]);
                }
                Console.WriteLine(Convert.ToInt32(tetrisNumber[i],2));
            }


            
    


            
        }
    }
}
