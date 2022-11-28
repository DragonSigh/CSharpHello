// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов
// массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();

int[] myArray = new int[123];
FillArray(myArray); // Заполняем массив
CountNumbers(10, 99, myArray);

// ---------------------------------------------------------------
// Метод для заполнения массива целыми числами
static void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
}

static void CountNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
}

