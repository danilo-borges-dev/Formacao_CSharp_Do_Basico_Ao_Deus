using System;

namespace TrabalhandoComStrings
{
    internal class ValidaString
    {
        public string URL;

        public ValidaString(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException(@"A URL não pode ser nula ou vazia """, nameof(url));
            }
            URL = url;
        }

        public string GetValor(string nomeDoParametro)
        {
            string termo = nomeDoParametro + "=";
            int indiceTermo = URL.IndexOf(termo);
            int tamanhoTermo = termo.Length;
            string resultado = URL.Substring(indiceTermo + tamanhoTermo);

            Console.WriteLine(resultado);
            int indicePontoDeInterrogacao = resultado.IndexOf("?");
            resultado = resultado.Remove(indicePontoDeInterrogacao);

            return resultado;
        }
    }
}
