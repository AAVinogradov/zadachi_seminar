// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int ManualInput()
{
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetRandomMatrix(int rows, int columns)
{
    
    int temp = 1;
    int i = 0;
    int j = 0;
    int[,] matrix = new int[rows, columns];
    
    while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = temp;
        temp = temp + 1;
  if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
    j = j + 1;
  else if (i < j && i + j >= matrix.GetLength(0) - 1)
    i = i+ 1;
  else if (i >= j && i + j > matrix.GetLength(1) - 1)
    j = j - 1;
  else
    i = i - 1;
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


Console.Write("Введите количество строк в массиве: ");
int sizeRowsMatrix = ManualInput();

Console.Write("Введите количество столбцов в массиве: ");
int sizeColumnsMatrix = ManualInput();
if(sizeRowsMatrix != sizeColumnsMatrix)
    {
        Console.WriteLine("Некорректные размеры, попробуйте ввести еще раз, при условии, что количество стобцов должно быть равно количеству строк");
    }
    else
    {
    int [,] myMatrix1 = GetRandomMatrix(sizeRowsMatrix, sizeColumnsMatrix);
        Console.WriteLine("Сгененрированный массив: ");
        PrintMatrix(myMatrix1);
    }

