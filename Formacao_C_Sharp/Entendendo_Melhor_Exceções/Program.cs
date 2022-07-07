using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entendendo_Melhor_Exceções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int resultado = Matematica(10, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadLine();
        }

        static int Matematica(int numerador, int denominador)
        {
            if (denominador == 0)
            {
                throw new ArgumentException("Você não pode definir o denominador igual a 0.", nameof(denominador));
            }
            return numerador / denominador;
        }
    }
}
