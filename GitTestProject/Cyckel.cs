using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestProject
{
    class Cyckel : Fordon
    {
        public new void Print()
        {
            Console.WriteLine("Cyckel");
        }
        public override void VirtualPrint()
        {
            Console.WriteLine("V: Cyckel");
        }
    }
}
