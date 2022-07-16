using Praticando_Generics;

MainTest();

static void MainTest()
{
    ListaGenerica<int> lista1 = new();
    lista1.Add(1);

    ListaGenerica<string> lista2 = new();
    lista2.Add(" ");

    ListaGenerica<ClasseDeExemplo> lista3 = new();
    ClasseDeExemplo classe = new();
    lista3.Add(classe);
}