int n = 4;
int m = 4;
int[,] massiv = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        massiv[i, j] = new Random().Next(1, 10);
    }
}
Console.WriteLine("Mассив:");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(massiv[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите позицию элемента через запятую");
string pos = Console.ReadLine();
int expectedM = int.Parse(pos.Split(',')[0]);
int expectedN = int.Parse(pos.Split(',')[1]);

if (expectedM > m-1 || expectedN > n-1)
{
    Console.WriteLine("Значения с такой позицией не существует");
}
else
{
    Console.WriteLine(massiv[expectedM, expectedN]);
}