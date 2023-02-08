/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
 */


/* Матрицу P можно умножить на матрицу K только в том случае, 
если число столбцов матрицы P равняется числу строк матрицы K. 
Матрицы, для которых данное условие не выполняется, умножать нельзя.  */


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

int[,] ProdactMatrix(int[,] MatrixA, int[,] MatrixB)
{
    int[,] resMass = new int[MatrixA.GetLength(0), MatrixB.GetLength(1)];
    for (int i = 0; i < MatrixA.GetLength(0); i++)
        for (int j = 0; j < MatrixB.GetLength(1); j++)
            for (int k = 0; k < MatrixA.GetLength(1); k++)
                resMass[i, j] += MatrixA[i, k] * MatrixB[k, j];
    return resMass;
}


int[,] array2DA = CreateMatrixRndInt(4, 2, 0, 5);
PrintMatrix(array2DA);
Console.WriteLine();
int[,] array2DB = CreateMatrixRndInt(2, 3, 0, 5);
PrintMatrix(array2DB);
Console.WriteLine();
if (array2DA.GetLength(1) == array2DB.GetLength(0))
{
    int[,] prodactMatrix = ProdactMatrix(array2DA, array2DB);
    PrintMatrix(prodactMatrix);
}
else Console.WriteLine("матрицы перемножить нельзя");