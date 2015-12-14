using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class MyClass : IInterface
    {
        //Must implement PrintHello() as part of the contract with the interface IInterface.
        public void PrintHello()
        {
            Console.WriteLine("Hello.");
        }
        //Must implement CompareTo() as part of the implicit contract with the interface IComparable.
        public int CompareTo(object obj)
        {
            return 0;
        }
    }
}
