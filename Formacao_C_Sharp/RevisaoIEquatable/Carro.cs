namespace RevisaoIEquatable
{
    internal class Carro : IEquatable<Carro>
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public bool Equals(Carro? other)
        {
            if (this.Modelo == other.Modelo)
            {
                return true;
            }
            return false;
        }
    }
}
