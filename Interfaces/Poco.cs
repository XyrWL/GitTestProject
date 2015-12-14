using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Poco : IComparable
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public double Size { get; private set; }

        public Poco(string name, int age, double size)
        {
            Name = name;
            Age = age;
            Size = size;
        }

        public int CompareTo(object obj)
        {
            return Age.CompareTo(((Poco)obj).Age);
        }
        public override string ToString()
        {
            return $"Name:{Name}, Age:{Age}, Size:{Size}";
        }
    }
}
