using System;

namespace Entendendo_Melhor_Exceções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                object o = null;
                o.ToString();
                int resultado = Matematica(10, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Referencia Null");
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
