// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = a * x + c, y = b * x + d; значения c, a, d и b задаются пользователем.

// c = 2, a = 5, d = 4, b = 9 -> (-0,5; -0,5)

double ManualInput()
{
    // Console.WriteLine("Введите число");
    double value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double coordinateX(double a, double b, double c, double d)
{
    double x = 0;
    if(a != b)
    {
        x = (d - c) / (a - b);
    }
    else
    Console.WriteLine();
    return x;
}

double coordinateY(double a, double b, double c, double d)
{
    double y = 0;
    if(a != b)
    {
        y = a * ((d - c) / (a - b)) + c;
    }
    else
    Console.WriteLine();
    return y;
}


Console.Write("Введите угловой коээфициент a (k1): ");
double meaningA = ManualInput();
Console.Write("Введите угловой коээфициент b (k2): ");
double meaningB = ManualInput();
Console.Write("Введите значение пересечения с осью У - c (b1): ");
double meaningC = ManualInput();
Console.Write("Введите значение пересечения с осью У - d (b2): ");
double meaningD = ManualInput();

double xCoordinate = coordinateX(meaningA, meaningB, meaningC, meaningD);
double yCoordinate = coordinateY(meaningA, meaningB, meaningC, meaningD);

if(meaningA != meaningB)
{
Console.WriteLine($"Точка пересечения {xCoordinate} ; {yCoordinate}");
}
else
Console.WriteLine($"Параллельные прямые не пересекаются!");