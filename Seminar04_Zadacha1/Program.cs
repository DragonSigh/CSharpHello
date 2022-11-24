int varA = GetNumberFromUser("Введите целое число: ", "Ошибка ввода");
int result = GetSumFrom1ToNumber(varA);
Console.Write($"{varA} -> {result}");

int GetSumFrom1ToNumber(int number)
{
    int sum = 0;

    for (int i=0;i<=number;i++)
        sum += i;

    return sum;
}

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}