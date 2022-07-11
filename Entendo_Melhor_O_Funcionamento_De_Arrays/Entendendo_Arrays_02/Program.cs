
using Entendendo_Arrays_02;

Contatos[] contatos =  new Contatos[10];

Contatos c1 = new Contatos();
c1.Name = "Danilo";
c1.Age = 29;

Contatos c2 = new Contatos() { Name = "João", Age = 60 };

contatos[0] = c1;
contatos[1] = c2;

Console.WriteLine(contatos[0].Name);
Console.WriteLine(contatos[1].Age);
Console.WriteLine(contatos[1].Name);