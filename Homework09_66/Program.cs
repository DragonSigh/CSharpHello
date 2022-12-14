// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int numberM = GetNumberFromUser("Введите значение M: ", "Ошибка ввода!");
int numberN = GetNumberFromUser("Введите значение N: ", "Ошибка ввода!");

int result = GetSumOfNaturalNumbers(numberM, numberN);

Console.WriteLine($"M = {numberM}; N = {numberN} -> {result}");

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
// Рекурсивный метод для подсчёта суммы натуральных чисел от start до end
int GetSumOfNaturalNumbers(int start, int end)
{
    if (start == end)
        return end;

    return end + GetSumOfNaturalNumbers(start, end - 1);
}