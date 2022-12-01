// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

var arraySize = GetNumberFromUser("Введите число M: ", "Ошибка ввода!");
int[] myArray = new int[arraySize];

FillArray(myArray); // Заполняем массив

Console.Clear();
Console.WriteLine($"{String.Join(", ", myArray)} -> {CountPositiveNumbers(myArray)}");

// ---------------------------------------------------------------
// Метод для подсчета чисел больше 0 в массиве
static int CountPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}


// ---------------------------------------------------------------
// Метод для заполнения массива целыми числами
static void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetNumberFromUser($"Введите число №{i+1}: ", "Ошибка ввода!");
    }
}

// ---------------------------------------------------------------
// Метод для ввода целого числа от пользователя
static int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}