// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
Console.Write("Введите первую размерность массива: ");
int dimension1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите вторую размерность массива: ");
int dimension2 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите третью размерность массива: ");
int dimension3 = int.Parse(Console.ReadLine() ?? "");

int[,,] array3d = Get3dArray(dimension1, dimension2, dimension3, 10, 99);

Print3dArray(array3d);

int[,,] Get3dArray(int m, int n, int o, int minValue, int maxValue)
{
    int[] uniqueNumbers = new int[maxValue + 1]; // Массив уже существующих чисел
    int[,,] result = new int[m, n, o];

    int newNumber = 0;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < o; k++)
            {     
               while (true)
               {
                newNumber = new Random().Next(minValue, maxValue + 1);
                if (uniqueNumbers[newNumber] != newNumber) break;
               }

               uniqueNumbers[newNumber] = newNumber; // Сохраняем число в массиве уже существующих
                
               result[i, j, k] = newNumber;
            }
        }
    }
    return result;
}

void Print3dArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
              Console.Write($"{inArray[i, j, k]}({i},{j},{k})  ");  
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
