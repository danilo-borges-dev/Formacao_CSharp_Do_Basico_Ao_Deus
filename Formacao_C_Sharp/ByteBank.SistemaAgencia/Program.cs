using ConsoleApp1;
using System;

namespace ByteBank.SistemaAgencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginDeUsuario login = new LoginDeUsuario();

            try
            {
                login.ValidarLogin("13");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadLine();
        }
    }
}
