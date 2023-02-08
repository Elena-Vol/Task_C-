/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


int[,] CreateMatrixRndInt(int rows, int collunms, int min, int max)
{
    int[,] matrix = new int[rows, collunms];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


int[] CreateArrayArithMean(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i] += matrix[i, j];
        }
    }
    return array;
}

int NumberRows(int[] array)
{
    int number = 0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            number = i;
        }
    }
    return number;
}

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 3);
PrintMatrix(array2D);
int[] arrayArithMean = CreateArrayArithMean(array2D);
Console.Write("суммы строк массива: ");
PrintArray(arrayArithMean);
int numberRows = NumberRows(arrayArithMean);
Console.WriteLine($"номер строки с наименьшей суммой элементов: {numberRows}");

// Console.WriteLine($"номер строки с наименьшей суммой элементов: {arrayArithMean}");

