// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetRandomArray()
{
    int[] array = new int[12];
for(int i = 0; i < array.Length; i++)
    {
    array[i] = Random.Shared.Next(100, 1000);
    }
    return array;
}

int QuantityEvenNumbers(int[] massive)
{
    int evenNumbers = 0;
    for(int i = 0; i < massive.Length; i++)
    {
        if (massive[i] % 2 == 0)
        {
            evenNumbers = evenNumbers + 1;
        }
    }
    return evenNumbers;
}

int[] myArray = GetRandomArray();
int QuantityEven = QuantityEvenNumbers(myArray);

Console.Write("Сгенерированный массив:");
Console.WriteLine($"[{string.Join(" ", myArray)}]");
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве {string.Join(", ", myArray)} = {QuantityEven}");
