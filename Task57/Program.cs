// Задача 57: 
// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

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
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

int[] StringArray (int[,] array)
{
    int[] newArray = new int[array.GetLength(0)*array.GetLength(1)];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[k] = array[i,j];
            k++;
        }
    }
    return newArray;
}

void RepitingDigits(int[] array)
{
    int index = 1;
    while (index < 10)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (index == array[i])
            count++;
        }
        Console.WriteLine($"{index} повторяется в массиве {count} раз");
        index++;
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
OutputArray(array, "Исходный массив: ");
int[] newArray = StringArray(array);
RepitingDigits(newArray);