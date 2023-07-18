// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int ManualInput()
{
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,,] GetRandomMatrix(int rows, int columns, int planes)
{
    int[,,] matrix = new int[rows, columns, planes];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                 matrix[i, j, k] = Random.Shared.Next(10, 100);
            }
        }
    }
    return matrix;
}


void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.WriteLine($"{matrix[i, j, k]}({i},{j},{k})\t");
            }
        }
        
    }
}


Console.Write("Введите число строк в массиве: ");
int sizeRowsMatrix = ManualInput();

Console.Write("Введите число столбцов в массиве: ");
int sizeColumnsMatrix = ManualInput();

Console.Write("Введите число слоев в массиве: ");
int sizePlaneMatrix = ManualInput();

int [,,] myMatrix1 = GetRandomMatrix(sizeRowsMatrix, sizeColumnsMatrix, sizePlaneMatrix);
Console.WriteLine();
Console.WriteLine("Сгененрированный массив: ");
PrintMatrix(myMatrix1);



