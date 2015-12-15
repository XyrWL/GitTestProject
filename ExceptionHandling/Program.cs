using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTryCatchExample();

            try
            {
                var myClass2 = new Class2();
                myClass2.Method();
            }
            catch (Exception)
            {
                Console.WriteLine("Handled in main.");
                Debug.WriteLine("Hidden: Handled in main."); //Requires System.Diagnostics, writes out on output, not on user console.
            }
        }

        private static void FirstTryCatchExample()
        {
            var myClass1 = new Class1();
            myClass1.Method();
        }
    }
}
