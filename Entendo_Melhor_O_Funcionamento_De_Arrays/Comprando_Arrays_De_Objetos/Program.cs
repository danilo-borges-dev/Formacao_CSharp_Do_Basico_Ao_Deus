using Comprando_Arrays_De_Objetos;

Atleta[] atletas = new Atleta[7];
atletas[0] = new Atleta { Name = "Danilo", Time = 60 };
atletas[1] = new Atleta { Name = "Sueli", Time = 12 };
atletas[2] = new Atleta { Name = "João", Time = 13 };
atletas[3] = new Atleta { Name = "Maria", Time = 80 };
atletas[4] = new Atleta { Name = "Eduardo", Time = 110 };
atletas[5] = new Atleta { Name = "Eduarda", Time = 215 };
atletas[6] = new Atleta { Name = "Marcos", Time = 102 };

Array.Sort(atletas);

foreach (Atleta item in atletas)
{
    Console.WriteLine(item);
}