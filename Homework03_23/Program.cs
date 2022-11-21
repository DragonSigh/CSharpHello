// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

// Ввод
int input_number = UserInputNumber();

// Вывод
Console.Write($"{input_number} -> ");
PrintCubeTable(ref input_number);

// --------------------------------------------------------
// Метод для ввода числа от пользователя
static int UserInputNumber()
{
    int number = 1;
    // Проверяем правильность ввода
    while (true)
    {
        Console.Write("Введите целое число: ");
        if (int.TryParse(Console.ReadLine(), out number))
            break;
        Console.WriteLine("Ошибка ввода!");
    }
    return number;св 
}

// --------------------------------------------------------
// Метод для вывода таблицы кубов
static void PrintCubeTable(ref int input_number)
{
    int i;
    // Если число больше ноля и положительное
    if (input_number >= 1)
    {
        for (i=1; i <= input_number; i++)
            Console.Write($"{i*i*i}, ");
    }
    // Если число ноль или отрицательное
    else
    {
        for (i=0; i >= input_number; i--)
            Console.Write($"{i*i*i}, ");
    }
}