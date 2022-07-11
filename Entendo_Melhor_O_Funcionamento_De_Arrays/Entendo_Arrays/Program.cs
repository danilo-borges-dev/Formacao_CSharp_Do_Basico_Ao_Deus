
string[] firtArray = new string[1];
int[] secondArray = {1, 2, 3};
bool[] thirdArray = new bool[] {true, false, true};
short[] fourthArray = null;

string[,] newArray = { {"Danilo", "Sueli", "Marcos" },{"Rosana", "Nayla", "Ysabela" } }; // 

Console.WriteLine($"Acessando o primeiro elemento do primeiro array: {newArray[0,0]}");
Console.WriteLine($"Acessando o segundo elemento do segundo array: {newArray[1,2]}");

Console.WriteLine(secondArray.IsFixedSize);
Console.WriteLine(newArray.Rank);

var source = new[] { "Ally", "Bishop", "Billy" };
var target = new string[5];

source.CopyTo(target, 2);

    int i = 0;
foreach (var item in target)
{
    Console.WriteLine(i);
    Console.WriteLine(item);
    i++;
}

// output:

// Ally
// Bishop
// Billy