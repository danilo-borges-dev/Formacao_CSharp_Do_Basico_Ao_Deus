using System;
using System.IO;

namespace Entendo_Finaly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LeitorDeArquivos l = null;

            try
            {
                l.LerProximaLinha();
                l.LerProximaLinha();
                l.LerProximaLinha();
            }
            catch (NullReferenceException ex)
            {
                 Console.WriteLine("Erro");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Exceção do tipo IOException capturada e tratada.");
            }
            catch(Exception ex)
            {
                throw new Exception("Erro");
            }
            finally
            {
                if (l != null)
                {
                    l.Fechar();
                }
            }

            Console.ReadKey();
        }
    }

    public class LeitorDeArquivos
    {
        public string Arquivo { get; }

        public LeitorDeArquivos(string arquivo)
        {
            Arquivo = arquivo;
            Console.WriteLine("Abringo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha . . .");
            throw new IOException();
            return "Linha do arquivo";
        }

        public void Fechar()
        {

            Console.WriteLine("Fechando arquivo.");
        }
    }
}
