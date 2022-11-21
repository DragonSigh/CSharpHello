// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
int X1 = 0, X2 = 0, Y1 = 0, Y2 = 0, Z1 = 0, Z2 = 0;
InitCoordinatesByUser(ref X1, ref X2, ref Y1, ref Y2, ref Z1, ref Z2); // Вызов метода с передачей параметров по ссылке (ref)
PrintResult(X1, X2, Y1, Y2, Z1, Z2);          // Вызов метода с передачей параметров по значению

static void InitCoordinatesByUser(ref int X1, ref int X2, ref int Y1, ref int Y2, ref int Z1, ref int Z2)
{
    try
    {
        Console.Write("Введите X1: ");
        X1 = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Y1: ");
        Y1 = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Z1: ");
        Z1 = int.Parse(Console.ReadLine() ?? "");

        Console.Write("Введите X2: ");
        X2 = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Y2: ");
        Y2 = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Z2: ");
        Z2 = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}

static void PrintResult(int X1, int X2, int Y1, int Y2, int Z1, int Z2)
{
    double result = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
    result = Math.Round(result, 2);
    Console.WriteLine($"A({X1},{Y1},{Z1}); B({X2},{Y2},{Z2}) -> {result}");
}
