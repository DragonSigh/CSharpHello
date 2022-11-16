int varA;

while (true)
{
        Console.Write("Введите трёхзначное число: ");
        if (int.TryParse(Console.ReadLine(), out varA))
            if (varA > 99 && varA < 1000)
              break;
        Console.WriteLine("Ошибка ввода!");
}

int result = varA % 100 / 10;

Console.WriteLine($"{varA} -> {result}");