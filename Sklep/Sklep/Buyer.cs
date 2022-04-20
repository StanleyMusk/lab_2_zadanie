using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    internal class Buyer : Person
    {
        public Buyer(string n, int a) : base(n, a) {
            tasks = new List<Product>();
        }

 

        public override string Print()
        {
            string a = "Buyer : " + base.Print();
            if(tasks.Count > 0) {
                a += "\n        --Products: --";
                foreach (var p in tasks)
                {
                    a+="\n          "+p.Print();
                }
            }
            return a;
        }

        private List<Product> tasks;

        public void AddProduct(Fruit p)
        {
            tasks.Add(p);
        }

        public void AddProduct(Meat p)
        {
            tasks.Add(p);
        }


        public void RemoveProduct(int n)
        {
            tasks.Remove(tasks[n-1]); 
        }

    }
}
