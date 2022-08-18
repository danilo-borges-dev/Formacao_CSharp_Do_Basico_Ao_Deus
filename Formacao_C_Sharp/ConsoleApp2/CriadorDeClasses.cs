namespace ConsoleApp2
{
    internal class CriadorDeClasses<T> where T : struct
    {
        public T Criar()
        {
            return new T();
        }

    }
}
