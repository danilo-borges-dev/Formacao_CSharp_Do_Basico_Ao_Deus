namespace IEquatable_Com_Structs
{
    internal struct Cor : IEquatable<Cor>
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Cor(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public bool Equals(Cor other)
        {
            if (this.Codigo == other.Codigo)
            {
                return true;
            }
            return false;
        }
    }
}
