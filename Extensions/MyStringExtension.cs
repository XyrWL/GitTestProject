using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class MyStringExtension
    {
        public static string Dotify(this string text) //this string : extends string
        {
            string result = text.Trim(); //avoid direct changes on text
            if (result[result.Length - 1] != '.')
                return result + '.';
            else
                return result;
        }
    }
}
