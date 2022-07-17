using PraticandoClasse_Generics;

Main();

void Main()
{
    ClasseTesteGenerica classeGenerica = new();

    ListaGenericaT<string> lista = new();
    lista.Add("Danilo");

    ListaGenericaT<int> lista2 = new();
    lista2.Add(1);

    ListaGenericaT<ClasseTesteGenerica> lista3 = new();
    lista3.Add(classeGenerica);
}

