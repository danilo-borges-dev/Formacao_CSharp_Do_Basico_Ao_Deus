using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entendo_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] idades = new int[5];

            idades[0] = 1;
            idades[1] = 2;
            idades[2] = 3;
            idades[3] = 4;
            idades[4] = 5;

            Console.WriteLine(idades[3]);

            int[] novoArray = idades;

            Console.WriteLine(novoArray[2]);

            Console.WriteLine(novoArray[2 + 2]);

            Console.ReadLine();
        }
    }
}
