namespace Entendo_IEquatable
{
    internal class Animal : IEquatable<Animal>
    {
        public string Nome { get; set; }
        public string Raca { get; set; }

        public Animal(string nome, string raca)
        {
            Nome = nome;
            Raca = raca;
        }

        public bool Equals(Animal? other)
        {
            if (this.Nome == other.Nome  && this.Raca == other.Raca)
            {
                return true;
            }
            return false;
        }
    }
}
