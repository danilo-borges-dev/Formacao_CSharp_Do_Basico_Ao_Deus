using IComparable_teste;
using System.Collections;

List<Programador> p = new List<Programador>();

p.Add(new Programador("Danilo", 5_000));
p.Add(new Programador("João", 3_000));
p.Add(new Programador("Marcos", 3_521.10));
p.Add(new Programador("Emanuely", 1_562.25));

p.Sort();

foreach (Programador item in p)
{
    Console.WriteLine(item);
}

