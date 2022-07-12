using Praticando_IComparable;

List<Trabalhador> listaTrabalahdores = new()
{
    new Trabalhador("Danilo", 5_000),
    new Trabalhador("Manuel", 2_500),
    new Trabalhador("Raquel", 4_963),
    new Trabalhador("Joyce", 7_892)
};

listaTrabalahdores.Sort();

foreach (Trabalhador item in listaTrabalahdores)
{
    Console.WriteLine(item);
}