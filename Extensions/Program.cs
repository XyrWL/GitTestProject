using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            //var name = MyExtensions.Dotify("Hej");
            //Console.WriteLine(name);
            //Console.WriteLine("Kalle".Dotify());
            string originalText = "Blah";
            string newText = originalText.Dotify();
            Console.WriteLine($"originalText:{originalText}, newText:{newText}");
        }
    }
}
