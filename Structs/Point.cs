using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    struct Point
    {
        public int X;
        public int Y;
        //public int Z { get; set; } //Possible, but debatable.    

        //Creating a constructor requires that it assigns default values to all fields (as the default constructor does) as well as having at least one inparameter.
        public Point(int x)
        {
            X = x;
            Y = 7;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        //Creating methods in a struct is possible but keeping it small is preferable due to performance.
        public int GetSum()
        {
            return X + Y;
        }

        public override string ToString()
        {
            return $"X:{X}, Y:{Y}";
        }
    }
}
