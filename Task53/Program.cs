// Задача 53: 
// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую 
// и последнюю строку массива.

Console.WriteLine("Введите количество строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] CreateArray(int n, int m)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
    return array;
}

void ExchangeArray(int[,] array)
{
    int tmp = 0;
    int lastIndex = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        tmp = array[lastIndex, i];
        array[lastIndex, i] = array[0, i];
        array[0, i] = tmp;
    }
}

void OutputArray(int[,] array, string str)
{
    Console.WriteLine($"{str}");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int [,] array = CreateArray(n, m);
OutputArray(array, "Начальный массив: ");
ExchangeArray(array);
OutputArray(array, "Конечный массив: ");