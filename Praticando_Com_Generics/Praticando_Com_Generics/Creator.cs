namespace Praticando_Com_Generics
{
    internal class Creator
    {
        public T Create<T>() where T : new()
        {
            return new T();
        }
    }

    internal class Teste
    {
        Creator c = new Creator();
        int i = c.Create<int>();
    }
}
