Main();

void Main()
{
    MathOperations sum = new();
    double result = sum.Dividir(3, 0);

    Console.WriteLine("Resultado = " + result );
}

public class MathOperations
{
    double result = 0;
    public double Dividir(double x, double y)
    {
        result = x / y;
        return result;
    }   
}