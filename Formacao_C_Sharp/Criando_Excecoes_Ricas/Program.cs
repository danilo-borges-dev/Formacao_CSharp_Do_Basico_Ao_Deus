using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criando_Excecoes_Ricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente s = new ContaCorrente();
                s.Sacar(10);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.StackTrace);
            }

            Console.ReadLine();
        }
    }

    public class ContaCorrente
    {
        public void Sacar(double value)
        {
            if (value > 0)
            {
                throw new SaldoInsuficienteException();
            }
        }
    }
}
