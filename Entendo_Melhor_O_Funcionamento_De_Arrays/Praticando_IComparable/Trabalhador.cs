namespace Praticando_IComparable
{
    internal class Trabalhador : IComparable<Trabalhador>
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Trabalhador(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return string.Format($"Trabalhador: {Name} Salário R${Salary}");
        }

        public int CompareTo(Trabalhador? other)
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
    }
}
