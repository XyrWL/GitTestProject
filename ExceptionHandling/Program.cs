using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass1 = new Class1();
            myClass1.Method();
            var myClass2 = new Class2();
            myClass2.Method();
        }
    }
}
