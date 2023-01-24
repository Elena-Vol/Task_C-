/*  Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */


int[] array = new int[8];
FillArray(array);
Console.Write(" -> ["); PrintArray(array); Console.WriteLine("]");
Console.WriteLine();


void FillArray(int[] Collection)
{
    int length = Collection.Length;
    for (int i = 0; i < length; i++)
    {   
        Collection[i] = new Random().Next(0, 2);
    }
}
    // int index = 0;
    // while (index < length)
    //{
    //    Collection[index] = new Random().Next(0, 2);
//  index++;
//   }


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}




/* int[] GenerateArray(int size,int min, int max)
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
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} " );
    }
}

int [] array = GenerateArray(8, 0, 1);
PrintArray(array); */






/* int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i ++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort (int[] array)
{
    for (int i = 0; i < array.Length - 1; i ++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j ++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}


PrintArray (arr);
SelectionSort (arr);

PrintArray (arr);

 */















/* int[] array = new int[8];
int[] array1 = new int[]{1, 2, 3, 4, 5};
var array3 = new int[8];
int[] array2 = {1, 2, 3};

array[0] = 123;
array[1] = 2;

int number = new Random().Next(10, 100); */

