using RevisandoListas;

List<Clientes> listaDeClientes = new()
{
    new Clientes("Maria", 25),
    new Clientes("Manuel", 13),
    new Clientes("Raimunda", 48)
};

Clientes c1 = new("Maicon", 52);

listaDeClientes.Add(c1);

Console.WriteLine(listaDeClientes.Count);

foreach (var item in listaDeClientes)
{
    Console.WriteLine(item.nome);
}

Console.WriteLine();

listaDeClientes.OrderBy(x => x.nome).ToList();

foreach (var item in listaDeClientes)
{
    Console.WriteLine(item.nome);
}

listaDeClientes.OrderByDescending(x => x.nome).ToList();

Console.WriteLine();

foreach (var item in listaDeClientes)
{
    Console.WriteLine(item.nome);
}

List<Clientes> novaListaDeClientes = (from Clientes c in listaDeClientes where c.nome == "Manuel" select c).ToList();

Console.WriteLine("\nLista apenas contendo o nome Manuel");

foreach (var item in novaListaDeClientes)
{
    Console.WriteLine(item.nome);
}

List<Clientes> n2 = (from Clientes c in listaDeClientes where c.idade == 29 select c).ToList();

List<Clientes> n3 = (from Clientes c in listaDeClientes where c.idade == 30 select c).ToList();

List<Clientes> n4 = (from Clientes c in listaDeClientes where c.idade == 10 select c).ToList();

