// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

int numberN = GetNumberFromUser("Введите значение N: ", "Ошибка ввода!");
string result = GetAllNaturalNumbers(numberN, 1);

Console.WriteLine($"N = {numberN} -> {result}");

// --------------------------------------------------------------------------
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

// -------------------------------------------------------------------------
// Рекурсивный метод для перечисления всех натуральных чисел от start до end
string GetAllNaturalNumbers(int start, int end)
{
    if (start == end)
        return start.ToString();

    return start + ", " + GetAllNaturalNumbers(start - 1, end);
}