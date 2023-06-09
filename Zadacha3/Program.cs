// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число N ");
String? N = Console.ReadLine();
int IntN = Convert.ToInt32(N);
for (int i = -IntN ; i<=IntN; i++)
{
Console.WriteLine(i);
}

