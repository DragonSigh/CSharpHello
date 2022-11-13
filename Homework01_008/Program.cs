Console.Write("Введите целое число: ");
int numberN = int.Parse(Console.ReadLine() ?? "");

int i = 1;

while (i <= numberN)
 {
    if (i % 2 == 0) Console.Write($"{i}, "); i++;
 }