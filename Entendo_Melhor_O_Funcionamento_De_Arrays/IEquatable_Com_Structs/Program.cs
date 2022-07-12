using IEquatable_Com_Structs;

List<Cor> cores = new()
{
    new Cor (10, "Amarelo"),
    new Cor (11, "Azul"),
    new Cor (78, "Roxo"),
    new Cor (89, "Vermelho"),
};

Cor novaCor = new(11, "Azul");

bool result = cores.Contains(novaCor);

Console.WriteLine("Resultado " + result);