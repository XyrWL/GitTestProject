using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    //Enum, collection of constants following the syntax: enum Identifier { Constant1 = startValue, Constant2, ... }
    //Default startValue = 0, increasing by 1 on the following constants.
    //Can be written outside or in a class, preferably in its own separate file if the latter though it's acceptable for it to share space in a relevant file.
    enum TestMenu
    {
        TestCase0, TestCase1, TestCase2
    }
    enum Menu
    {
        Add = 1, Substract, Multiply, Divide, End
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenuWithEnum(typeof(TestMenu));
            Console.WriteLine();

            bool isEnd = false;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue; //Example of a common enum.
                PrintMenuWithEnum(typeof(Menu));
                int option;
                if (int.TryParse(Console.ReadLine(), out option))
                    //Returns true if the parse was successful, result goes to out parameter.
                {
                    Menu optionMenu = (Menu) option;
                    switch (optionMenu)
                    {
                        case Menu.Add:
                            Console.WriteLine(Menu.Add); //ToString() method on enum returns the name, not the value.
                            break;
                        case Menu.Substract:
                            Console.WriteLine(Menu.Substract);
                            break;
                        case Menu.Multiply:
                            Console.WriteLine(Menu.Multiply);
                            break;
                        case Menu.Divide:
                            Console.WriteLine(Menu.Divide);
                            break;
                        case Menu.End:
                            Console.WriteLine(Menu.End);
                            isEnd = true;
                            break;
                        default:
                            //throw new ArgumentOutOfRangeException();
                            Console.WriteLine("Something went wrong, try again.");
                            break;
                    }
                    System.Threading.Thread.Sleep(3000);
                }
            } while (!isEnd);
        }

        private static void PrintMenuWithEnum(Type typeOfEnum)
        {
            int counter = (int) Enum.GetValues(typeOfEnum).GetValue(0);
            foreach (var item in Enum.GetNames(typeOfEnum)) //Turns the enum into a string array.
            {
                Console.WriteLine("{0}: {1}", counter++, item);
            }
        }
    }
}
