using Praticanto_ICompare;

List<ProdutoNacional> listaDeProdutos = new()
{
    new ProdutoNacional("Leite Moça", 5.50, 120),
    new ProdutoNacional("Pão Francês", 0.75, 200),
    new ProdutoNacional("Feijoada na Lata", 3.45, 25),
    new ProdutoNacional("Açaí em Pote", 3.99, 45)
};

ProdutoNacional feijoadaNaLata = new("Feijoada na Lata", 3.45, 25);

CompareClass comparar = new CompareClass();

listaDeProdutos.Sort(comparar);