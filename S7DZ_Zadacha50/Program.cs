// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 2



const int rows = 5;
const int columns = 4;


double ManualInput()
{
    double value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double[,] GetRandomMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10; 
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
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

double[,] ChangeMatrix(double[,] matrix, double row, double col)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (row < 0 | row > matrix.GetLength(0)-1 || col < 0 | col > matrix.GetLength(1)-1)
            {
                Console.Write("Такого числа нет!");
                break;
            }
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == row && j == col)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            else if (row < 0 | row > matrix.GetLength(0)-1 || col < 0 | col > matrix.GetLength(1)-1)
            {
                Console.Write("Такого числа нет!");
                break;
            }
            
            else
            {
                Console.Write("*\t");
            }
                       
        }
        
        Console.WriteLine();
        
    }
    return matrix;
}
double [,] myMatrix = GetRandomMatrix(rows, columns);
Console.WriteLine("Сгенерированный массив: ");
PrintMatrix(myMatrix);
Console.Write("Введите индекс строки ");
double rowsIndex = ManualInput();
Console.Write("Введите индекс столбца ");
double columnsIndex = ManualInput();
double [,] elementsMatrix = ChangeMatrix (myMatrix, rowsIndex, columnsIndex); 

