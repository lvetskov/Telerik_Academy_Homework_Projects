using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ivan", "Ivanov", "Ivanov", "Sofia", 123123123, 4, 123132, Specialty.Business, University.TU, Faculty.Management);
            Console.WriteLine(student1.ToString());
            Console.WriteLine();
            Student student2 = student1.Clone();
            Console.WriteLine(student2.ToString());
            if (student1.CompareTo(student2) == 0)
            {
                Console.WriteLine("student1 and student2 are identical copies");
            }
        }
    }
}
