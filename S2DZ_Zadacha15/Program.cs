﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет


Console.Write("Введите день недели от, где 1 это понедельник, 7 воскресенье: ");
int nday = Convert.ToInt32(Console.ReadLine());

if (nday == 6 || nday == 7)
{
     Console.WriteLine("Этот день выходной");
}
else if (nday >= 1 && nday < 5)
{
    Console.WriteLine("Работай, нигер, солнце еще высоко, это не выходной");
}
else if (nday == 5)
{
    Console.WriteLine("Не выходной, братишка, но это пятничкааа!");
}
else if (nday < 1 || nday > 7)
{
    Console.WriteLine("Нет такого дня, возвращайся на свою пранету");
}