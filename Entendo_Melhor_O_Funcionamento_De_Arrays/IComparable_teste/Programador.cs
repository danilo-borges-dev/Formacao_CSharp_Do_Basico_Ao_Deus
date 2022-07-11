namespace IComparable_teste
{
    internal class Programador : IComparable<Programador>
    {

        public string Name { get; set; }
        public double Salary { get; set; }

        public Programador(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }


        public int CompareTo(Programador? other)
        {
            if (this.Salary == other.Salary)
            {
                return 0;
            }
            if (this.Salary > other.Salary)
            {
                return 1;
            }
            return -1;
        }

        public override string ToString()
        {
            return String.Format($"{Name} Salary {Salary}");
        }
    }
}
