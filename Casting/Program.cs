using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureConversions();
            PointCasting();
        }

        private static void PointCasting()
        {
            Console.WriteLine("---- PointCasting ----");
            Point3D point3D = new Point3D(x: 1, y: 2, z: 3);
            Point point = (Point) point3D;
            Console.WriteLine(point);
            point3D = point;
            Console.WriteLine(point3D);
        }

        private static void TemperatureConversions()
        {
            Console.WriteLine("---- TemperatureConversions ----");
            Farenheit fdegrees1 = new Farenheit(100.0f);
            Console.WriteLine($"F1:{fdegrees1.Temperature}");
            Celsius cdegrees = (Celsius)fdegrees1; //Reduntant cast, implicit.
            Console.WriteLine($"C1:{cdegrees.Temperature}");
            Farenheit fdegrees2 = cdegrees;
            Console.WriteLine($"F2:{fdegrees2.Temperature}");
        }
    }
}
