using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    internal class Meat : Product
    {
        private double weight;
        public Meat(string n , double d) : base(n)
        {
            weight = d;
        }
        public double Weight { get { return weight; } set { weight = value; } }

        public override string Print()
        {
            return  base.Print() + " (" + weight+" kg)";
        }
    }
}
