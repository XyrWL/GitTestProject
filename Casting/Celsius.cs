using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Celsius
    {
        public float Temperature { get; private set; }

        public Celsius(float temperature)
        {
            Temperature = temperature;
        }

        //If information might be lost, use explicit, otherwise if a reversable conversion is done, use implicit (inparameter should be of the class it belongs to, return the new class).
        public static implicit operator Farenheit(Celsius celsius) => new Farenheit(9.0f/5.0f*celsius.Temperature + 32);
    }
}
