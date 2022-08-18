namespace PraticandoGenerics
{
    internal class RetornoDoServidor<T> where T : class, IInitializable, new()
    {
        public T Create()
        {
            T obj = new();
            obj.Init();
            return obj;
        }
    }
}
