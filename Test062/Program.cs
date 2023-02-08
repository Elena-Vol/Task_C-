/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */


int[,] CreateMatrixSpiralInt(int rows, int collunms, int min, int max)
{
    int[,] matrix = new int[rows, collunms];
    int s = 1;

    //Заполняем периметр массива по часовой стрелке.
    for (int y = 0; y < matrix.GetLength(1); y++)
    {
        matrix[0, y] = s;
        s++;
    }
    for (int x = 1; x < matrix.GetLength(0); x++)
    {
        matrix[x, matrix.GetLength(1) - 1] = s;
        s++;
    }
    for (int y = matrix.GetLength(1) - 2; y >= 0; y--)
    {
        matrix[matrix.GetLength(0) - 1, y] = s;
        s++;
    }
    for (int x = matrix.GetLength(0) - 2; x > 0; x--)
    {
        matrix[x, 0] = s;
        s++;
    }

    //Периметр заполнен. Продолжаем заполнять массив и задаём
    //координаты ячейки, которую необходимо заполнить следующей.
    int c = 1;
    int d = 1;

    while (s < matrix.GetLength(0) * matrix.GetLength(1))
    {
        //Движемся вправо.
        while (matrix[c, d + 1] == 0)
        {
            matrix[c, d] = s;
            s++;
            d++;
        }

        //Движемся вниз.
        while (matrix[c + 1, d] == 0)
        {
            matrix[c, d] = s;
            s++;
            c++;
        }

        //Движемся влево.
        while (matrix[c, d - 1] == 0)
        {
            matrix[c, d] = s;
            s++;
            d--;
        }

        //Движемся вверх.
        while (matrix[c - 1, d] == 0)
        {
            matrix[c, d] = s;
            s++;
            c--;
        }
    }

    //При данном решении в центре всегда остаётся незаполненная ячейка.
    //Убираем её при помощи следующего цикла.
    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            if (matrix[x, y] == 0)
            {
                matrix[x, y] = s;
            }
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



int[,] matrixSpiralInt = CreateMatrixSpiralInt(4, 4, 0, 20);
PrintMatrix(matrixSpiralInt);

