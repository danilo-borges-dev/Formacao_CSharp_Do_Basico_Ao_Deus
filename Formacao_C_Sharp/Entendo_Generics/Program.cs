using Entendo_Generics;

Pacote p = new();

p.Elemento_01 = 10;
p.Elemento_02 = "Elemento";
p.Elemento_03 = 10.50;

p.Mostrar();

int somar = (int)p.Elemento_01;  // Existe uma referência do objeto Pacote na memória Heap que referência, aponta para o valor em Elemento_01, por isto o C# faz o processo de unbuxing e precisamos converter explicitamente para int

Console.WriteLine(somar + 10);

Encomenda<object> e = new();

e.Elemento_01 = 10;

Console.WriteLine("Tipo de dados: " + e.RetornarT());
