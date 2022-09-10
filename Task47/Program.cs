Console.WriteLine("Введите значение m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение n");
int n = int.Parse(Console.ReadLine());

double[,] doubles = new double[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        doubles[i,j] = Math.Round(new Random().NextDouble() * 10, 1);
    }
}

Console.WriteLine("Mассив:");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(doubles[i, j] + " ");
    }
    Console.WriteLine();
}
