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
            string url = "pagina?argumentos";

            Console.WriteLine(url.Substring(7));


            for (int i = 0; i < url.Length; i++)
            {
                string s = url[i].ToString();
                if (s != "?")
                {
                    Console.Write(s);
                }
            }

            Console.ReadLine();
        }
    }
}
