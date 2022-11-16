// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int varA;

// Проверяем правильность ввода
while (true)
{
        Console.Write("Введите трёхзначное число: ");
        if (int.TryParse(Console.ReadLine(), out varA))
            if (varA > 99 && varA < 1000)
              break;
        Console.WriteLine("Ошибка ввода!");
}

// Вычисляем результат
int result = (varA / 10) % 10;

Console.WriteLine($"{varA} -> {result}");