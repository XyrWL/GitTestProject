﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    class Dog : Animal
    {
        string djur = "Hund";
        public override void PrintInfo()
        {
            Console.WriteLine(djur + " " + Name);
        }
    }
}
