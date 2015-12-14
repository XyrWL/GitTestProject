using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestExercises
{
    enum FirstMenu
    {
        Ett = 1, Tvau, Avsluta
    }
    enum SecondMenu
    {
        Lista, Räkna, Avsluta
    }
    enum ThirdMenu
    {
        Create, Restore, Find, Exit
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ListExercise();
            EnumExercise();
        }

        private static void EnumExercise()
        {
            PrintMenuWithEnum(typeof(FirstMenu));
            SelectOptionFromFirstMenu();
            PrintMenuWithEnum(typeof(SecondMenu));
            SelectOptionFromSecondMenu();
            PrintMenuWithEnum(typeof(ThirdMenu));
            SelectOptionFromThirdMenu();
        }
        private static void SelectOptionFromThirdMenu()
        {
            int option;
            if (int.TryParse(Console.ReadLine(), out option))
            {
                ThirdMenu optionMenu = (ThirdMenu)option;
                switch (optionMenu)
                {
                    case ThirdMenu.Create:
                        Console.WriteLine(ThirdMenu.Create);
                        break;
                    case ThirdMenu.Restore:
                        Console.WriteLine(ThirdMenu.Restore);
                        break;
                    case ThirdMenu.Find:
                        Console.WriteLine(ThirdMenu.Find);
                        break;
                    case ThirdMenu.Exit:
                        Console.WriteLine(ThirdMenu.Exit);
                        break;
                    default:
                        Console.WriteLine("Wrong input.");
                        break;
                }
            }
        }
        private static void SelectOptionFromSecondMenu()
        {
            int option;
            if (int.TryParse(Console.ReadLine(), out option))
            {
                SecondMenu optionMenu = (SecondMenu) option;
                switch (optionMenu)
                {
                    case SecondMenu.Lista:
                        Console.WriteLine(SecondMenu.Lista);
                        break;
                    case SecondMenu.Räkna:
                        Console.WriteLine(SecondMenu.Räkna);
                        break;
                    case SecondMenu.Avsluta:
                        Console.WriteLine(SecondMenu.Avsluta);
                        break;
                    default:
                        Console.WriteLine("Wrong input.");
                        break;
                }
            }
        }
        private static void SelectOptionFromFirstMenu()
        {
            int option;
            if (int.TryParse(Console.ReadLine(), out option))
            {
                FirstMenu optionMenu = (FirstMenu) option;
                switch (optionMenu)
                {
                    case FirstMenu.Ett:
                        Console.WriteLine(FirstMenu.Ett);
                        break;
                    case FirstMenu.Tvau:
                        Console.WriteLine(FirstMenu.Tvau);
                        break;
                    case FirstMenu.Avsluta:
                        Console.WriteLine(FirstMenu.Avsluta);
                        break;
                    default:
                        Console.WriteLine("Wrong input.");
                        break;
                }
            }
        }
        private static void PrintMenuWithEnum(Type typeOfEnum)
        {
            int counter = (int) Enum.GetValues(typeOfEnum).GetValue(0);
            foreach (var item in Enum.GetNames(typeOfEnum)) //Turns the enum into a string array.
            {
                Console.WriteLine("{0}: {1}", counter++, item);
            }
        }

        private static void ListExercise()
        {
            var firstProduct = new Product(name: "Orange", quantity: 7);
            var secondProduct = new Product(name: "Apple", quantity: 59);
            var thirdProduct = new Product(name: "Rabbit", quantity: 12);

            var productList = new List<Product>() {firstProduct, secondProduct, thirdProduct};
            productList.Sort();

            Console.WriteLine("Minimum amount?");
            int minQuantity = int.Parse(Console.ReadLine());

            foreach (var product in productList.Where(product => product.Quantity >= minQuantity))
            {
                Console.WriteLine(product);
            }
            //foreach (var product in productList)
            //{
            //    if (product.Quantity >= minQuantity)
            //        Console.WriteLine(product);
            //}
        }
    }
}
