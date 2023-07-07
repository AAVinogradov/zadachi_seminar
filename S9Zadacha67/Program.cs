// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int count = 453;

int SumCount(int number)
{
    if (number <= 0) return 0;
    return SumCount(number / 10) + (number % 10);
    // Console.Write (number + "   " );
}
Console.WriteLine(SumCount(count));
