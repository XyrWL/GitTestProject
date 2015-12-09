using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public class Bottle
    {
        public Bottle(int size)
        {
            Size = size;
        }
        public int Size { get; private set; }

        public int DoubleSize()
        {
            return Size *= 2;
        }

        //public int Quad()
        //{
        //    return Size *= 4;
        //}
    }
}
