using Praticando_IEquatable;

List<Moeda> listaDeMoedas = new()
{
    new Moeda("1 Real", 1.0),
    new Moeda("50 Centavos", 0.50),
    new Moeda("Pix", 100.00)
};

Moeda pix = new("Pix", 100.00);

bool result = listaDeMoedas.Contains(pix);

Console.WriteLine("Resultado: " + result);