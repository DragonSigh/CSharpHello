int number1 = UserInputNumber();
PrintPalindromeResult();

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

// Метод для вывода результатов проверки палиндрома

static void PrintPalindromeResult()
{
    
}