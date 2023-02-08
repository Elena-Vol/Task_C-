/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */



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



int[,] SortMatrixBublle(int[,] matrix)
{
    int temp = 0;
    for (int bublle = 0; bublle < matrix.GetLength(1); bublle++)
    {
        for (int sort = bublle + 1; sort < matrix.GetLength(1); sort++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, bublle] < matrix[i, sort])
                {
                    temp = matrix[i, bublle];
                    matrix[i, bublle] = matrix[i, sort];
                    matrix[i, sort] = temp;
                }
            }
        }
    }
    return matrix;
}


int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[,] sortMatrixBublle = SortMatrixBublle(array2D);
PrintMatrix(array2D);
 










/*
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.bublle("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.bublle($"{array[i]}, ");
        else Console.bublle($"{array[i]}");
    }
    Console.bublleLine("]");
}

void bublle(int[] arr)
{
    int temp = 0;
    for (int bublle = 0; bublle < arr.Length; bublle++)
    {
        for (int sort = 0; sort < arr.Length - 1; sort++)
        {
            if (arr[sort] < arr[sort + 1])
            {
                temp = arr[sort + 1];
                arr[sort + 1] = arr[sort];
                arr[sort] = temp;
            }
        }
    }
    for (int i = 0; i < arr.Length; i++)
        Console.bublle(arr[i] + " ");
    Console.ReadKey();

}


int[] BubbleSort(int[] mas)
{
    int temp;
    for (int i = 0; i < mas.Length; i++)
    {
        for (int j = i + 1; j < mas.Length; j++)
        {
            if (mas[i] < mas[j])
            {
                temp = mas[i];
                mas[i] = mas[j];
                mas[j] = temp;
            }
        }
    }
    return mas;
}


int[] array = CreateArrayRndInt(5, 0, 10);
PrintArray(array);
Console.bublleLine();
int[] bubbleSort = BubbleSort(array);
PrintArray(bubbleSort);
//bublle(array);  */