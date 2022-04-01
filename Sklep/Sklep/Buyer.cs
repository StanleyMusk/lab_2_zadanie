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

 

        public string Print()
        {
            return "Buyer : " + base.Print();
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


        public override void Show()
        {   
            if(tasks.Count != 0)
            Console.WriteLine("--Products: --");
            foreach (var p in tasks)
            {
                Console.WriteLine("     "+p.Print());
            }
        }

        public void RemoveProduct(int n)
        {
            tasks.Remove(tasks[n-1]); 
        }

    }
}
