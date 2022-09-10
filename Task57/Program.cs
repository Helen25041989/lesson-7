int n = 4;
int m = 3;//строки
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
double[] result = new double[n];

for(int i = 0; i < n; i++)
{
    int sum=0;
    for (int j = 0; j < m; j++)
    {
        sum += massiv[j, i];
    }
    result[i] =Math.Round((double)sum / m,1);
}
Console.WriteLine("Среднее арифмитическое по столбцам = [{0}]", string.Join("; ", result));