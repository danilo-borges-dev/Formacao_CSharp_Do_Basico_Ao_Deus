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

        public string GetValor(string nomeDoParametro, string palavra)
        {
            string termo = nomeDoParametro + "=";
            int indiceTermo = palavra.IndexOf(termo);
            int tamanhoTermo = termo.Length;
            string resultado = palavra.Substring(indiceTermo + tamanhoTermo);
            return resultado;
        }
    }
}
