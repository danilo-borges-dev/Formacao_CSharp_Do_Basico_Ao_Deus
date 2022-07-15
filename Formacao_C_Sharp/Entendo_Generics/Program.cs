using Entendo_Generics;

Pacote p = new();

p.Elemento_01 = 10;
p.Elemento_02 = "Elemento";
p.Elemento_03 = 10.50;

p.Mostrar();

int somar = (int)p.Elemento_01;

Console.WriteLine(somar + 10);

Encomenda<string> e = new();

e.Elemento_01 = "Nova Encomenda";