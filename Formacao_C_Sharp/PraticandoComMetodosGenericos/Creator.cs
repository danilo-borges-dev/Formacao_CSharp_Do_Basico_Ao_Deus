namespace PraticandoComMetodosGenericos
{
    internal class Creator
    {
        public T Create<T>() where T :  new()
        {
            return new T();
        }

        public T Create2<T>(T x, T y) where T : struct
        {
            return x;
        }
    }
}
