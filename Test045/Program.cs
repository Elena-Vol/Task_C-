// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

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
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] CoppyArray (int[] array)
{
    int[] coppyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        coppyArray[i] = array[i];
    }
    return  coppyArray;
}


int[] arr = CreateArrayRndInt(6,1,9);
PrintArray(arr);
int[] copy = CoppyArray(arr);
// copy[0] = 15;
PrintArray(copy);

// Console.WriteLine($"{PrintArray(arr)} -> {PrintArray(copy)}");





/* int[] GenerateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

string PrintArray(int[] arr)
{
    string array = ($"{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        array = array + ($", {arr[i]}");
    }
    return array;
}

int[] CopyArray(int[] arr)
{
    int[] copyArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArray[i] = arr[i];
    }
    return copyArray;
}

int[] array = GenerateArray(6,1,9);
int[] copy = CopyArray(array);
Console.WriteLine($"{PrintArray(array)} -> {PrintArray(copy)}"); */
