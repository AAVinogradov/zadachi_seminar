// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98


int number = Random.Shared.Next(100, 1000); //рандомные числа от 100 до 999
Console.WriteLine(number);
int FirstDigit = (number / 100) % 10; 
Console.WriteLine(FirstDigit);
int LastDigit = number % 10; 
Console.WriteLine(LastDigit);
int MidDigit = FirstDigit * 10 + LastDigit;
Console.WriteLine(MidDigit);