// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]



Console.Write("Введите длмнну масива: ");
int elementsCount = Convert.ToInt32(Console.ReadLine());
int[] array = new int[elementsCount];
for(int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент масива под индексом {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Вывод массива: ");
for(int i = 0; i < elementsCount; i++)
    {
    Console.WriteLine(array [i]);
    }

        
