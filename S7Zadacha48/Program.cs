// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

const int rows = 3;
const int columns = 4;
Console.WriteLine("Сгенерированный массив: ");
int[,] GetRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
            
            Console.Write($"{matrix[i, j]} \t");
        }
         Console.WriteLine();
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = + i + j;
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }

}

int[,]myMatrix = GetRandomMatrix(rows, columns);
// Console.WriteLine(string.Join(", ", myMatrix)); // с двумерными массивами данная команда не нработает
Console.WriteLine("Массив по формулев:");
PrintMatrix(myMatrix);