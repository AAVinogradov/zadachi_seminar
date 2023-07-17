// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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


int [,] SortArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];  
                    matrix[i, k] = temp;
                }
            }   
        }
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
Console.WriteLine("Отсортированный массив: ");
int [,] sortMatrix = SortArray(myMatrix);
PrintMatrix(sortMatrix);