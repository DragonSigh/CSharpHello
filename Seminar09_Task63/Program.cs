// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();

Console.Write("Введите значение N: ");
int varN = int.Parse(Console.ReadLine() ?? String.Empty);
GetAllNaturalNumbers(varN);

void GetAllNaturalNumbers(int n)
{
    Console.WriteLine($"{1)}")
    GetAllNaturalNumbers(n + 1)