// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.Write("Введите количество строк матрицы A: ");
int rows1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов матрицы A: ");
int columns1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество строк матрицы B: ");
int rows2 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов матрицы B: ");
int columns2 = int.Parse(Console.ReadLine() ?? "");

if (columns1 != rows2)
{
    // число столбцов матрицы А не совпадает с числом строк матрицы В
    Console.WriteLine("Ошибка! Число столбцов матрицы А должно совпадать с числом строк матрицы В!");
}
else
{
    int[,] array1 = GetArray(rows1, columns1, 0, 10);
    int[,] array2 = GetArray(rows2, columns2, 0, 10);
    Console.WriteLine("Матрица A: ");
    PrintArray(array1);
    Console.WriteLine("Матрица B: ");
    PrintArray(array2);
    Console.WriteLine("Результирующая матрица: ");
    PrintArray(MatrixMultiplication(array1, array2));
}

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

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            // Элемент x[i,j] на пересечении строки i и столбца j результирующей матрицы является
            // скалярным произведением i-й строки первой матрицы и j-го столбца второй матрицы
            int scalarProduct = 0;

            for (int k = 0; k < columns1; k++)
            {
                scalarProduct = scalarProduct + (matrixA[i,k] * matrixB[k,j]);
            }
            resultMatrix[i,j] = scalarProduct;
        }
    }
    return resultMatrix;
}