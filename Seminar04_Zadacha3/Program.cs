int varA = GetNumberFromUser("Введите целое число: ", "Ошибка ввода");
int result = GetCountFromNumber(varA);
Console.Write($"{varA} -> {result}");

int GetCountFromNumber(int number)
{
    int count = 1;

    for(int i = 1; i <= number; i++)
    {
        count *= i;
    }

    return count;
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