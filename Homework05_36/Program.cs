// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int arraySize = new Random().Next(4, 10);       // Случайный размер массива
int[] myArray = GetArray(arraySize, 100, 999);  // Создаём массив с элементами от 100 до 999

Console.WriteLine($"[{String.Join(", ", myArray)}] -> {CountPositiveNumbers(myArray)}");

//////////////////////////////////////////////////////////////////////////////////
// Возвращает массив из size элементов,
// заполненный случайными числами из промежутка [minValue, maxValue]
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

//////////////////////////////////////////////////////////////////////////////////
// Считает количество положительных элементов в массиве
int CountPositiveNumbers(int[] arr)
{
    int counter = 0;
    foreach (int element in arr)
    {
        if (element % 2 == 0) counter += 1;
    }
    return counter;
}
