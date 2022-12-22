/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

double[,] FillArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble(), 2);
        }
    }
    return result;
}
void PrintArray(double[,] inArray)
{
    for (int index = 0; index < inArray.GetLength(0); index++)
    {
        for (int position = 0; position < inArray.GetLength(1); position++)
        {
            Console.Write($"{inArray[index, position]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = FillArray(rows, columns);
Console.WriteLine("======================================");
PrintArray(array);