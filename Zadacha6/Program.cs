﻿// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = numberA % numberB;
Console.WriteLine(numberC);
if (numberB !=0)
{
    Console.WriteLine(numberC);
}
else
{
    Console.WriteLine("Второе число кратно первому");
}