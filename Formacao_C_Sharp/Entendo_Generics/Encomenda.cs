namespace Entendo_Generics
{
    internal class Encomenda<T>
    {
        public T Elemento_01 { get; set; }
        public T Elemento_02 { get; set; }
        public T Elemento_03 { get; set; }

        public T RetornarT()
        {
            T temp = default(T);
            return temp;
        }
    }
}
