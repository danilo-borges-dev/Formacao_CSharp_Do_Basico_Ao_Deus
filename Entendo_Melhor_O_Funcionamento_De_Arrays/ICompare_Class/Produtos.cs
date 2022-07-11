using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICompare_Class
{
    internal class Produtos
    {
        public Produtos(int iD, string name, double price)
        {
            ID = iD;
            Name = name;
            Price = price;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return String.Format($"ID {ID} Name {Name} Price {Price}");
        }
    }
}
