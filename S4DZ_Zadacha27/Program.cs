// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt()
{
    Console.WriteLine("Введите число");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int SummaAllDigital(int digital)
{
    int result = 0;
    while (digital > 0)
    {
        result = result + digital % 10;
        digital = digital / 10;
    }
    return result;
}

int digital = ReadInt();
int SumDigital = SummaAllDigital(digital);
Console.WriteLine($"Сумма чисел цифры {digital} будет равна - {SumDigital}");