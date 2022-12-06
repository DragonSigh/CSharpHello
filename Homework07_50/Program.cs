// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите позицию элемента в строке массива: ");
int row = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите позицию элемента в столбце массива: ");
int column = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(new Random().Next(3, 5),
                            new Random().Next(3, 5), -100, 100);

PrintArray(array);

if (row < array.GetLength(0)
    && column < array.GetLength(1)
    && row > 0
    && column > 0)
    Console.WriteLine($"[{row},{column}] -> {array[row - 1, column - 1]}");
else
    Console.WriteLine($"[{row},{column}] -> такого числа в массиве нет");


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}
