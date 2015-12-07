using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djur
{
    class Dog : Animal
    {
        string djur = "Hund";
        public override void PrintInfo()
        {
            Console.WriteLine($"djur:{djur}, Name:{Name}");
        }
        public override string ToString()
        {
            return $"djur:{djur}, {base.ToString()}";
        }
    }
}
