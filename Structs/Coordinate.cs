using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    //-Struct is a custom valuetype.
    //-Has no direct references to the Heap (can contain references such as a string but it loses purpose).
    //-Implictly sealed (can't be inherited from).
    //-Public by default.
    //-Same syntax as class but with the keyword struct.
    //-All primitive (value)types are structs: int, long, float, double, char, bool, DateTime.
    //-Roughly around 3 times faster while containing up to 5 fields.
    //-Cannot be null.
    struct Coordinate
    {
        public int X; //Uppercase to indicate public access (similarity to properties).
        public int Y;
        //public int Z = 9; //Cannot assign an initial value.
        public string Z; //Can use reference types in a struct but it loses part of its purpose performance-wise.

        public override string ToString() => $"X:{X}, Y:{Y}, Z:{Z}";
    }
}
