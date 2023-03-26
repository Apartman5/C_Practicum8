// Задача 55: 
// Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести 
// сообщение для пользователя.

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

int[,] ExchangeArray(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[j, i] = array[i, j];
        }
    }
    return newArray;
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

if(m == n)
{
    int [,] array = CreateArray(n, m);
    OutputArray(array, "Исходный массив: ");
    int[,] newArray = ExchangeArray(array);
    OutputArray(newArray, "Конечный массив: ");
}
else Console.WriteLine("Невозможно перевернуть массив");