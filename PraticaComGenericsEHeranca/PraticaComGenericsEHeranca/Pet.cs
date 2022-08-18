namespace PraticaComGenericsEHeranca
{
    internal class Pet<T> where T : Animal
    {
        public string Apelido { get; set; }
    }
}
