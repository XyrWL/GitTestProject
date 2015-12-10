using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverride
{
    struct Bicycle
    {
        private int val, min, max;
        //Current gear, min gear, max gear.
        public int Val
        {
            get { return val; }
            set
            {
                if (value >= min && value <= max)
                    val = value;
                else
                    val = min;
            }
        }

        public Bicycle(int min, int max)
        {
            val = min;
            this.min = min;
            this.max = max;
        }
        //public Bicycle(Bicycle bicycle)
        //{
        //    val = bicycle.Val;
        //    min = bicycle.min;
        //    max = bicycle.max;
        //}

        //Note that struct is a valuetype, class requires being mindful of references.
        public static Bicycle operator +(Bicycle bicycle, int quantity)
        {
            //if class:
            //Bicycle result = new Bicycle(bicycle);
            //result.max += quantity;
            //return result;
            bicycle.max += quantity;
            return bicycle;
        }
        public static int operator +(int quantity, Bicycle bicycle)
        {
            quantity += bicycle.max;
            return quantity;
        }
        public static Bicycle operator -(Bicycle bicycle, int quantity)
        {
            bicycle.max -= quantity;
            return bicycle;
        }
        public static int operator -(int quantity, Bicycle bicycle)
        {
            quantity -= bicycle.max;
            return quantity;
        }
        public static Bicycle operator ++(Bicycle bicycle)
        {
            bicycle.max++;
            return bicycle;
        }
        public static Bicycle operator *(Bicycle bicycle, int quantity)
        {
            bicycle.max *= quantity;
            return bicycle;
        }
        public static int operator *(int quantity, Bicycle bicycle)
        {
            quantity *= bicycle.max;
            return quantity;
        }
        public static Bicycle operator /(Bicycle bicycle, int quantity)
        {
            bicycle.max /= quantity;
            return bicycle;
        }
        public static int operator /(int quantity, Bicycle bicycle)
        {
            quantity /= bicycle.max;
            return quantity;
        }

        public static bool operator ==(Bicycle bicycleA, Bicycle bicycleB) => bicycleA.max == bicycleB.max;
        public static bool operator !=(Bicycle bicycleA, Bicycle bicycleB) => bicycleA.max != bicycleB.max;
        public static bool operator >(Bicycle bicycleA, Bicycle bicycleB) => bicycleA.max > bicycleB.max;
        public static bool operator <(Bicycle bicycleA, Bicycle bicycleB) => bicycleA.max < bicycleB.max;
        public static bool operator >=(Bicycle bicycleA, Bicycle bicycleB) => bicycleA.max >= bicycleB.max;
        public static bool operator <=(Bicycle bicycleA, Bicycle bicycleB) => bicycleA.max <= bicycleB.max;

        public override string ToString() => $"Val:{Val}, Min:{min}, Max:{max}";
    }
}
