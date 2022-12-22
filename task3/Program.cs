/* Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] FillArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}
void GetArithmeticMean(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(1); i++)
    {
        double arithmeticMean = 0;
        for (int j = 0; j < Array.GetLength(0); j++)
        {
            arithmeticMean += Array[j, i];
        }
        arithmeticMean = Math.Round(arithmeticMean / Array.GetLength(0), 1);
        Console.WriteLine($"№ столбца {i+1}: {arithmeticMean}");   
    }
}

void PrintArray(int[,] inArray)
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

int[,] array = FillArray(rows, columns);
Console.WriteLine("======================================");
PrintArray(array);
Console.WriteLine("======================================");
GetArithmeticMean(array);