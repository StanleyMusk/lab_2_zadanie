using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    internal class Person : IThing
    {
        private string name;
        private int age;
        public string Name { get { return name; } set { name = value; } }  
        public int Age { get { return age; } set { age = value; } }

        public Person(string n,int a)
        {
            name = n;
            age = a;
        }

        public virtual void Show() {}

        public string Print()
        {
            return name + " ("+age+" y.o.)";
        }
    }
}
