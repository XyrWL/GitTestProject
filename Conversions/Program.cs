using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeConversions();

            Cyckel c1 = new Cyckel();
            MC mc1 = new Cyckel();
            MC mc2 = (MC)c1;

            //Test with as:
            Cyckel cyckel = (Cyckel)new MC();
            MC mcTest = c1 as MC; //Attempts to convert c1 to an MC, if it fails it'll be null.
            if (mcTest != null)
            {
                //Converted.
            }

            //Test with is:
            object obj = new Cyckel();
            bool test = obj is Cyckel; //Always true.

            //Boxing:
            int tal = 5;
            object paket = tal; //Boxing - värdetyp till referenstyp.
            int talFromPaket = (int)paket; //Unboxing - referenstyp till värdetyp.

        }

        private static void TypeConversions()
        {
            long tal1 = 200; //Implicit int(int32) to long(int64) conversion, slower than simply assigning the right type of value: "long tal1 = 200L;".
            //int tal2 = 200L; //Implicit long to int conversion, not allowed due to data loss risk.
            int tal2 = (int)200L; //Allows the data loss, explicit type conversion.

            System.Int64 longTal = 200L;
            System.Int32 intTal = 200;
            var doubleTal = 4.4;
            var floatTal = 4.4f;

            float newFloat = (float)doubleTal; //Loses precision.
            int newInt = (int)doubleTal; //Loses the decimal part.
        }
    }
}
