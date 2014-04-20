using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//01.Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
//02.Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
//03.Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. Use LINQ query operators.
//04.Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.



namespace Homework03
{

    class TestMain
    {
        static void Main()
        {
            //01
            Console.WriteLine("01:");
            StringBuilder stringBuilderForTest = new StringBuilder();
            stringBuilderForTest.Append("Pesho is going fishing!!!");
            Console.WriteLine(stringBuilderForTest.ToString());
            Console.WriteLine(stringBuilderForTest.Substring(6).ToString() + "\n");
            //02
            Console.WriteLine("02:");
            List<double> newList = new List<double>();
            newList.Add(1);
            newList.Add(2);
            newList.Add(3);
            newList.Add(4);
            newList.Add(5);
            Console.WriteLine("Elements:");
            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine("newList[{0}] = {1}", i, newList[i]);
            }

            //Try the Sum method
            Console.WriteLine("\nThe sum of all the elements is = {0}", newList.Sum()); //15
            //Try the Product method
            Console.WriteLine("\nThe product of all the elements is = {0}", newList.Product()); //120
            //Try the Max method
            Console.WriteLine("\nThe maximal of all the elements is = {0}", newList.Max()); //5
            //Try the Min method
            Console.WriteLine("\nThe minimal of all the elements is = {0}", newList.Min()); //1
            //Try the Average method
            Console.WriteLine("\nThe average of all the elements is = {0}", newList.Average()); //3


            //03
            Console.WriteLine("03:");
            //ARRAY DECLARATION
            Student[] studentArray = {
                                          new Student("Angel", "Kunchev"),
                                          new Student("Pesho", "Petrov"),
                                          new Student("Ivan", "Atanasov"),
                                          new Student("Ivan", "Qnkov")
                                     };
            //LINQ SELECTION
            var someStudents =
                from student in studentArray
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            foreach (var item in someStudents)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine(new string('-', 40));


            //04
            Console.WriteLine("04:");
            //Declaring Anonymous Objects!!!
            var students = new[]
    {
        new {FirstName = "Ivan", LastName = "Ivanov", Age = 18},
        new {FirstName = "Georgi",  LastName = "Simeonov", Age = 19},
        new {FirstName = "Ivan",  LastName = "Todorov", Age = 20},
        new {FirstName = "Petyr",  LastName = "Chipev", Age = 21},
        new {FirstName = "Anton",  LastName = "Donchev", Age = 22},
        new {FirstName = "Filip",  LastName = "Andreev", Age = 23},
        new {FirstName = "Svetslav",  LastName = "Bozov", Age = 28},
    };
            var sorted =
                from st in students
                where (st.Age >= 18 && st.Age <= 24)
                select (st.FirstName + " " + st.LastName);

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
