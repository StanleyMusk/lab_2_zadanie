using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    internal class Shop : IThing
    {
        private string name;
        public string Name { get { return name; }  set { name = value; } }

        private List<Person> people;

        private List<Product> products;

        public Shop(string n, Product[] pro, Person[] peo) 
        {

            name = n;
            people = peo.ToList();
            products = pro.ToList();

        }

       public string Print()
        {
            Console.WriteLine("Shop: "+name);
            Console.WriteLine("-- People: --");
            foreach(var p in people)
            {
                Console.WriteLine( p.Print() );
                p.Show();
            }
            Console.WriteLine("--Products: --");
            foreach(var p in products)
            {
                Console.WriteLine(p.Print());
            }
            return " ";
        }
    }
}
