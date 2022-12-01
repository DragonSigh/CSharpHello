// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = GetNumberFromUser("Введите число b1: ", "Ошибка ввода!");
double k1 = GetNumberFromUser("Введите число k1: ", "Ошибка ввода!");
double b2 = GetNumberFromUser("Введите число b2: ", "Ошибка ввода!");
double k2 = GetNumberFromUser("Введите число k2: ", "Ошибка ввода!");

// Решение системы уравнений:
// y = k1 * x + b1
// y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// k1 * x - k2 * x = b2 - b1
// x * (k1 - k2) = b2 - b1
// x = (b2 - b1) / (k1 - k2)

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.Clear();
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({Math.Round(x, 2)}; {Math.Round(y, 2)})");

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