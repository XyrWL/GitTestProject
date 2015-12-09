using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstList();
            SecondList();
            ThirdList();
            FourthList();
        }

        private static void FourthList()
        {
            Console.WriteLine("---- FourthList ----");

            var airplanes = new List<Airplane>();
            for (int i = 0; i < 20; i++)
            {
                airplanes.Add(new Airplane(seats: i % 20 + 10, pilots: i % 2 + 1));
            }
            foreach (var airplane in airplanes)
            {
                Console.Write($"({airplane})");
            }
            Console.WriteLine("");
        }

        private static void ThirdList()
        {
            Console.WriteLine("---- ThirdList ----");

            var busses = new List<Bus>();
            for (int i = 0; i < 20; i++)
            {
                busses.Add(new Bus(horsepower: (i % 20 + 20) * 5, seats: i % 10 + 10));
            }
            foreach (var bus in busses)
            {
                Console.Write($"({bus})");
            }
            Console.WriteLine("");
        }

        private static void SecondList()
        {
            Console.WriteLine("---- SecondList ----");

            var persons = new List<Person>();
            for (int i = 0; i < 50; i++)
            {
                persons.Add(new Person("Name" + i, i % 30));
            }
            foreach (var person in persons)
            {
                Console.Write($"({person})");
            }
            Console.WriteLine("");
        }

        private static void FirstList()
        {
            Console.WriteLine("---- FirstList ----");

            var lisa = new Person("Lisa", 26);
            var raffe = new Person("Rafael", 44);

            List<Person> persons = new List<Person>();
            persons.Add(lisa);
            persons.Add(raffe);
            foreach (var person in persons)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
