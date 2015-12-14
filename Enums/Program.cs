using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        Press, Any, Key
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
            Console.ReadKey();
            RunMathProgram();
        }

        private static void RunMathProgram()
        {
            bool isEnd = false;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue; //Example of a common enum.
                PrintMenuWithEnum(typeof(Menu));
                MenuChoice(ref isEnd);
            }
            while (!isEnd);
        }

        private static void MenuChoice(ref bool isEnd)
        {
            int option;
            if (int.TryParse(Console.ReadLine(), out option))
            //Returns true if the parse was successful, result goes to out parameter.
            {
                Menu optionMenu = (Menu)option;
                switch (optionMenu)
                {
                    case Menu.Add:
                        ConsoleAddMethod();
                        PrintConsoleWait();
                        break;
                    case Menu.Substract:
                        break;
                    case Menu.Multiply:
                        break;
                    case Menu.Divide:
                        break;
                    case Menu.End:
                        Console.WriteLine(Menu.End); //ToString() method on enum returns the name, not the value.
                        isEnd = true;
                        break;
                    default:
                        //throw new ArgumentOutOfRangeException();
                        Console.WriteLine("Something went wrong, try again.");
                        PrintConsoleWait();
                        break;
                }
            }
        }

        private static void PrintConsoleWait()
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }

        private static void ConsoleAddMethod()
        {
            //Example method, should have better input control, separate input and output from result calculation.
            Console.WriteLine("{0}:", Menu.Add);
            int firstNumber;
            int secondNumber;
            if (int.TryParse(Console.ReadLine(), out firstNumber) &&
                int.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, firstNumber + secondNumber);
            }
        }

        private static void PrintMenuWithEnum(Type typeOfEnum)
        {
            int counter = (int)Enum.GetValues(typeOfEnum).GetValue(0);
            foreach (var item in Enum.GetNames(typeOfEnum)) //Turns the enum into a string array.
            {
                Console.WriteLine("{0}: {1}", counter++, item);
            }
        }
    }
}
