using Genercis_Com_Listas;

List<Pessoa> listaDePessoas = new();

listaDePessoas.Add(new Pessoa("Danilo", 29, 'M'));
listaDePessoas.Add(new Pessoa("Marcela", 21, 'F'));
listaDePessoas.Add(new Pessoa("Romário", 11, 'M'));
listaDePessoas.Add(new Pessoa("Amanda", 11, 'M'));
listaDePessoas.Add(new Pessoa("Fábio", 11, 'M'));
listaDePessoas.Add(new Pessoa("Zanita", 11, 'M'));
listaDePessoas.Add(new Pessoa("Amanda", 11, 'M'));

int totalDepessoas;
totalDepessoas = listaDePessoas.Count();

Console.WriteLine($"Total de Pessoas na Lista: {totalDepessoas}");

Pessoa p = new();
p.Mostrar(listaDePessoas);

Console.WriteLine();

p.MetodoAumentaIdade(listaDePessoas);
p.Mostrar(listaDePessoas);

Console.WriteLine();

List<Pessoa> novaListaDePessoas;
novaListaDePessoas = listaDePessoas.OrderByDescending(x => x.Nome).ToList();

novaListaDePessoas.ForEach(n => Console.WriteLine(n.Nome));
Console.WriteLine();

List<Pessoa> listaPessoaSelecionada = (from Pessoa ps in novaListaDePessoas where ps.Nome == "Amanda" select ps).ToList();

listaPessoaSelecionada.ForEach(x => Console.WriteLine(x.Nome));
Console.WriteLine();

int somaDasidades = listaDePessoas.Sum(x => x.Idade);
Console.WriteLine($"A soma das idades das pessoas é: {somaDasidades}");