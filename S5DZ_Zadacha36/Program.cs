// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomArray()
{
    int[] array = new int[10];
for(int i = 0; i < array.Length; i++)
    {
    array[i] = Random.Shared.Next(-10, 11);
    }
    return array;
}

int SumOfOddElements(int[] massive)
{
    int oddElements = 0;
    for(int i = 1; i < massive.Length; i+=2)
    {
        oddElements = massive[i] + oddElements;
    }
    return oddElements;
}

int[] myArray = GetRandomArray();
int sumOddElements = SumOfOddElements(myArray);

Console.Write("Сгенерированный массив:");
Console.WriteLine($"[{string.Join(" ", myArray)}]");
Console.WriteLine();
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях {string.Join(", ", myArray)} = {sumOddElements}");