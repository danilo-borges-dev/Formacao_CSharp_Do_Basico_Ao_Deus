namespace ICompare_teste
{
    internal class ComparadorDescrescente : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x == y)
            {
                return 0;
            }

            if (x > y)
            {
                return 1;
            }
            return -1;
        }
    }
}
