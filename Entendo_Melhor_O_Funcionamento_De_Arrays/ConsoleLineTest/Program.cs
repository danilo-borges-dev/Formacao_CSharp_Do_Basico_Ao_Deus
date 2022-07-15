int a = int.Parse(args[0]);
int b = int.Parse(args[1]);

if (args.Length != 2 )
{
    Console.WriteLine("O número de parâmetros é inválido!");
    return;
}

Console.WriteLine("A soma é " + (a + b));