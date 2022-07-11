
string[] firtArray = new string[1];
int[] secondArray = {1, 2, 3};
bool[] thirdArray = new bool[] {true, false, true};
short[] fourthArray = null;

string[,] newArray = { {"Danilo", "Sueli", "Marcos" },{"Rosana", "Nayla", "Ysabela" } }; // 

Console.WriteLine($"Acessando o primeiro elemento do primeiro array: {newArray[0,0]}");
Console.WriteLine($"Acessando o segundo elemento do segundo array: {newArray[1,2]}");

Console.WriteLine(secondArray.IsFixedSize);
Console.WriteLine(newArray.Rank);

Console.WriteLine(secondArray[0]);

object[] array = new object[1];

array[0] = "Name";

object[] newArray2 = { 0, 1, 2, 3, 4, 5 };

Console.WriteLine(newArray2[1]);