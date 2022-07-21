
using RevisaoIEquatable;

List<Carro> listaDeCarros = new();

Carro c1 = new();
c1.Marca = "Chevrolet";
c1.Modelo = "Cruze 2012";

Carro c2 = new();
c2.Marca = "BMW";
c2.Modelo = "Radiom";

listaDeCarros.Add(c1);
listaDeCarros.Add(c2);

Carro c3 = new();
c3.Marca = "Chevrolet";
c3.Modelo = "Cruze 2012";

bool retorno = listaDeCarros.Contains(c3);

Console.WriteLine("Sim contem " + retorno);

Console.WriteLine();

Carro c4 = new();
c4.Marca = "Fiat";
c4.Modelo = "Hardor";

retorno = listaDeCarros.Contains(c4);

Console.WriteLine("Contem? " + retorno);
