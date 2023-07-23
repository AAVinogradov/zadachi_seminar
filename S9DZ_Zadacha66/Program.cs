// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n)
{
    Console.Write("Не верно задан промежуток ");  
}

else
{

int NaturalNumbers(int numberM, int numberN)
{
    if (numberM > numberN) return 0;
    return numberM + NaturalNumbers(numberM + 1, numberN);
}
    

// NaturalNumbers(m, n);
Console.WriteLine(NaturalNumbers(m, n));
}