namespace PraticaComGenericsEHeranca
{
    internal interface IPet<out T> where T : Animal
    {
        public string Apelido { get; set; }
    }
}
