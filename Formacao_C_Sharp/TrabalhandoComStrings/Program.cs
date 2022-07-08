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
            string url = "paginas?argumentos";

            try
            {
                //ValidaString v = new ValidaString("");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.ToString());
            }


            string palavra = "moedaOrigem=real?moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";

            Console.WriteLine(GetValor(nomeArgumento, palavra));
                    
            Console.ReadLine();
        }

        
    }
}
