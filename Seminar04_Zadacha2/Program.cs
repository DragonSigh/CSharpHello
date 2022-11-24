int varA = GetNumberFromUser("Введите целое число: ", "Ошибка ввода");
int result = GetCountFromNumber(varA);
Console.Write($"{varA} -> {result}");

int GetCountFromNumber(int number)
{
    int count = 0;

    do
    {
        number /= 10;
        count += 1;
    }
    while(number > 0);

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