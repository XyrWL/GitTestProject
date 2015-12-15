using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Class1
    {
        internal void Method()
        {
            try
            {
                Console.WriteLine("(Class1) Write a number:");
                var result = 67 / int.Parse(Console.ReadLine());
                Console.WriteLine($"Result = {result}");
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Message: {ex.Message}\r\nSource: {ex.Source}\r\nStack Trace: {ex.StackTrace}");
                Console.WriteLine(ex.Message);
                Method();
            }
            Console.WriteLine("Method in Class1 done.");
        }
    }
}
