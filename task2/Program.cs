// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указывает, что такого элемента нет.

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = FillArray(rows, columns);
PrintArray(array);
Console.WriteLine("================================");

Console.Write("Введите индекс строки массива: ");
int indexRows = int.Parse(Console.ReadLine()!);

Console.Write("Введите индекс столбца массива: ");
int indexColumns = int.Parse(Console.ReadLine()!);

Console.WriteLine("================================");
string elementValue = GetElementValue(array, indexRows, indexColumns);
Console.WriteLine(elementValue);

int[,] FillArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 9);
        }
    }
    return result;
}
string GetElementValue(int[,] Array, int r, int c)
{
    if (r >= Array.GetLength(0) && c >= Array.GetLength(1))
    {
        return "Данного числа нет в массиве";
    }
    else
    {
        object element = Array.GetValue(r, c);
        return $"Значение элемента = {element}";
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