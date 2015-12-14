using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program : IChildInterface
    {
        //Interface, similar in concept to an abstract class but cannot implement any actual functionality.
        //Can contain: events, methods, indexer, properties.
        //Contract: Force a class(/struct) to implement an interface, creating a common exterior behaviour for other classes to use.
        //Naming convention: IClassName.
        static void Main(string[] args)
        {
            //Can use an interface to operate on MyClass, whose methods(contract) expected functionality is known.
            IInterface interfaceOnMyClass = new MyClass();
            interfaceOnMyClass.PrintHello();

            Program program = new Program();
            program.ChildMethod();
            program.ParentMethod();
        }

        public void ParentMethod()
        {
            Console.WriteLine("Parent");
        }

        public void ChildMethod()
        {
            Console.WriteLine("Child");
        }
    }
}
