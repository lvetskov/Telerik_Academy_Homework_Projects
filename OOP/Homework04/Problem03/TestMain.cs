using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class TestMain
    {
        static void Main()
        {
            try
            {
                Kitten testCat = new Kitten(10, "pesho", SexEnum.Female);
                TomCat maleCat = new TomCat(20, "misho", SexEnum.Male);
                Frog bigFrog = new Frog(50, "gabcho", SexEnum.Male);

                List<ISound> differentSounds = new List<ISound>();
                differentSounds.Add(new Kitten(10, "pesho", SexEnum.Female));
                differentSounds.Add(new TomCat(20, "misho", SexEnum.Male));
                differentSounds.Add(new Frog(50, "gabcho", SexEnum.Male));

                foreach (var item in differentSounds)
                {
                    item.MakeSound();
                }

                List<Animals> differentAnimalsList = new List<Animals>();
                differentAnimalsList.Add(new Kitten(10, "pesho", SexEnum.Female));
                differentAnimalsList.Add(new TomCat(20, "misho", SexEnum.Male));
                differentAnimalsList.Add(new Frog(50, "gabcho", SexEnum.Male));
                differentAnimalsList.Add(new Frog(30, "gabcho2", SexEnum.Male));
                differentAnimalsList.Add(new Dog(25, "sharo", SexEnum.Male));
                differentAnimalsList.Add(new Kitten(5, "puhcho", SexEnum.Female));

                //one query
                var animalGroups =
                    (from animal in differentAnimalsList
                     group animal by animal.GetType().Name into groups
                     select new
                     {
                         groupName = groups.Key,
                         averageSum =
                             (from anim in groups
                              select anim.Age).Average()
                     });

                foreach (var item in animalGroups)
                {
                    Console.WriteLine(item);
                }
                //several queries
                Console.WriteLine("Average kitten age: ");
                var result =
                    (from animal in differentAnimalsList
                     where animal.GetType() == typeof(Kitten)
                     select animal.Age).Average();
                Console.WriteLine(result);
                Console.WriteLine("Average tomcat age: ");
                result =
                    (from animal in differentAnimalsList
                     where animal.GetType() == typeof(TomCat)
                     select animal.Age).Average();
                Console.WriteLine(result);
                Console.WriteLine("Average frog age: ");
                result =
                    (from animal in differentAnimalsList
                     where animal.GetType() == typeof(Frog)
                     select animal.Age).Average();
                Console.WriteLine(result);
                Console.WriteLine("Average dog age: ");
                result =
                    (from animal in differentAnimalsList
                     where animal.GetType() == typeof(Dog)
                     select animal.Age).Average();
                Console.WriteLine(result);


            }
            catch (ArgumentException err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
