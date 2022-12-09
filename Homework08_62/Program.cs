// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetSpiralArray(rows, columns);

PrintArray(array);

int[,] GetSpiralArray(int m, int n)
{
    int[,] resultArray = new int[m, n];

    const int rightDirection = 1;
    const int downDirection = 2;
    const int leftDirection = 3;
    const int upDirection = 4;

    int counter = 0;                // количество пройденных кругов
    int direction = rightDirection; // направление
    int row = 0;                    // текущая строка
    int column = 0;                 // текущий столбец

    for (int i = 1; i <= m * n; i++)
    {
        
        // Идём вправо
        if (direction == rightDirection)
        {
            resultArray[row, column] = i;
            if (column == n - 1 - counter)
            {
                row++;
                direction = downDirection;
                continue;
            }
            else{
                column++;
            }
        }

        // Идём вниз
        if (direction == downDirection)
        {
            resultArray[row, column] = i;
            if (row == m - 1 - counter)
            {
                column--;
                direction = leftDirection;
                continue;
            }
            else{
                row++;
            }
        }

        // Идём влево
        if (direction == leftDirection)
        {
            resultArray[row, column] = i;
            if (column == counter)
            {
                counter++; // прибавляем 1 круг
                row--;
                direction = upDirection;
                continue;
            }
            else{
                column--;
            }
        }

        // Идём вверх
        if (direction == upDirection)
        {
            resultArray[row, column] = i;
            if (row == counter)
            {
                column++;
                direction = rightDirection;
                continue;
            }
            else{
                row--;
            }
        }
    }

    return resultArray;
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
