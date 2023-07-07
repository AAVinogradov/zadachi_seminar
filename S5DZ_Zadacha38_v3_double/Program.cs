// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// // [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("__________ВЕЩЕСТВЕННЫЕ ЧИСЛА__________");

double[] ManualInput()
{
    Console.Write("Введите длмнну масива: ");
    int elementsCount = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[elementsCount];
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент масива под индексом {i}: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine("Вывод массива: ");
    for(int i = 0; i < elementsCount; i++)
    {
    Console.WriteLine(array [i]);
    }
    return array; 
}
double Difference(double[] massive)
{
    double maxElements = massive[0];
    double minElements = massive[0];
    for(int i = 0; i < massive.Length; i++)
    {
        if (massive[i] > maxElements)
        {
            maxElements = massive[i];
        }
    }    
    for(int i = 0; i < massive.Length; i++)  
    {  
     if (massive[i] < minElements)
        {
            minElements = massive[i];
        }
        
    }
    double dif = maxElements - minElements;
    return dif;
}

double[] myArray = ManualInput();
Console.Write("Сгенерированный массив:");
Console.WriteLine($"[{string.Join(" ", myArray)}]");
Console.WriteLine();
double difference = Difference(myArray);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {string.Format("{0:N2}", difference)}");

