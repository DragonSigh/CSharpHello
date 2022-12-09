// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);

Console.WriteLine("->");

Console.WriteLine($"Номер строки с наименьшей суммой элементов: {GetMinimalSumOfRows(array)}");

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

int GetMinimalSumOfRows(int[,] inArray)
{
    int rowSum = 0;         // Сумма чисел в строке
    int minimalSum = 0;     // Минимальная сумма чисел
    int rowIndex = 0;       // Индекс строки с минимальной суммой чисел 

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        rowSum = 0;

        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            rowSum = rowSum + inArray[i, j];
        }

        if (i == 0) minimalSum = rowSum; // Принимаем первую найденную сумму за минимальную
        if (rowSum < minimalSum)
            {
                minimalSum = rowSum;
                rowIndex = i;
            }
    }
    return rowIndex + 1;
}