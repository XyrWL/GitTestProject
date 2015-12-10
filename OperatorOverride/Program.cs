using System;

namespace OperatorOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle timBicycle = new Bicycle(min: 3, max: 21);
            Bicycle zebbeBicycle = new Bicycle(min: 1, max: 2);
            zebbeBicycle = zebbeBicycle + 90;
            Console.WriteLine(zebbeBicycle);
            int result = 20 + zebbeBicycle; //Not the same method.
            Console.WriteLine(result);
            zebbeBicycle -= 50; // = zebbeBicycle - 50;
            Console.WriteLine(zebbeBicycle);
        }
    }
}
