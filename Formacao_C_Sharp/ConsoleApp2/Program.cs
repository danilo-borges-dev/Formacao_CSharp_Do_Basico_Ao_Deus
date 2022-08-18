using ConsoleApp2;

Valor<int> v = new();

v.Valor_01 = 10;
v.Valor_02 = 10;

Console.WriteLine(v.RetornarValorDaClasse());

//CriadorDeClasses<Teste> t = new();
//Teste t2 = new();
//t2 = t.Criar();

MetodoGenerico m = new();

m.MetodoT<int>(10);