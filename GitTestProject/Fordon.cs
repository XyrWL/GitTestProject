using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestProject
{
    class Fordon
    {
        public void Print()
        {
            Console.WriteLine("Fordon");
        }
        public virtual void VirtualPrint()
        {
            Console.WriteLine("V: Fordon");
        }
    }
}
