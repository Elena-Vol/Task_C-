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

int[,] MaxMinRows(int[,] matrix)
{
    int[,] matrixMN = new int[matrix.GetLength(0), matrix.GetLength(1)];
    //int max = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // matrixMN[i, 0] = matrix[i, 0];

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > matrix[i, j + 1])
            {
                matrixMN[i, j] = matrix[i, j + 1];
            }
            else matrixMN[i, j] = matrix[i, j];
        }

    }
    return matrixMN;
}



int[,] array2D = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[,] maxMinRows = MaxMinRows(array2D);
PrintMatrix(maxMinRows);




/* void MaxMinRows(int[,] matrix)
{
    int max = matrix[0, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
         // int max = matrix[0, j];

        for (int i = 1; i < matrix.GetLength(0)-1; i++)
        {
            int tmp = matrix[i, j];
            // int max = matrix[i, j];
            if (matrix[i, j] > max)
            {
                tmp = max;
                max = matrix[i, j];
                matrix[i, j] = tmp;
            }
        }
    }
} */



