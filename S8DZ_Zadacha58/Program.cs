// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6


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


int[,] CompositionMatrix(int[,] matrix1, int[,] matrix2)
{
    // if(matrix1.GetLength(0) != matrix2.GetLongLength(0) || matrix1.GetLength(1) != matrix2.GetLongLength(1))
    // {
    //     Console.WriteLine("Перемножить невозможно, матрицы имеют различные размеры");
        
    // }
    // Ушел от проверки привязав размеры существующих матриц
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix2.GetLength(1); j++)
        { 
            matrix3[i, j] += matrix1[i, j] * matrix2[i, j];
        }
    }
        return matrix3;
}


Console.Write("Введите число строк в массиве: ");
int sizeRowsMatrix = ManualInput();

Console.Write("Введите число столбцов в массиве: ");
int sizeColumnsMatrix = ManualInput();

int [,] myMatrix1 = GetRandomMatrix(sizeRowsMatrix, sizeColumnsMatrix);
Console.WriteLine();
Console.WriteLine("Сгененрированный массив 1: ");
PrintMatrix(myMatrix1);

int [,] myMatrix2 = GetRandomMatrix(sizeRowsMatrix, sizeColumnsMatrix);
Console.WriteLine();
Console.WriteLine("Сгененрированный массив 2: ");
PrintMatrix(myMatrix2);

Console.WriteLine();

Console.WriteLine("Произведение массивов 1 и 2: ");
int [,] compMatrix = CompositionMatrix(myMatrix1, myMatrix2);
PrintMatrix(compMatrix);
