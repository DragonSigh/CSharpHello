// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

var input_number = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
var result = GetSumOfDigitsInNumber(input_number);
Console.WriteLine($"{input_number} -> {result}");

// ---------------------------------------------------------------
// Метод для получения суммы цифр в числе
static int GetSumOfDigitsInNumber(int n)
{
    int sum = 0;
    while (n != 0)
    {
        sum = sum  + (n % 10);
        n = n / 10;
    }
    return sum;
}

// ---------------------------------------------------------------
// Метод для ввода целого числа от пользователя
static int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}