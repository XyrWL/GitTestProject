using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstProduct = new Product(name: "Orange", quantity: 7);
            var secondProduct = new Product(name: "Apple", quantity: 59);
            var thirdProduct = new Product(name: "Rabbit", quantity: 12);

            var productList = new List<Product>() { firstProduct, secondProduct, thirdProduct };
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
