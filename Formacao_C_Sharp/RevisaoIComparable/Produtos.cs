namespace RevisaoIComparable
{
    internal class Produtos : IComparable<Produtos>
    {
        public string Name { get; set; }
        public int Quantidade { get; set; }

        public Produtos(string name, int quantidade)
        {
            Name = name;
            Quantidade = quantidade;
        }

        public int CompareTo(Produtos produtos)
        {
            if (this.Quantidade > produtos.Quantidade)
            {
                return 1;
            }

            if (this.Quantidade == produtos.Quantidade)
            {
                return 0;
            }
            return -1;
        }
    }
}
