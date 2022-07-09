using System;

namespace Entendo_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] idades = new int[5];

            idades[0] = 29;
            idades[1] = 18;
            idades[2] = 33;
            idades[3] = 36;
            idades[4] = 23;

            int contadorAuxiliar = 0;

            for (int i = 0; i < idades.Length; i++)
            {
                Console.WriteLine($"Idade no indice {i} é igual a {idades[i]}");
                contadorAuxiliar += idades[i];
            }

            Console.WriteLine($"A média de idades é igual a {contadorAuxiliar / idades.Length}");

            Console.ReadLine();
        }
    }
}
