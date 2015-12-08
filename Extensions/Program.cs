using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = MyExtensions.Dotify("Hej");
            Console.WriteLine(name);
            Console.WriteLine("Kalle".Dotify());

            Bottle myBottle = new Bottle() { Size = 10 };

            Console.WriteLine(myBottle.DoubleSize());
            Console.WriteLine(myBottle.Quad());
            Console.WriteLine(MyExtensions.Quad(myBottle));
        }
    }
}
