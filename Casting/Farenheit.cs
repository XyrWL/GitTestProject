using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Farenheit
    {
        public float Temperature { get; private set; }

        public Farenheit(float temperature)
        {
            Temperature = temperature;
        }

        public static implicit operator Celsius(Farenheit farenheit) => new Celsius(5.0f / 9.0f * (farenheit.Temperature - 32));
    }
}
