using Entendo_Melhor_O_Funcionamento_De_Arrays;

ContaCorrente[] conta = new ContaCorrente[]
{
    new ContaCorrente("Danilo", 29),
    new ContaCorrente("João", 67),
    new ContaCorrente("Sueli", 60)
};

for (int i = 0; i < conta.Length; i++)
{
    ContaCorrente contaAuxiliar = conta[i];
    Console.WriteLine($"Conta de {contaAuxiliar.Name}. Idade do Cliente é {contaAuxiliar.Age}");
}