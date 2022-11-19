
Console.Write("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine() ?? "");

int numberSqr = numberTwo * numberTwo;

if (numberSqr == numberOne)
{
    Console.WriteLine("Первое число ЯВЛЯЕТСЯ квадратом второго");
}
else
{
    Console.WriteLine("Первое число НЕ ЯВЛЯЕТСЯ квадратом второго");
}