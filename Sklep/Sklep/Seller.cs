using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    internal class Seller : Person
    {
        public Seller(string n , int a) : base(n, a) { }


        public string Print()
        {
            return "Seller : " + base.Print();
        }
    }
}
