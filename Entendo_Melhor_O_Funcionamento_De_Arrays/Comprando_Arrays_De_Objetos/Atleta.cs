namespace Comprando_Arrays_De_Objetos
{
    internal class Atleta : IComparable<Atleta>
    {
        public string Name { get; set; }
        public int Time { get; set; }


        public override string ToString()
        {
            return string.Format($"{Name} => {Time}");
        }
        public int CompareTo(Atleta other)
        {
            if (this.Time == other.Time)
            {
                return 0;
            }
            if (this.Time > other.Time)
            {
                return 1;
            }
            return -1;
        }


    }
}
