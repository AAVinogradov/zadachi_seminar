// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите значение N: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение точки отсчета: ");
int number = Convert.ToInt32(Console.ReadLine());



if (x > number)
{
    Console.Write("Не верно задан промежуток ");  
}
else
{

void Enumeration(int FirstNumber, int NumberN )
{
    if (FirstNumber > NumberN) return;
    Enumeration(FirstNumber + 1, NumberN);
    Console.Write (FirstNumber + "   " );

}
      

Enumeration(x, number);

}



