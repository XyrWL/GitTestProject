using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class ClassFromEttAndTvau : IEtt, ITvau
    {
        public void GoByBus() //Single implementation for both.
        {
            Console.WriteLine("Goes by bus;");
        }
        //void IEtt.GoByBus()
        //{
        //    throw new NotImplementedException();
        //}
        //void ITvau.GoByBus()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
