using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string URL = @"http://www.bytebank.com/cambio?moedaOrigem=real?moedaDestino=dolar";
            ValidaString valida = new ValidaString(URL);

            Console.WriteLine(valida.GetValor("moedaOrigem"));

            Console.ReadLine();
        }
        
    }
}
