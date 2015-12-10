using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    struct Mixture
    {
        public bool MyBool;
        public double MyDouble;
        public int MyInt;

        //public Mixture() {  } //Cannot override default constructor.
        public Mixture(bool myBool, double myDouble, int myInt)
        {
            MyBool = myBool;
            MyDouble = myDouble;
            MyInt = myInt;
        }

        public override string ToString() => $"MyBool:{MyBool}, MyDouble:{MyDouble}, MyInt:{MyInt}";
    }
}
