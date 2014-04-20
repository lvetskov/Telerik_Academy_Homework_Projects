using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//01.Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Implement the ToString() to enable printing a 3D point.
//02.Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. Add a static property to return the point O.
//03.Write a static class with a static method to calculate the distance between two points in the 3D space.
//04.Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.
//05.Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString(). Check all input parameters to avoid accessing elements at invalid positions.
//06.Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
//07.Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. You may need to add a generic constraints for the type T.
//08.Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 

namespace Homework02
{
    class Program
    {
        static void Main()
        {
            Path p = new Path();
            p.AddPoint(new Point3D(1, 2, 3));
            p.AddPoint(new Point3D(5, 2, 6));
            p.AddPoint(new Point3D(1, 3, 5));
            p.AddPoint(new Point3D(-5, 2, 3));
            p.AddPoint(new Point3D(-2, -10, 3));

            PathStorage.SavePath(p); //Save path in file savedPaths.txt
            Path final = PathStorage.LoadPath(); //loading from the file savedPaths.txt
            final.PrintPathList(); //printing the loaded path

            ////05, 06, 07->

            GenericList<int> list = new GenericList<int>();
            list.AddElement(10);
            list.AddElement(5);
            list.AddElement(4);
            list.InsertElement(1, 15);
            list.InsertElement(1, 12);
            Console.WriteLine(list.ToString());
            Console.WriteLine();
            list[0] = 5;
            int min = list.Min();
            int max = list.Max();
            Console.WriteLine(min);
            Console.WriteLine(max);
            list.Clear();
            Console.WriteLine(list.ToString());

            /////08, 09, 10 ->

            double[,] first = { { 0, 2, 3, 4.2 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
            double[,] second = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 0, 3, 4 } };

            Matrix<double> arrFirst = new Matrix<double>(first);
            Matrix<double> arrSecond = new Matrix<double>(second);

            //checking if contain zero, return true, if not, return false if there is zero
            if (arrFirst)
            {
                Console.WriteLine("There is no zero inside");
            }
            else Console.WriteLine("There is at least one zero inside\n");
            //-----------
            Console.WriteLine("Sum of the two matrices");
            Console.WriteLine(arrFirst + arrSecond);
            Console.WriteLine("Substraction of the two matrices");
            Console.WriteLine(arrFirst - arrSecond);
            Console.WriteLine("Multiplication of the two matrices");
            Console.WriteLine(arrFirst * arrSecond);
        }
    }
}
