using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualAndNew();
            Abstract();
        }

        private static void Abstract()
        {
            Console.WriteLine("------- Abstract -------");
            //Vehicle vehicle = new Vehicle(); - does not work, must have a child with a constructor.
            Vehicle vehicle = new Car();
            vehicle.Print();
        }

        private static void VirtualAndNew()
        {
            Console.WriteLine("------- VirtualAndNew -------");
            Cyckel cyckel = new Cyckel();
            Fordon fordon = (Fordon)cyckel;            
            
            //New method uses the type it's cast as to determine which method to use, not the content.
            cyckel.Print();
            fordon.Print();
            //Overrided virtual method uses the content, not what type it's cast as.
            cyckel.VirtualPrint();
            fordon.VirtualPrint();

            Bil bil = new Bil();
            Fordon[] fordonare = new Fordon[3] { cyckel, fordon, bil };
            Console.WriteLine("New:");
            foreach (var item in fordonare)
            {
                item.Print();
            }
            Console.WriteLine("Polimorph:");
            foreach (var item in fordonare)
            {
                item.VirtualPrint();
            }            
        }
    }
}
