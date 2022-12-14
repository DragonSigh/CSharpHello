// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? String.Empty);

Console.Write($"{number} -> {digitsSum(number)}");

int digitsSum(int number)
{
    if (number == 0) return 0;
    else return (number % 10 + digitsSum(number / 10));
}

// 45 3 / 10 = 45;
// 4 5 / 10 = 4;
//  4 / 10 = 0