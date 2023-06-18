// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else if (N <= 999)
{
int Midle = (N / 10) % 10; 
Console.Write("Вторая цифра: ");
Console.WriteLine(Midle);
}



