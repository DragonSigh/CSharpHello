// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();

Console.Write("Введите число A: ");
int varA = int.Parse(Console.ReadLine() ?? String.Empty);

Console.Write("Введите число B: ");
int varB = int.Parse(Console.ReadLine() ?? String.Empty);

Console.Write($"A = {varA}, B = {varB} -> {numbersDegree(varA, varB)}");

int numbersDegree(int numberA, int numberB)
{
    if (numberB == 0) return 1;
    if (numberB == 1) return numberA;
    return (numberA * numbersDegree(numberA, numberB - 1));
}