// Уравнение 1: y = k1 * x + b1;
// Уравнение 2: y = k2 * x + b2.
//
// Решив систему уравнений, получим уравнения координаты точки пересечения:
// x = (b2 - b1) / (k1 - k2);
// y = (k1 * x + b2).
//
// Прямые параллельны при k1 == k2.

void IntersectionPoint()
{
    Console.Write("Введите коэффициент k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите коэффициент b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите коэффициент k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите коэффициент b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());

    if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны, не стоит искать точку пересечения.");
    }

    else
    {
        double x = ((b2 - b1) / (k1 - k2));
        double y = (k2 * x + b2);
        Console.WriteLine($"Точка пересечения прямых: [{Math.Round(x, 2)}, {Math.Round(y, 2)}].");
    }
}

IntersectionPoint();
Console.ReadLine();