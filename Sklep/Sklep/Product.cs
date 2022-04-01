using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    internal class Product : IThing
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        public Product(string n)
        {
            name = n;
        }

        public virtual string Print()
        {
            return name;
        }
    }
}
