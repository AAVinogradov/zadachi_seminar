// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.


int ManualInput()
{
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}


int [,] ArithmeticMean(int[,] matrix)

{
    
    Console.WriteLine($"Количество строк в матрице {matrix.GetLength(0)}");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double arithmeticMean = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            arithmeticMean = (arithmeticMean + matrix[i, j]);
        }
        Console.WriteLine($"Среднее арифметическое столбца с индексом {j} = {string.Format("{0:N2}", (arithmeticMean / matrix.GetLength(0)))}");
    }
    return matrix;
}


Console.Write("Введите число строк в массиве: ");
int sizeRowsMatrix = ManualInput();

Console.Write("Введите число столбцов в массиве: ");
int sizeColumnsMatrix = ManualInput();

int [,] myMatrix = GetRandomMatrix(sizeRowsMatrix, sizeColumnsMatrix);
Console.WriteLine();
Console.WriteLine("Сгенерированный массив: ");
PrintMatrix(myMatrix);
Console.WriteLine("-----------------------------------------");

int [,] arithmeticMeanSumm = ArithmeticMean(myMatrix);
