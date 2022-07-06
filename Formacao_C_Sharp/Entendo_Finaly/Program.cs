using System;

namespace Entendo_Finaly
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class LeitorDeArquivos
    {
        public string Arquivo { get;  }

        public LeitorDeArquivos(string arquivo)
        {
            Arquivo = arquivo;
            Console.WriteLine("Abringo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha . . .");
            return "Linho do arquivo";
        }

        public void Fechar()
        {

            Console.WriteLine("Fechando arquivo.");
        }
    }
}
