// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 9
// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int numberM, int numberN)
{
    if (numberM == 0) 
    {
        return numberN + 1;
    }
    else if (numberM > 0 && numberN == 0)
    {
        return AkkermanFunction(numberM - 1, 1);
    }
    else
    {
        return AkkermanFunction(numberM - 1, AkkermanFunction(numberM, numberN - 1));
    }  
}

int akkermanFunction = AkkermanFunction(m, n);
Console.WriteLine($"Функция Аккермана чисел {m} и {n} = {akkermanFunction}");

