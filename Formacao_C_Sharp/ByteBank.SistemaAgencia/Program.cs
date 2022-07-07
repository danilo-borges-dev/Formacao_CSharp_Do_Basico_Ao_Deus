using ConsoleApp1;

namespace ByteBank.SistemaAgencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();

            AutenticacoHelper _autenticar = new AutenticacoHelper();

            _autenticar.Autenticar("","");
        }
    }
}
