namespace Praticanto_ICompare
{
    internal class ProdutoNacional
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }

        public ProdutoNacional(string nome, double valor, int quantidade)
        {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

        public override string ToString()
        {
            return string.Format($"Nome: {Nome} - Valor R${} - Quantidade: {Quantidade}");
        }
    }
}
