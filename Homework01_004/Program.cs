Console.Write("Введите первое целое число: ");
int numA = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе целое число: ");
int numB = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите третье целое число: ");
int numC = int.Parse(Console.ReadLine() ?? "");

int maxNum = numA;

if (numB > maxNum) maxNum = numB;
if (numC > maxNum) maxNum = numC;

Console.WriteLine($"Максимальное из трёх чисел: {maxNum}");