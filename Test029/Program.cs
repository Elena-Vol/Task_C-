/* Напишите программу, которая задаёт массив из 8 элементов и 
выводит их на экран.
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33] */


int[] GenerateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random(); // это будет работать на всех средах разработки!
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int length = arr.Length - 1;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write(arr[length]);
}

int[] array = GenerateArray(8, 0, 10);
PrintArray(array); Console.Write(" -> [ "); PrintArray(array); Console.WriteLine("]");



