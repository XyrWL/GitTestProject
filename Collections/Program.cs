using System;
using System.Collections.Generic;

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
            FifthList();
            SixthList();
            SeventhList();
        }

        private static void SeventhList()
        {
            Console.WriteLine("---- SeventhList ----");

            var airplanes = new List<Airplane>() {new Airplane(seats: 20, pilots: 2), new Airplane(seats: 30, pilots: 0), new Airplane(seats: 10, pilots: 1)};
            foreach (var airplane in airplanes)
            {
                Console.WriteLine(airplane);
            }
            airplanes.Sort();
            Console.WriteLine("Sorted list:");
            foreach (var airplane in airplanes)
            {
                Console.WriteLine(airplane);
            }
            airplanes.Sort(PilotComparison);
            Console.WriteLine("(External) Sorted list:");
            foreach (var airplane in airplanes)
            {
                Console.WriteLine(airplane);
            }
        }

        private static int PilotComparison(Airplane airplaneA, Airplane airplaneB)
        {
            if (airplaneA.Pilots > airplaneB.Pilots)
                return 1;
            if (airplaneA.Pilots == airplaneB.Pilots)
                return 0;
            return -1;
        }

        private static void SixthList()
        {
            Console.WriteLine("---- SixthList ----");

            List<int> tal = new List<int>(new int[] { 3, 5, 6, 9, 4, 8, 6 });
            int indexPosition = tal.IndexOf(9);
            Console.WriteLine(indexPosition); //3 is the first position of "9".
            tal.Clear(); //Clears all elements from the list (sets to null).
            indexPosition = tal.IndexOf(9);
            Console.WriteLine(indexPosition); //Returns -1 if it's not available.
        }

        private static void FifthList()
        {
            Console.WriteLine("---- FifthList ----");

            List<int> shoeSizes = new List<int>() { 33, 35, 36, 23, 27, 44, 42, 45, 40 };
            var tryCopy = shoeSizes; //Points at the same object on the Heap.
            var trueCopy = new List<int>(shoeSizes);
            shoeSizes.Sort();
            shoeSizes.Reverse();
            foreach (var item in shoeSizes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("TryCopy:");
            for (int i = 0; i < shoeSizes.Count; i++)
            {
                Console.WriteLine(tryCopy[i]);
            }
            Console.WriteLine("TrueCopy:");
            foreach (var item in trueCopy)
            {
                Console.WriteLine(item);
            }
        }

        private static void FourthList()
        {
            Console.WriteLine("---- FourthList ----");

            var jas39 = new Airplane(seats: 5, pilots: 2);
            var jas40 = new Airplane(seats: 7, pilots: 0);
            var airplanes = new List<Airplane>() { jas39, jas40 };

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
                busses.Add(new Bus(horsepower: i % 20 * 5 + 100, seats: i % 10 + 10));
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
