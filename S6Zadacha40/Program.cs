// адача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Вееди сторону А ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вееди сторону B ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вееди сторону C ");
int C = Convert.ToInt32(Console.ReadLine());

if(A + B > C && A + C > B && B + C > A)
{
    Console.WriteLine("Да может");
}
else
{
    Console.WriteLine("Нет, не может");
}