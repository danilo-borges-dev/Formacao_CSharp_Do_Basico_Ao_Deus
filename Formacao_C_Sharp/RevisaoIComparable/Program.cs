using RevisaoIComparable;

List<Produtos> lista = new()
{
    new Produtos("Macarão", 100),
    new Produtos("Batata", 782),
    new Produtos("Madioca", 56),
    new Produtos("Leite", 40)
};

//lista.Sort();

//lista.ForEach(q => Console.WriteLine(q.Quantidade));

ClasseDeComparacao cp = new();

lista.Sort(cp);

lista.ForEach(x => Console.WriteLine($"Nome {x.Name} - Quantidade {x.Quantidade}"));
