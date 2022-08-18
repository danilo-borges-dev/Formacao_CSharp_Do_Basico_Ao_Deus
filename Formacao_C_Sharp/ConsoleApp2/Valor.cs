namespace ConsoleApp2
{
    internal class Valor<T> 
    {
        public T Valor_01 { get; set; }
        public T Valor_02 { get; set; }

        public string RetornarValorDaClasse()
        {
            T temp = default(T);
            if (temp == null)
            {
                return "reference type";
            }
            return "value type";
        }
    }
}
