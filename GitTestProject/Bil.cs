using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestProject
{
    class Bil : Fordon
    {
        public new void Print()
        {
            Console.WriteLine("Bil");
        }
        public override void VirtualPrint()
        {
            Console.WriteLine("V: Bil");
        }
    }
}
