// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// // [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("__________ЦЕЛЫЕ ЧИСЛА__________");

int[] GetRandomArray()
{
    int[] array = new int[10];
for(int i = 0; i < array.Length; i++)
    {
    array[i] = Random.Shared.Next(-10, 11);
    }
    return array;
}

int MaximumElements(int[] massive)
{
    int maxElements = 0;
    for(int i = 0; i < massive.Length; i++)
    {
        while(massive[i] > maxElements)
        maxElements = massive[i];
    }
    return maxElements;
}

int MinimumElements(int[] massive)
{
    int minElements = 0;
    for(int i = 0; i < massive.Length; i++)
    {
        while(massive[i] < minElements)
        minElements = massive[i];
    }
    return minElements;
}


int Difference(int a, int b)
{
    int dif = 0;
    if (a != b)
    {
        dif = a - b;
    }
return dif;
}


int[] myArray = GetRandomArray();
Console.Write("Сгенерированный массив:");
Console.WriteLine($"[{string.Join(" ", myArray)}]");
int maximumElements = MaximumElements(myArray);
Console.WriteLine($"Максимальный элемент массива {string.Join(", ", myArray)} = {maximumElements}");
int minimumElements = MinimumElements(myArray);
Console.WriteLine($"Минимальный элемент массива {string.Join(", ", myArray)} = {minimumElements}");
int difference = Difference(maximumElements, minimumElements);

Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива {string.Join(", ", myArray)} = {difference}");
