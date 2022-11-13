Console.Write("Введите первое целое число: ");
int numA = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе целое число: ");
int numB = int.Parse(Console.ReadLine() ?? "");

int maxNum = 0;

if (numA > numB) maxNum = numA; else maxNum = numB;

Console.WriteLine($"max = {maxNum}");