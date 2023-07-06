// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// // [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("__________ВЕЩЕСТВЕННЫЕ ЧИСЛА__________");

double[] GetRandomArray()
{
    double[] array = new double[10];
    Random rand = new Random();
   
for(int i = 0; i < array.Length; i++)
    {
    array[i] = 5 - rand.Next(11) + rand.NextDouble();
    }
    return array; 
}

double MaximumElements(double[] massive)
{
    double maxElements = 0;
    for(int i = 0; i < massive.Length; i++)
    {
        while(massive[i] > maxElements)
        maxElements = massive[i];
    }
    return maxElements;
}

double MinimumElements(double [] massive)
{
    double minElements = 0;
    for(int i = 0; i < massive.Length; i++)
    {
        while(massive[i] < minElements)
        minElements = massive[i];
    }
    return minElements;
}


double Difference(double a, double b)
{
    double dif = 0;
    if (a != b)
    {
        dif = a - b;
    }
return dif;
}

Console.WriteLine();

double[] myArray = GetRandomArray();
Console.Write("Сгенерированный массив:");
Console.WriteLine($"[{string.Join(" ", myArray)}]");
Console.WriteLine();
double maximumElements = MaximumElements(myArray);
Console.WriteLine($"Максимальный элемент массива = {string.Format("{0:N2}", maximumElements)}");
Console.WriteLine();
double minimumElements = MinimumElements(myArray);
Console.WriteLine($"Минимальный элемент массива = {string.Format("{0:N2}", minimumElements)}");
double difference = Difference(maximumElements, minimumElements);

Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {string.Format("{0:N2}", difference)}");
