// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int numberM = GetPositiveNumberFromUser("Введите неотрицательное число m: ", "Ошибка ввода!");
int numberN = GetPositiveNumberFromUser("Введите неотрицательное число n: ", "Ошибка ввода!");

int result = CalcAckermann(numberM, numberN);

Console.WriteLine($"m = {numberM}; n = {numberN} -> A(m,n) = {result}");

// --------------------------------------------------------------------------
// Метод для ввода целого положительного числа от пользователя
static int GetPositiveNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            if (userNumber >= 0)
                return userNumber;
        Console.WriteLine(errorMessage);
    }
}

// -------------------------------------------------------------------------
// Рекурсивный метод для вычисления функции Аккермана 
int CalcAckermann(int n, int m)
{
   if (n == 0) return m + 1;
   if (m == 0) return CalcAckermann(n - 1, 1);
   return CalcAckermann(n - 1, CalcAckermann (n, m - 1));
}