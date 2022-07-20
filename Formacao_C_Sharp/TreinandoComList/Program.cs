using TreinandoComList;

List<Class1> list = new()
{
   new Class1("A", 10),
   new Class1("B", 50),
   new Class1("C", 70),
   new Class1("A", 70),
};

int n = list.Count;

Console.WriteLine("Total " + n);

List<Class1> list2 = list.OrderBy(x => x.Name).ToList();

list2.ForEach(x => Console.WriteLine(x.Name));

list2 = list.OrderByDescending(x => x.Name).ToList();

list2.ForEach(x => Console.WriteLine(x.Name));

List<Class1> novaLista = (from Class1 c in list where c.Age == 70 select c).ToList();

novaLista.ForEach(x => Console.WriteLine(x.Age));
