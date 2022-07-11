using ICompare_Class;

var produtos = new List<Produtos>()
{
    new Produtos(2, "Leite", 4.5),
    new Produtos(1, "Ovor", 5),
    new Produtos(3, "Água", 1.5)
};

ProdutoCompararValor comprarValor = new();

produtos.Sort(comprarValor);

foreach (Produtos item in produtos)
{
    Console.WriteLine(item);
}

