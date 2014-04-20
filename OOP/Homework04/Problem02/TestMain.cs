using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class TestMain
    {

        static void Main()
        {
            Student student1 = new Student("Pesho", "Draganov", 2);
            Student student2 = new Student("Ivan", "Mitkov", 4);
            Student student3 = new Student("Dimitar", "Peshev", 5);
            Student student4 = new Student("Gosho", "Ivanov", 6);
            Student student5 = new Student("Petio", "Peshev", 6);
            Student student6 = new Student("Dragan", "Petkanov", 6);
            Student student7 = new Student("Kiro", "Peshev", 5);
            Student student8 = new Student("Asen", "Apeshev", 4);
            Student student9 = new Student("Petkan", "Beshev", 4);
            Student student10 = new Student("Pesho", "Zeshev", 3);
            List<Student> students = new List<Student>{student1, student2, student3,
            student4, student5, student6, student7, student8, student9, student10};
           
            // order students by grade
            var orderByGrade = students.OrderBy(x => x.Grade).ThenBy(x => x.GetFirstName());
            foreach (var student in orderByGrade)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Worker worker1 = new Worker("Ivan", "Peshev", 123.60, 8);
            Worker worker2 = new Worker("Pesho", "Ivanov", 170.10, 2);
            Worker worker3 = new Worker("Mitko", "Petkov", 145, 8);
            Worker worker4 = new Worker("Strahil", "Ivanov", 201.49, 4);
            Worker worker5 = new Worker("Dimitar", "Kolev", 121.60, 4);
            Worker worker6 = new Worker("Ivan", "Nikolaev", 150.65, 4);
            Worker worker7 = new Worker("Nikolai", "Ivanov", 183.70, 4);
            Worker worker8 = new Worker("Krasi", "Ivanov", 90.60, 5);
            Worker worker9 = new Worker("Joro", "Krasimirov", 303.90, 6);
            Worker worker10 = new Worker("Asencho", "Asenov", 103.60, 8);
            List<Worker> workers = new List<Worker>{worker1, worker2, worker3,
                worker4, worker5, worker6, worker7, worker8, worker9, worker10};

            // order workers by salary per hour
            var orderBySalaryPerHour = workers.OrderByDescending(x => x.MoneyPerHour());
            foreach (var worker in orderBySalaryPerHour)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine();


            // concat two sequences and order by first and last name
            List<dynamic> merged = new List<dynamic>(students.Concat<dynamic>(workers));

            // make it with lambda
            var both =
                merged.OrderBy(x => x.GetFirstName()).ThenBy(x => x.GetLastName());

            foreach (var item in both)
            {
                Console.Write(item.GetFirstName());
                Console.WriteLine(" " + item.GetLastName());
            }
            Console.WriteLine();

            // make it with LINQ
            var both2 =
                from element in merged
                orderby element.GetFirstName(), element.GetLastName()
                select element;

            foreach (var item in both2)
            {
                Console.Write(item.GetFirstName());
                Console.WriteLine(" " + item.GetLastName());
            }
        }
    }
}
