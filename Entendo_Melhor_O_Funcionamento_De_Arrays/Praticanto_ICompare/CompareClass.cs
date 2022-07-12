namespace Praticanto_ICompare
{
    internal class CompareClass : IComparer<ProdutoNacional>
    {
        public int Compare(ProdutoNacional? x, ProdutoNacional? y)
        {
            if (x.Valor == y.Valor)
            {
                return 0;
            }
            if (x.Valor > y.Valor)
            {
                return -1;
            }
            return 1;
        }
    }
}
