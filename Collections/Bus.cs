using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Bus
    {
        public int Horsepower { get; set; }
        public int Seats { get; set; }

        public Bus(int horsepower, int seats)
        {
            Horsepower = horsepower;
            Seats = seats;
        }

        public override string ToString() => $"Horsepower:{Horsepower}, Seats:{Seats}";
    }
}
