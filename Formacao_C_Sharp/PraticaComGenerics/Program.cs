using PraticaComGenerics;

Lista l = new Lista();

l.Adicionar(10);
l.Adicionar(20);
l.Adicionar(30);
l.Adicionar(40);
l.Adicionar(50);

int e1 = (int)l.Ler(0);
int e2 = (int)l.Ler(1);
int e3 = (int)l.Ler(2);
int e4 = (int)l.Ler(3);
int e5 = (int)l.Ler(4);

Console.WriteLine(e1);
Console.WriteLine(e2);
Console.WriteLine(e3);
Console.WriteLine(e4);
Console.WriteLine(e5);
