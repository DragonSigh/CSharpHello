// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int arraySize = new Random().Next(5, 10);       // Случайный размер массива
double[] myArray = GetArray(arraySize, 1, 100);  // Создаём массив с элементами от 1 до 100

Console.WriteLine($"[{String.Join(", ", myArray)}] -> {minMaxDifference(myArray)}");

//////////////////////////////////////////////////////////////////////////////////
// Возвращает массив из size элементов,
// заполненный случайными числами из промежутка [minValue, maxValue]
double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

//////////////////////////////////////////////////////////////////////////////////
// Возвращает разницу между максимальным и минимальным элементом массива
double minMaxDifference(double[] arr)
{
    double minNum = arr[0];
    double maxNum = arr[0];

    foreach (double element in arr)
    {
        if (element < minNum) minNum = element;
        if (element > maxNum) maxNum = element;
    }

    return maxNum - minNum;
}
