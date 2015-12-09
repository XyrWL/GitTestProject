using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class MyExtensions
    {
        public static string Dotify(this string text) //this string : extends string
        {
            //string result = text.Trim(); //avoid direct changes on text ?            
            text = text.Trim();
            if (text[text.Length - 1] != '.')
                return text + '.';
            else
                return text;
        }

        public static Bottle Double(this Bottle bottle)
        {
            Bottle newBottle = new Bottle(bottle.Size);
            bottle = newBottle;
            return bottle;
        }
    }
}
