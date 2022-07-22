namespace PraticandoGenerics
{
    internal class RetornoDoServidor<T> where T : class, new()
    {
        public T Create()
        {
            return new T();
        }
    }
}
