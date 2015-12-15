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
                var result = 4 / int.Parse(Console.ReadLine());
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
                Console.WriteLine($"Catch all and rethrow. Exception: {ex.Message}");
                throw ex;
            }
            catch
            {
                Console.WriteLine("Same as the last one, won't ever reach here as the order is descending.");
            }
            finally
            {
                //Regardless of what happened, wether it went well or it went to a catch and followed with a throw, execute the following before exiting.
                Console.WriteLine("Finally in Class2."); //Close databases, etc.
            }
            Console.WriteLine("Method in Class2 done.");
        }
    }
}
