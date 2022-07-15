namespace Entendo_Generics
{
    internal class Pacote
    {
        public object Elemento_01 { get; set; }
        public object Elemento_02 { get; set; }
        public object Elemento_03 { get; set; }

        public void Mostrar()
        {
            Console.WriteLine($"Elemento 01: {Elemento_01}");
            Console.WriteLine($"Elemento 02: {Elemento_02}");
            Console.WriteLine($"Elemento 03: {Elemento_03}");
        }
    }
}
