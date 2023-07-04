// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива

const int Rows = 3;
const int Columns = 4;
int[,] GetRandomMatrix(int row, int columns)
{
int[,] matrix = new int[row, columns];   
for(int i = 0; i < matrix.GetLength(0); i++)   //i строки     j столбцы
{
    for(int j = 0; j < matrix.GetLength(1); j++)    //гет лент - чисто строка
    {
        matrix[i, j] = Random.Shared.Next(1, 10);
    }
}
return matrix;
}
// Создали матрицу
void PrintMatrix(int[,] matrix)
{
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
}
// Создали метод

void SwapFirstAndLastRows(int[,] array)
{
    int rowCount = array.GetLength(0);
    int columnCount = array.GetLength(1);
    for(int j = 0; j < columnCount; j++)
    {
        int temp = array[0, j]; // временная переменная 
            array[0, j] = array[rowCount - 1, j];
            array[rowCount - 1, j] = temp;
    }
}
// метод Замена строк 
int[,] myMatrix = GetRandomMatrix(Rows, Columns);
PrintMatrix(myMatrix);
SwapFirstAndLastRows(myMatrix);
Console.WriteLine();
PrintMatrix(myMatrix);