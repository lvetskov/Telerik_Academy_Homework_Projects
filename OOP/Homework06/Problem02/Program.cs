using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Pesho", 20);
            Person person2 = new Person("Gosho");

            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());

        }
    }
}
