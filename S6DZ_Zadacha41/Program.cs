// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

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

double PositiveNumbers(double[] massive)
{
    double positiveNum = 0;
    
    for(int i = 0; i < massive.Length; i++)
    {
        if (massive[i] > 0)
        {
            positiveNum = positiveNum + 1;
        }
    }    
    return positiveNum;
}

double[] myArray = ManualInput();
Console.Write("Сгенерированный массив:");
Console.WriteLine($"[{string.Join(" ", myArray)}]");
Console.WriteLine();
double positive = PositiveNumbers(myArray);
Console.WriteLine($"Количество положительных чисел в массиве = {string.Format("{0:N0}", positive)}");