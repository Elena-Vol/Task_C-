// Array.Sort(array);
/* Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.
 */


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

int[] MatrixInArray(int[,] matrix)
{
    int[] resultArray = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            resultArray[count++] = matrix[i, j];
        }
    }
    Array.Sort(resultArray);
    return resultArray;
}

void GetSameCountNubers(int[] arr)
{
    int tmp = arr[0]; int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (tmp == arr[i]) count++;
        else
        {
            Console.WriteLine($"{tmp} встречается - {count} раз"); tmp = arr[i]; count = 1;
        }
    }
    Console.WriteLine($"{tmp} встречается - {count} раз");
}



int[,] matrix = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(matrix);

int[] matr = MatrixInArray(matrix);
Array.Sort(matr);
PrintArray(matr);
GetSameCountNubers(matr);

