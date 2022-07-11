namespace ICompare_Class
{
    internal class ProdutoCompararValor : IComparer<Produtos>
    {
        public int Compare(Produtos? x, Produtos? y)
        {
            if (x.Price == y.Price)
            {
                return 0;
            }
            if (x.Price > y.Price)
            {
                return 1;
            }
            return -1;
        }
    }
}
