Console.Write("Введите номер дня недели: ");
int numberDay = int.Parse(Console.ReadLine());

if (numberDay == 1)
{
    Console.WriteLine($"{numberDay} -> Понедельник");
}
if (numberDay == 2)
{
    Console.WriteLine($"{numberDay} -> Вторник");
}
if (numberDay == 3)
{
    Console.WriteLine($"{numberDay} -> Среда");
}
if (numberDay == 4)
{
    Console.WriteLine($"{numberDay} -> Четверг");
}
if (numberDay == 5)
{
    Console.WriteLine($"{numberDay} -> Пятница");
}
if (numberDay == 6)
{
    Console.WriteLine($"{numberDay} -> Суббота");
}
if (numberDay == 7)
{
    Console.WriteLine($"{numberDay} -> Воскресенье");
}
else
{
    Console.WriteLine("Введено неверное число");
}