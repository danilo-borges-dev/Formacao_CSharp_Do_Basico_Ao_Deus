using RevisaoEQuatable;

List<Cliente> listaDeClientes = new()
{
    new Cliente("Jose", 35, 'M'),
    new Cliente("Maria", 31, 'F'),
    new Cliente("Gabriela", 25, 'M'),
    new Cliente("Manuel", 60, 'M')
};

Cliente josimar = new("Maria", 32, 'F');

bool verificar = listaDeClientes.Contains(josimar);

Console.WriteLine(verificar);