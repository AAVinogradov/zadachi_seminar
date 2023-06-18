// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите число число не больше 2147483647: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (N >= 100 && N <= 999)
{
int Midle = (N / 1) % 10; 
Console.Write("Третья цифра: ");
Console.WriteLine(Midle);
}
else if (N >= 1000 && N <= 9999)
{
int Midle = (N / 10) % 10; 
Console.Write("Третья цифра: ");
Console.WriteLine(Midle);
}
else if (N >= 10000 && N <= 99999)
{
int Midle = (N / 100) % 10; 
Console.Write("Третья цифра: ");
Console.WriteLine(Midle);
}
else if (N >= 100000 && N <= 999999)
{
int Midle = (N / 1000) % 10; 
Console.Write("Третья цифра: ");
Console.WriteLine(Midle);
}
else if (N >= 1000000 && N <= 9999999)
{
int Midle = (N / 10000) % 10; 
Console.Write("Третья цифра: ");
Console.WriteLine(Midle);
}
else if (N >= 1000000 && N <= 9999999)
{
int Midle = (N / 100000) % 10; 
Console.Write("Третья цифра: ");
Console.WriteLine(Midle);
}
else if (N >= 10000000 && N <= 99999999)
{
int Midle = (N / 100000) % 10; 
Console.Write("Третья цифра: ");
Console.WriteLine(Midle);
}
else if (N >= 100000000 && N <= 999999999)
{
int Midle = (N / 1000000) % 10; 
Console.Write("Третья цифра: ");
Console.WriteLine(Midle);
}
else if (N >= 1000000000 && N <= 2147483647)
{
int Midle = (N / 10000000) % 10; 
Console.Write("Третья цифра: ");
Console.WriteLine(Midle);
}