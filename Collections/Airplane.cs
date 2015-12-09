using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Airplane : IComparable //Interface
    {        
        public int Seats { get; private set; }
        public int Pilots { get; private set; }

        public Airplane(int seats, int pilots)
        {
            Seats = seats;
            Pilots = pilots;
        }

        public override string ToString() => $"Seats:{Seats}, Pilots:{Pilots}";
        public int CompareTo(object obj) //No need for override keyword when implementing a method from an interface.
        {
            Airplane testPlane = (Airplane) obj; //Can use Airplane as parameter type instead (must use IComparable<Airplane> then) but it prevents possibility of comparison with other types.
            // Return -1, 0, 1 (if smaller, equal or bigger).
            return testPlane.Seats.CompareTo(this.Seats); //int also implements IComparable, so it's possible to use int's CompareTo method.
        }
    }
}
