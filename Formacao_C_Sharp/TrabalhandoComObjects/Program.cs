using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Name = "Danilo";
            p.Age = 29;

            Pessoa outraP = new Pessoa();
            outraP.Name = "Danilo";
            outraP.Age = 29;

            if (p.Equals(outraP))
            {
                Console.WriteLine("São iguais.");
            }
            else
            {
                Console.WriteLine("Não são iguais.");
            }

            Console.ReadLine();
        }
    }

    internal class Pessoa
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            Pessoa p = (Pessoa)obj;
            return p.Name == Name && p.Age == Age;
        }
    }
}
