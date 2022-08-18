using System.Reflection;

namespace PraticaComGenericsEHeranca
{
    internal static class ClasseHelper<T> where T : class
    {
        public static string ObeterNomeClasse() => typeof(T).Name;

        public static MethodInfo ObterMetodoPorNome(string nome) => typeof(T).GetMethods().FirstOrDefault(p => p.Name.Equals(nome, System.StringComparison));
    }
}
