using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //Can inherit from other interfaces, adding to the contract requirement.
    interface IInterface : IComparable
    {
        void PrintHello();
        //Cannot implement an interface/contract.
        //{
        //    Console.WriteLine("Hej");
        //}
    }
}
