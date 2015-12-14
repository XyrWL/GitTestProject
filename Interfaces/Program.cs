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

            var ettAndTvau = new ClassFromEttAndTvau();
            IEtt ett = (IEtt)ettAndTvau;
            ett.GoByBus();

            var pocoList = new List<Poco>();
            pocoList.Add(new Poco("A", 1, 5.2));
            pocoList.Add(new Poco("B", 5, 3.1));
            pocoList.Add(new Poco("C", 6, 5.4));
            pocoList.Add(new Poco("D", 3, 6.7));
            pocoList.Add(new Poco("E", 2, 2.2));
            Console.WriteLine("Unsorted list:");
            foreach (var poco in pocoList)
            {
                Console.WriteLine(poco);
            }
            Console.WriteLine("Sorted list:");
            pocoList.Sort();
            foreach (var poco in pocoList)
            {
                Console.WriteLine(poco);
            }
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
