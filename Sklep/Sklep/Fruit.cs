using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    internal class Fruit : Product
    {
        private int count;
        public Fruit(string n,int c) : base(n)
        {
            count = c;
        }

        public int Count { get { return count; } set { count = value; } }

        public override string Print()
        {
            return base.Print() + " (" + count + " fruits)";
        }
    }
}
