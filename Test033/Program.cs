/* Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */

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

bool NumberInArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        // array[2] = 3;
        if (num == array[i])
        {
            return true;
        }
    }
    return false;
}


Console.WriteLine("Ведите число ");
int number = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(5, -9, 9);
PrintArray(arr);
bool numberInArray = NumberInArray(arr, number);
Console.WriteLine($"Число в массиве: {numberInArray}");


