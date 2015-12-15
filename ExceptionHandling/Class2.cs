using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Class2
    {
        internal void Method()
        {
            try
            {
                Console.WriteLine("(Class2) Write a number:");
                var result = 4/int.Parse(Console.ReadLine());
                Console.WriteLine($"Result = {result}");
                var overflow = new List<int>();
                switch (result)
                {
                    case 1:
                        overflow.Add(result);
                        goto case 2;
                    case 2:
                        overflow.Add(result);
                        goto case 1;
                    default:
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Catch all. Exception: {ex.Message}");
            }
            catch
            {
                Console.WriteLine("Same as the last one, won't ever reach here.");
            }
            Console.WriteLine("Method in Class2 done.");
        }
    }
}
