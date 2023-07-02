// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt()
{
    Console.WriteLine("Введите число");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Exponentiation(int num, int deg)
{
int number = 1;
    for (int i = 1; i <= deg; i++)
    {
        number = number * num;
       
    }
    return number;
}

int number = ReadInt();
int degree = ReadInt();
int result = Exponentiation(number, degree);
Console.WriteLine($"Число {number} в степени {degree} = {result}");