// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


int [,] SummCountRows(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        int summCountRows = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        { 
            summCountRows = (summCountRows + matrix[i, j]);

        }
        Console.WriteLine($"Сумма чисел в строке с индексом {i} = {summCountRows}");
    }
    return matrix;
}    

int [,] MinSummCountRows(int[,] matrix)
{
    int minSumElementsRow = 0;
    int summCountRows = 0;
    int row = 0;
    
    for(int i = 0; i < matrix.GetLength(1); i++)
    {
        minSumElementsRow = (minSumElementsRow + matrix[0, i]);
    }    
    for (int i = 0; i < matrix.GetLength(0); i++)
        { 
            for (int j = 0; j < matrix.GetLength(1); j++)
            summCountRows = summCountRows + matrix[i, j];
            {
            if (summCountRows < minSumElementsRow)   
            {
                minSumElementsRow = summCountRows;
                row = i;
            } 
               summCountRows = 0;
            }   
        }
        Console.WriteLine($"Индекс строки с минимальной суммой - {row} (строка по позиции - {row + 1}) с суммой чисел {minSumElementsRow}");   
        return matrix;
}    


Console.Write("Введите число строк в массиве: ");
int sizeRowsMatrix = ManualInput();

Console.Write("Введите число столбцов в массиве: ");
int sizeColumnsMatrix = ManualInput();

int [,] myMatrix = GetRandomMatrix(sizeRowsMatrix, sizeColumnsMatrix);
Console.WriteLine();
Console.WriteLine("Сгененрированный массив ");
PrintMatrix(myMatrix);
Console.WriteLine("-----------------------------------------");
Console.WriteLine("Подсчет суммы чисел в строках: ");
int [,] Summ = SummCountRows(myMatrix);
Console.WriteLine("-----------------------------------------");
int [,] MinRow = MinSummCountRows(myMatrix);
