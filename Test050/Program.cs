/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3} | ");
            else Console.Write($"{matrix[i,j], 3} ");
        }
        Console.WriteLine("|");
    }
}


bool DiapozonMatrix (int[,] matr, int rows, int collunms)
{
    return (rows < matr.GetLength(0)) && (collunms < matr.GetLength(1));
}

Console.Write("Введите номер строки ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца ");
int collunm = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2D);
if (DiapozonMatrix(array2D, row, collunm))  
{
    Console.WriteLine($"Значение элемента массива с индексом [{row}, {collunm}] равно: {array2D[row, collunm]}");
}
else Console.WriteLine("такого числа в массиве нет");




