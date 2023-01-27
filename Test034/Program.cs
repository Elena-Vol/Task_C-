/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) 
    {
        if (i< array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


int GetQuantEven (int[] array)
{
    int even = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 1) 
        {
            even += 1;
        }
    }
    return even;
}


int[] arr = CreateArrayRndInt(11, 100, 1000);
PrintArray(arr);
int quantEven = GetQuantEven(arr);
Console.WriteLine($"кол-во  четных чисел в массиве: {quantEven}");





/* int GetSumPozitiv (int[] array)
{
    int sum = default; // значение по умолчанию, т.е. ноль  int sum = 0
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum += array[i];
    }
    return sum;
}

int[] arr = CreateArrayRndInt(12, 100, 1000);
PrintArray(arr); 
int sumPozitiv = GetSumPozitiv (arr);
 */