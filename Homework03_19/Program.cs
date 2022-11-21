// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Ввод
int number1 = UserInputNumber();
// Вывод
if (CheckPalindromeResult(ref number1))
    Console.WriteLine($"{number1} -> да");
else
    Console.WriteLine($"{number1} -> нет");

// --------------------------------------------------------
// Метод для ввода пятизначного числа от пользователя
static int UserInputNumber()
{
    int number = -1;
    // Проверяем правильность ввода
    while (true)
    {
        Console.Write("Введите пятизначное число: ");
        if (int.TryParse(Console.ReadLine(), out number))
            if (number >= 10000 && number < 100000)
                break;
        Console.WriteLine("Ошибка ввода!");
    }
    return number;
}

// --------------------------------------------------------
// Метод для проверки палиндрома
static bool CheckPalindromeResult(ref int number1)
{
    int n = number1;
    int reverse_number = 0;
    int digit = 0;

    // "Переворачиваем" число разряд за разрядом
    while (n != 0)
    {
        digit = n % 10;
        reverse_number = (reverse_number * 10) + digit;
        n = n / 10;
    }
        
    return (number1 == reverse_number);
}

// --------------------------------------------------------