using System;
using System.Text.RegularExpressions;

namespace TrabalhandoComStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //string URL = @"http://www.bytebank.com/cambio?moedaOrigem=real?moedaDestino=dolar".ToUpper();
            //ValidaString valida = new ValidaString(URL);

            //Console.WriteLine(valida.GetValor("moedaOrigem").ToUpper());

            string mensagem_01 = "Me ligue em 97894-2095";
            string mensagem_02 = "Meu número de telefone é 7895-5263";
            string mensagem_03 = "O número de telefone 9915-5236 é contato profissional";

            string padraoTelefone = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            padraoTelefone = "[0-9]{4,5}-?[0-9]{4}";

            Console.WriteLine(Regex.IsMatch(mensagem_01, padraoTelefone));  // Temos como retorno um true
            Console.WriteLine(Regex.Match(mensagem_01, padraoTelefone)) ;// Temos como retorno o número que está dentro do padrão

            Console.ReadLine();
        }
        
    }
}
