Metodo();

void Metodo()
{
    try
    {
        TestaDivisao(null);
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Não é possível dividir por zero.");
    }
    catch (Exception)
    {
        Console.WriteLine("Teste");
    }
}

void TestaDivisao(int? divisor)
{
    try
    {
        int resultado = Dividir(10, divisor);
        Console.WriteLine("Resultado da visiaão de 10 por " + divisor + " é " + resultado);
    }
    catch
    {
        throw;
    }
}

int Dividir(int numerador, int denominador)
{
    return numerador / denominador;
}