using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Airplane
    {        
        public int Seats { get; set; }
        public int Pilots { get; set; }

        public Airplane(int seats, int pilots)
        {
            Seats = seats;
            Pilots = pilots;
        }

        public override string ToString() => $"Seats:{Seats}, Pilots:{Pilots}";
    }
}
