using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class ClassFromEttAndTvau : IEtt, ITvau
    {
        //public void GoByBus() //Single implementation for both.
        //{
        //    Console.WriteLine("Goes by bus with both.");
        //}
        void IEtt.GoByBus()
        {
            Console.WriteLine("Goes by bus with IEtt.");
        }
        void ITvau.GoByBus()
        {
            Console.WriteLine("Goes by bus with ITvau.");
        }
    }
}
