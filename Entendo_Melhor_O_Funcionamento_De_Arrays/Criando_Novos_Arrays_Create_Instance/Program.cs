Array a = Array.CreateInstance(typeof(int), 5);

a.SetValue(10, 0);

Console.WriteLine(a.GetValue(0));

int[] b = (int[])a;

Console.WriteLine(b[0]);