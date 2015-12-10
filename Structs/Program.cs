using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            StructDemo1();
            StructDemo2();
            StructDemo3();
        }

        private static void StructDemo3()
        {
            Console.WriteLine("----- StructDemo3 -----");

            Mixture myMixture = new Mixture {MyBool = true, MyDouble = 5.5, MyInt = 5};
            Console.WriteLine(myMixture);
            myMixture = new Mixture();
            Console.WriteLine(myMixture);
            myMixture = new Mixture(true, 10.1, 10);
            Console.WriteLine(myMixture);
        }

        private static void StructDemo2()
        {
            Console.WriteLine("----- StructDemo2 -----");

            Point one;
            one.X = 5;
            one.Y = 10;
            Console.WriteLine(one);
            one = new Point();
            Console.WriteLine(one);
            one = new Point(x: 10);
            Console.WriteLine(one);
            one = new Point(x: 20, y: 20);
            Console.WriteLine(one);
            Console.WriteLine($"Sum:{one.GetSum()}");
        }

        private static void StructDemo1()
        {
            Console.WriteLine("----- StructDemo1 -----");
            Coordinate coordinate; //Using "= new Coordinate();" is allowed but does not create a reference to the Heap, it simply resets its value and isn't needed on a new variable.
            coordinate.X = 66;
            coordinate.Y = 88;

            Coordinate origin = new Coordinate { X = 50, Y = 50 }; //Object(struct) initializer works.
            origin.Z = "19";
            origin = new Coordinate(); //Sets all values to their default values, note that the string contained is set to null.
            Console.WriteLine(origin);
        }
    }
}
