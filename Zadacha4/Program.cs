// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = Random.Shared.Next(10, 100); //рандомные числа от 10 до 99
Console.WriteLine(number);
int LastDigit = number % 10; //получаем последнее число
int FirstDigit = number / 10; //получение первого числа

if(FirstDigit > LastDigit)
{
    Console.WriteLine(FirstDigit);
}
else if(LastDigit > FirstDigit)
{
    Console.WriteLine(LastDigit);
}
else
{
    Console.WriteLine("Числа равны");
}