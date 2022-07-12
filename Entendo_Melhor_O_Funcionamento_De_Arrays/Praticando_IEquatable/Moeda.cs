namespace Praticando_IEquatable
{
    internal class Moeda : IEquatable<Moeda>
    {
        public string Tipo { get; set; }
        public double Valor { get; set; }

        public Moeda(string tipo, double valor)
        {
            Tipo = tipo;
            Valor = valor;
        }

        public override string ToString()
        {
            return String.Format($"Tipo {Tipo} Valor ${Valor}");
        }

        public bool Equals(Moeda? other)
        {
            if (this.Tipo == other.Tipo)
            {
                return true;
            }
            return false;
        }
    }
}
