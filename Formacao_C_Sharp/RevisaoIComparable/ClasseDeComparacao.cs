namespace RevisaoIComparable
{
    internal class ClasseDeComparacao : IComparer<Produtos>
    {
        public int Compare(Produtos? x, Produtos? y)
        {
            if (x.Quantidade > y.Quantidade)
            {
                return 1;
            }

            if (x.Quantidade == y.Quantidade)
            {
                return 0;
            }
            return -1;
        }
    }
}
