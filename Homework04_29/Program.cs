// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

var arraySize = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
int[] array = new int[arraySize];

FillArray(array); // Заполняем массив
Console.Clear();
PrintArray(array, false); // Выводим числа без скобочек
Console.Write(" -> ");
PrintArray(array, true); // Выводим числа со скобочками

// ---------------------------------------------------------------
// Метод для заполнения массива целыми числами
static void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetNumberFromUser($"Введите элемент массива с индексом {i}: ", "Ошибка ввода!");
    }
}

// ---------------------------------------------------------------
// Метод для вывода массива в консоль
static void PrintArray(int[] array, bool brackets)
{
    if (brackets)
        Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1) // Не выводить запятую, если это последний элемент массива
            Console.Write(", ");
    }
    if (brackets)
        Console.Write("]");
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