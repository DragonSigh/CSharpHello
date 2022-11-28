// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int arraySize = new Random().Next(3, 6);       // Случайный размер массива
int[] myArray = GetArray(arraySize, -100, 100);  // Создаём массив с элементами от -100 до 100

Console.WriteLine($"[{String.Join(", ", myArray)}] -> {SumOddPositions(myArray)}");

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
// Возвращает сумму элементов на нечётных позициях в массиве
int SumOddPositions(int[] arr)
{
    int sum = 0;

    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}
