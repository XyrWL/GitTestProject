using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExercises
{
    class Product : IComparable<Product>
    {
        public string Name { get; private set; }
        public int Quantity { get; private set; }

        public Product(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public int CompareTo(Product other)
        {
            return Quantity.CompareTo(other.Quantity);
        }
        public override string ToString() => $"Name:{Name}, Quantity:{Quantity}";
    }
}
