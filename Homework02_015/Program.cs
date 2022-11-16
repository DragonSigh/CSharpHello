// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int varA;

// Проверяем правильность ввода
while (true)
{
        Console.Write("Введите порядковый номер дня недели: ");
        if (int.TryParse(Console.ReadLine(), out varA))
            if (varA > 0 && varA < 8)
              break;
        Console.WriteLine("Ошибка ввода!");
}

// Если цифра больше 5, то это выходной
if (varA > 5)
    Console.WriteLine($"{varA} -> да");
else
    Console.WriteLine($"{varA} -> нет");