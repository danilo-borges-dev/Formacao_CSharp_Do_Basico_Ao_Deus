using ICompare_teste;

List<int> numbers = new List<int>() { 11, 5, 6, 81, 45, 32, 85, 58, 145, 2, 1 };
ComparadorDescrescente cd = new();

numbers.Sort(cd);

foreach (var item in numbers)
{
    Console.WriteLine(item);
}

