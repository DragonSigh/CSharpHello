// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int varA = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int varB = GetNumberFromUser("Введите целое число B: ", "Ошибка ввода!");
int exponent = GetNumberExponent(varA, varB);
Console.WriteLine($"{varA}, {varB} -> {exponent}");

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

// ---------------------------------------------------------------
// Метод возведения числа base_number в степень exponent_number
static int GetNumberExponent(int base_number, int exponent_number)
{
    int result = base_number;
    for (int i = 1; i < exponent_number; i++)
        result = result * base_number;
    return result;
}