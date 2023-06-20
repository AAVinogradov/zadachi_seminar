// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[6]; // после new выделяется размер под массив - выделение памяти. 
// array[5] = 4;
// array[4] = 2;
// int value = array[0];
// array[0] = value;

int number = 8;
int[] array = new int[6]; // после new выделяется размер под массив - выделение памяти. 

for (int i = 0; i < array.Length; i++)
{
    array[i] = Random.Shared.Next(0, 2);
    Console.WriteLine(array[i]);
}
